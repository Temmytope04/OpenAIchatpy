﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

#pragma warning disable AZC0014 // Avoid using banned types in public API

namespace Azure.Core
{
    /// <summary>
    /// A mutable representation of a JSON value.
    /// </summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    [DebuggerTypeProxy(typeof(JsonDataDebuggerProxy))]
    [JsonConverter(typeof(JsonConverter))]
    public class JsonData : IDynamicMetaObjectProvider, IEquatable<JsonData>
    {
        private readonly JsonValueKind _kind;
        private Dictionary<string, JsonData>? _objectRepresentation;
        private List<JsonData>? _arrayRepresentation;
        private object? _value;

        private static readonly JsonSerializerOptions DefaultJsonSerializerOptions = new JsonSerializerOptions();

        /// <summary>
        ///  Creates a new JsonData object which represents the value of the given JsonDocument.
        /// </summary>
        /// <param name="jsonDocument">The JsonDocument to convert.</param>
        /// <remarks>A JsonDocument can be constructed from a JSON string using <see cref="JsonDocument.Parse(string, JsonDocumentOptions)"/>.</remarks>
        public JsonData(JsonDocument jsonDocument) : this((object?)jsonDocument, DefaultJsonSerializerOptions, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonData"/> class.
        /// </summary>
        /// <param name="jsonString">The json string.</param>
        public JsonData(string jsonString) : this(JsonDocument.Parse(jsonString))
        {
        }

        /// <summary>
        /// Creates a new JsonData object which represents the given object.
        /// </summary>
        /// <param name="binaryData">The value to convert.</param>
        public JsonData(BinaryData binaryData) : this(binaryData.ToMemory())
        {
        }

        /// <summary>
        /// Creates a new JsonData object which represents the given object.
        /// </summary>
        /// <param name="bytes">The value to convert.</param>
        public JsonData(byte[] bytes) : this(JsonDocument.Parse(bytes))
        {
        }

        /// <summary>
        /// Creates a new JsonData object which represents the given object.
        /// </summary>
        /// <param name="bytes">The value to convert.</param>
        public JsonData(ReadOnlyMemory<byte> bytes) : this(JsonDocument.Parse(bytes))
        {
        }

        /// <summary>
        /// Creates a new JsonData object which represents the given object.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <param name="options">Options to control the conversion behavior.</param>
        public JsonData(object value, JsonSerializerOptions? options = null) : this(value, options ?? DefaultJsonSerializerOptions, null)
        {
        }

        /// <summary>
        /// Creates a new JsonData object which represents the given response content.
        /// </summary>
        /// <param name="response">The response containing JSON content to convert.</param>
        public JsonData(Response response) : this(response.Content)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonData"/> class.
        /// </summary>
        /// <param name="value">The string to consider.</param>
        /// <param name="treatAsPrimitive"><c>true</c> to treat the value as a primitive string; otherwise, the string will be treated as JSON and parsed.</param>
        internal JsonData(string value, bool treatAsPrimitive) : this(treatAsPrimitive ? (object?)value : JsonDocument.Parse(value), DefaultJsonSerializerOptions, null)
        {
        }

        /// <summary>
        /// Creates a new JsonData object which represents the given object.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <param name="options">Options to control the conversion behavior.</param>
        /// <param name="type">The type of the value to convert. </param>
        internal JsonData(object? value, JsonSerializerOptions options, Type? type = null)
        {
            _value = value;
            switch (value)
            {
                case long l:
                    _kind = JsonValueKind.Number;
                    _value = new Number(l);
                    break;
                case int i:
                    _kind = JsonValueKind.Number;
                    _value = new Number(i);
                    break;
                case double d:
                    _kind = JsonValueKind.Number;
                    _value = new Number(d);
                    break;
                case float d:
                    _kind = JsonValueKind.Number;
                    _value = new Number(d);
                    break;
                case bool b when b:
                    _kind = JsonValueKind.True;
                    break;
                case bool b when !b:
                    _kind = JsonValueKind.False;
                    break;
                case string:
                    _kind = JsonValueKind.String;
                    break;
                case null:
                    _kind = JsonValueKind.Null;
                    break;
                case JsonDocument doc:
                    _kind = doc.RootElement.ValueKind;
                    InitFromElement(doc.RootElement);
                    break;
                default:
                    JsonElement e = JsonDocument.Parse(JsonSerializer.Serialize(value, type ?? (value == null ? typeof(object) : value.GetType()), options)).RootElement;
                    _kind = e.ValueKind;
                    InitFromElement(e);
                    break;
            }
        }

        private JsonData(JsonElement element)
        {
            _kind = element.ValueKind;
            InitFromElement(element);
        }

        private void InitFromElement(JsonElement element)
        {
            switch (element.ValueKind)
            {
                case JsonValueKind.Object:
                    _objectRepresentation = new Dictionary<string, JsonData>();
                    foreach (var item in element.EnumerateObject())
                    {
                        _objectRepresentation[item.Name] = new JsonData(item.Value);
                    }
                    break;
                case JsonValueKind.Array:
                    _arrayRepresentation = new List<JsonData>();
                    foreach (var item in element.EnumerateArray())
                    {
                        _arrayRepresentation.Add(new JsonData(item));
                    }
                    break;
                case JsonValueKind.String:
                    _value = element.GetString();
                    break;
                case JsonValueKind.Number:
                    _value = new Number(element);
                    break;
                case JsonValueKind.True:
                case JsonValueKind.False:
                    _value = element.GetBoolean();
                    break;
                case JsonValueKind.Null:
                    _value = null;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(element), "Unsupported element kind");
            }
        }

        /// <summary>
        /// Returns the value for a given property.
        /// </summary>
        /// <typeparam name="T">The type of the object to return.</typeparam>
        /// <param name="propertyName">The name of the property to get.</param>
        /// <returns>The value for a given property</returns>
        /// <remarks>If the <see cref="Kind"/> property is not <see cref="JsonValueKind.Object"/> this method throws <see cref="InvalidOperationException"/>.</remarks>
        public T Get<T>(string propertyName)
        {
            return GetPropertyValue(propertyName).To<T>();
        }

        /// <summary>
        /// Gets the value of a property from an object.
        /// </summary>
        /// <typeparam name="T">The type of the object to return.</typeparam>
        /// <param name="propertyName">The name of the property to get.</param>
        /// <param name="options">Options to control the conversion behavior.</param>
        /// <returns>The value for a given property.</returns>
        /// <remarks>If the <see cref="Kind"/> property is not <see cref="JsonValueKind.Object"/> this method throws <see cref="InvalidOperationException"/>.</remarks>
        public T Get<T>(string propertyName, JsonSerializerOptions options)
        {
            return GetPropertyValue(propertyName).To<T>(options);
        }

        /// <summary>
        /// Gets the value of a property from an object, or <code>null</code> if no such property exists.
        /// </summary>
        /// <param name="propertyName">The name of the property to get</param>
        /// <returns>The value for a given property, or <code>null</code> if no such property exists.</returns>
        /// <remarks>If the <see cref="Kind"/> property is not <see cref="JsonValueKind.Object"/> this method throws <see cref="InvalidOperationException"/>.</remarks>
        public JsonData? Get(string propertyName)
        {
            if (EnsureObject().TryGetValue(propertyName, out JsonData? value))
            {
                return value;
            }

            return null;
        }

        /// <summary>
        /// Converts the given JSON value into an instance of a given type.
        /// </summary>
        /// <typeparam name="T">The type to convert the value into.</typeparam>
        /// <returns>A new instance of <typeparamref name="T"/> constructed from the underlying JSON value.</returns>
        public T To<T>() => To<T>(DefaultJsonSerializerOptions);

        /// <summary>
        /// Deserializes the given JSON value into an instance of a given type.
        /// </summary>
        /// <typeparam name="T">The type to deserialize the value into</typeparam>
        /// <param name="options">Options to control the conversion behavior.</param>
        /// <returns>A new instance of <typeparamref name="T"/> constructed from the underlying JSON value.</returns>
        public T To<T>(JsonSerializerOptions options)
        {
            // TODO: come back and address CS8603
            return JsonSerializer.Deserialize<T>(ToJsonString(), options)!;
        }

        /// <summary>
        /// Returns a stringified version of the JSON for this value.
        /// </summary>
        /// <returns>Returns a stringified version of the JSON for this value.</returns>
        public string ToJsonString()
        {
            using var memoryStream = new MemoryStream();
            using (var writer = new Utf8JsonWriter(memoryStream))
            {
                WriteTo(writer);
            }
            return Encoding.UTF8.GetString(memoryStream.ToArray());
        }

        /// <summary>
        /// Returns a <see cref="BinaryData"/> representation of the stringified version of the JSON for this value.
        /// </summary>
        /// <returns>Returns a <see cref="BinaryData"/> representation of the stringified version of the JSON for this value.</returns>
        public BinaryData ToBinaryData()
        {
            using var memoryStream = new MemoryStream();
            using (var writer = new Utf8JsonWriter(memoryStream))
            {
                WriteTo(writer);
            }
            return new BinaryData(memoryStream.ToArray());
        }

        /// <summary>
        /// Gets or sets a value at the given index in an array.
        /// </summary>
        /// <param name="arrayIndex">The index in the array of the value to get or set.</param>
        /// <returns>The value at the given index.</returns>
        /// <remarks>
        /// If the <see cref="Kind"/> property is not <see cref="JsonValueKind.Array"/> this method throws <see cref="InvalidOperationException"/>.
        /// </remarks>
        public JsonData this[int arrayIndex]
        {
            get => GetValueAt(arrayIndex);
        }

        /// <summary>
        /// Gets or sets a value for a given property in an object.
        /// </summary>
        /// <param name="propertyName">The name of the property in the object to get or set.</param>
        /// <returns>The value for the given property name.</returns>
        /// <remarks>
        /// If the <see cref="Kind"/> property is not <see cref="JsonValueKind.Object"/> this method throws <see cref="InvalidOperationException"/>.
        /// </remarks>
        public JsonData this[string propertyName]
        {
            get => GetPropertyValue(propertyName);
        }

        #region operators
        /// <summary>
        /// Converts the value to a <see cref="bool"/>
        /// </summary>
        /// <param name="json">The value to convert.</param>
        public static explicit operator bool(JsonData json) => json.GetBoolean();

        /// <summary>
        /// Converts the value to a <see cref="int"/>
        /// </summary>
        /// <param name="json">The value to convert.</param>
        public static explicit operator int(JsonData json) => json.GetIn32();

        /// <summary>
        /// Converts the value to a <see cref="long"/>
        /// </summary>
        /// <param name="json">The value to convert.</param>
        public static explicit operator long(JsonData json) => json.GetLong();

        /// <summary>
        /// Converts the value to a <see cref="string"/>
        /// </summary>
        /// <param name="json">The value to convert.</param>
        public static explicit operator string?(JsonData json) => json.GetString();

        /// <summary>
        /// Converts the value to a <see cref="float"/>
        /// </summary>
        /// <param name="json">The value to convert.</param>
        public static explicit operator float(JsonData json) => json.GetFloat();

        /// <summary>
        /// Converts the value to a <see cref="double"/>
        /// </summary>
        /// <param name="json">The value to convert.</param>
        public static explicit operator double(JsonData json) => json.GetDouble();

        /// <summary>
        /// Converts the value to a <see cref="bool"/>
        /// </summary>
        /// <param name="json">The value to convert.</param>
        public static explicit operator bool?(JsonData json) => json.Kind == JsonValueKind.Null ? null : json.GetBoolean();

        /// <summary>
        /// Converts the value to a <see cref="int"/> or null.
        /// </summary>
        /// <param name="json">The value to convert.</param>
        public static explicit operator int?(JsonData json) => json.Kind == JsonValueKind.Null ? null : json.GetIn32();

        /// <summary>
        /// Converts the value to a <see cref="long"/> or null.
        /// </summary>
        /// <param name="json">The value to convert.</param>
        public static explicit operator long?(JsonData json) => json.Kind == JsonValueKind.Null ? null : json.GetLong();

        /// <summary>
        /// Converts the value to a <see cref="float"/> or null.
        /// </summary>
        /// <param name="json">The value to convert.</param>
        public static explicit operator float?(JsonData json) => json.Kind == JsonValueKind.Null ? null : json.GetFloat();

        /// <summary>
        /// Converts the value to a <see cref="double"/> or null.
        /// </summary>
        /// <param name="json">The value to convert.</param>
        public static explicit operator double?(JsonData json) => json.Kind == JsonValueKind.Null ? null : json.GetDouble();

        /// <summary>
        /// Returns true if a <see cref="JsonData"/> has the same value as a given string,
        /// and false otherwise.
        /// </summary>
        /// <param name="left">The <see cref="JsonData"/> to compare.</param>
        /// <param name="right">The <see cref="string"/> to compare.</param>
        /// <returns>True if the given JsonData represents the given string, and false otherwise.</returns>
        public static bool operator ==(JsonData? left, string? right)
        {
            if (left is null && right is null)
            {
                return true;
            }

            if (left is null || right is null)
            {
                return false;
            }

            return left.Kind == JsonValueKind.String && ((string?)left._value) == right;
        }

        /// <summary>
        /// Returns false if a <see cref="JsonData"/> has the same value as a given string,
        /// and true otherwise.
        /// </summary>
        /// <param name="left">The <see cref="JsonData"/> to compare.</param>
        /// <param name="right">The <see cref="string"/> to compare.</param>
        /// <returns>False if the given JsonData represents the given string, and false otherwise</returns>
        public static bool operator !=(JsonData? left, string? right) => !(left == right);

        /// <summary>
        /// Returns true if a <see cref="JsonData"/> has the same value as a given string,
        /// and false otherwise.
        /// </summary>
        /// <param name="left">The <see cref="string"/> to compare.</param>
        /// <param name="right">The <see cref="JsonData"/> to compare.</param>
        /// <returns>True if the given JsonData represents the given string, and false otherwise.</returns>
        public static bool operator ==(string? left, JsonData? right)
        {
            if (left is null && right is null)
            {
                return true;
            }

            if (left is null || right is null)
            {
                return false;
            }

            return right.Kind == JsonValueKind.String && ((string?)right._value) == left;
        }

        /// <summary>
        /// Returns false if a <see cref="JsonData"/> has the same value as a given string,
        /// and true otherwise.
        /// </summary>
        /// <param name="left">The <see cref="string"/> to compare.</param>
        /// <param name="right">The <see cref="JsonData"/> to compare.</param>
        /// <returns>False if the given JsonData represents the given string, and false otherwise</returns>
        public static bool operator !=(string? left, JsonData? right) => !(left == right);
        #endregion operators

        /// <summary>
        /// Parses text representing a single JSON value into a <see cref="JsonData"/>.
        /// </summary>
        /// <param name="utf8JsonStream">A UTF8 encoded string representing a JSON value.</param>
        /// <returns>A <see cref="JsonData"/> representation of the value</returns>
        public static JsonData FromStream(Stream utf8JsonStream) => new JsonData(JsonDocument.Parse(utf8JsonStream));

        /// <summary>
        /// Parses text representing a single JSON value into a <see cref="JsonData"/>.
        /// </summary>
        /// <param name="utf8JsonStream">A UTF8 encoded string representing a JSON value.</param>
        /// <param name="cancellationToken">A token to monitor for cancelation requests.</param>
        /// <returns>A Task which will construct the <see cref="JsonData"/> representation of the value</returns>
        public static async Task<JsonData> FromStreamAsync(Stream utf8JsonStream, CancellationToken cancellationToken = default) => new JsonData((await JsonDocument.ParseAsync(utf8JsonStream, cancellationToken: cancellationToken).ConfigureAwait(false)).RootElement);

        /// <summary>
        /// The <see cref="JsonValueKind"/> of the value of this instance.
        /// </summary>
        public JsonValueKind Kind
        {
            get => _kind;
        }

        /// <summary>
        /// Returns the number of elements in this array.
        /// </summary>
        /// <remarks>If <see cref="Kind"/> is not <see cref="JsonValueKind.Array"/> this methods throws <see cref="InvalidOperationException"/>.</remarks>
        public int Length
        {
            get => EnsureArray().Count;
        }

        /// <summary>
        /// Returns the names of all the properties of this object.
        /// </summary>
        /// <remarks>If <see cref="Kind"/> is not <see cref="JsonValueKind.Object"/> this methods throws <see cref="InvalidOperationException"/>.</remarks>
        public IEnumerable<string> Properties
        {
            get => EnsureObject().Keys;
        }

        /// <summary>
        /// Returns all the elements in this array.
        /// </summary>
        /// <remarks>If<see cref="Kind"/> is not<see cref="JsonValueKind.Array"/> this methods throws <see cref = "InvalidOperationException" />.</remarks>
        public IEnumerable<JsonData> Items
        {
            get => EnsureArray();
        }

        /// <summary>
        /// Writes the UTF-8 encoded string representation of this instance.
        /// </summary>
        /// <param name="stream">The stream to write to.</param>
        /// <returns>The number of bytes written into the stream.</returns>
        public long WriteTo(Stream stream)
        {
            using Utf8JsonWriter writer = new Utf8JsonWriter(stream);
            WriteTo(writer);
            writer.Flush();
            return writer.BytesCommitted;
        }

        /// <summary>
        /// Writes the UTF-8 encoded string representation of this instance.
        /// </summary>
        /// <param name="stream">The stream to write to.</param>
        /// <param name="cancellationToken">A token to monitor for cancelation requests.</param>
        /// <returns>The number of bytes written into the stream.</returns>
        public async Task<long> WriteToAsync(Stream stream, CancellationToken cancellationToken = default)
        {
            using Utf8JsonWriter writer = new Utf8JsonWriter(stream);
            WriteTo(writer);
            await writer.FlushAsync(cancellationToken).ConfigureAwait(false);
            return writer.BytesCommitted;
        }

        /// <inheritdoc />
        public override string ToString()
        {
            if (_kind == JsonValueKind.Object || _kind == JsonValueKind.Array)
            {
                return ToJsonString();
            }

            // TODO: come back and address CS8603
            return (_value ?? "<null>").ToString()!;
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            if (obj is string)
            {
                return this == ((string?)obj);
            }

            if (obj is JsonData)
            {
                return Equals((JsonData)obj);
            }

            return base.Equals(obj);
        }

        /// <inheritdoc />
        public bool Equals(JsonData? other)
        {
            if (other == null)
            {
                return false;
            }

            if (_kind != other._kind)
            {
                return false;
            }

            switch (_kind)
            {
                case JsonValueKind.Null:
                case JsonValueKind.Undefined:
                    return true;
                case JsonValueKind.Object:
                    return _objectRepresentation!.Equals(other._objectRepresentation);
                case JsonValueKind.Array:
                    return _arrayRepresentation!.Equals(other._arrayRepresentation);
                default:
                    return _value!.Equals(other._value);
            }
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            if (_kind == JsonValueKind.String)
            {
                return ((string?)_value)!.GetHashCode();
            }

            return base.GetHashCode();
        }

        private string? GetString() => (string?)EnsureValue();
        private int GetIn32()
        {
            var value = EnsureNumberValue().AsLong();
            if (value > int.MaxValue || value < int.MinValue)
            {
                throw new OverflowException();
            }
            return (int)value;
        }

        private long GetLong() => EnsureNumberValue().AsLong();
        private float GetFloat()
        {
            var value = EnsureNumberValue().AsDouble();
            if (value > float.MaxValue || value < float.MinValue)
            {
                throw new OverflowException();
            }
            return (float)value;
        }
        private double GetDouble() => EnsureNumberValue().AsDouble();
        private bool GetBoolean() => (bool)EnsureValue()!;

        private void WriteTo(Utf8JsonWriter writer)
        {
            switch (_kind)
            {
                case JsonValueKind.Null:
                case JsonValueKind.String:
                    writer.WriteStringValue((string?)_value);
                    break;
                case JsonValueKind.Number:
                    ((Number)_value!).WriteTo(writer);
                    break;
                case JsonValueKind.True:
                case JsonValueKind.False:
                    writer.WriteBooleanValue((bool)_value!);
                    break;
                case JsonValueKind.Object:
                    writer.WriteStartObject();
                    foreach (var property in EnsureObject())
                    {
                        writer.WritePropertyName(property.Key);
                        property.Value.WriteTo(writer);
                    }
                    writer.WriteEndObject();
                    break;
                case JsonValueKind.Array:
                    writer.WriteStartArray();
                    foreach (var item in EnsureArray())
                    {
                        item.WriteTo(writer);
                    }
                    writer.WriteEndArray();
                    break;
            }
        }

        private Dictionary<string, JsonData> EnsureObject()
        {
            if (_kind != JsonValueKind.Object)
            {
                throw new InvalidOperationException($"Expected kind to be object but was {_kind} instead");
            }

            Debug.Assert(_objectRepresentation != null);
            return _objectRepresentation!;
        }

        private JsonData GetPropertyValue(string propertyName)
        {
            if (EnsureObject().TryGetValue(propertyName, out JsonData? element))
            {
                return element;
            }

            throw new InvalidOperationException($"Property {propertyName} not found");
        }

        /// <summary>
        /// Used by the dynamic meta object to fetch properties. We can't use GetPropertyValue because when the underlying
        /// value is an array, we want `.Length` to mean "the length of the array" and not "treat the array as an object
        /// and get the Length property", and we also want the return type to be "int" and not a JsonData wrapping the int.
        /// </summary>
        /// <param name="propertyName">The name of the property to get the value of.</param>
        /// <returns></returns>
        private object GetDynamicProperty(string propertyName)
        {
            if (_kind == JsonValueKind.Array && propertyName == nameof(Length))
            {
                return Length;
            }

            if (EnsureObject().TryGetValue(propertyName, out JsonData? element))
            {
                return element;
            }

            throw new InvalidOperationException($"Property {propertyName} not found");
        }

        private JsonData SetValue(string propertyName, object value)
        {
            if (!(value is JsonData json))
            {
                json = new JsonData(value);
            }

            EnsureObject()[propertyName] = json;
            return json;
        }

        private List<JsonData> EnsureArray()
        {
            if (_kind != JsonValueKind.Array)
            {
                throw new InvalidOperationException($"Expected kind to be array but was {_kind} instead");
            }

            Debug.Assert(_arrayRepresentation != null);
            return _arrayRepresentation!;
        }

        private JsonData GetValueAt(int index)
        {
            return EnsureArray()[index];
        }

        private object? EnsureValue()
        {
            if (_kind == JsonValueKind.Object || _kind == JsonValueKind.Array)
            {
                throw new InvalidOperationException($"Expected kind to be value but was {_kind} instead");
            }

            return _value;
        }
        private Number EnsureNumberValue()
        {
            if (_kind != JsonValueKind.Number)
            {
                throw new InvalidOperationException($"Expected kind to be number but was {_kind} instead");
            }

            return (Number)EnsureValue()!;
        }

        /// <inheritdoc />
        DynamicMetaObject IDynamicMetaObjectProvider.GetMetaObject(Expression parameter) => new MetaObject(parameter, this);

        private IEnumerable GetDynamicEnumerable()
        {
            if (_kind == JsonValueKind.Array)
            {
                return EnsureArray();
            }

            return EnsureObject();
        }

        private string DebuggerDisplay => ToJsonString();

        private struct Number
        {
            public Number(in JsonElement element)
            {
                _hasDouble = element.TryGetDouble(out _double);
                _hasLong = element.TryGetInt64(out _long);
            }

            public Number(long l)
            {
                _long = l;
                _hasLong = true;
                _double = default;
                _hasDouble = false;
            }

            private long _long;
            private bool _hasLong;
            private double _double;
            private bool _hasDouble;

            public Number(double d)
            {
                _long = default;
                _hasLong = false;
                _double = d;
                _hasDouble = true;
            }

            public void WriteTo(Utf8JsonWriter writer)
            {
                if (_hasDouble)
                {
                    writer.WriteNumberValue(_double);
                }
                else
                {
                    writer.WriteNumberValue(_long);
                }
            }

            public long AsLong()
            {
                if (!_hasLong)
                {
                    throw new FormatException();
                }
                return _long;
            }

            public double AsDouble()
            {
                return _double;
            }
        }

        private class MetaObject : DynamicMetaObject
        {
            // TODO: come back and figure out the right thing to do wrt nullability CS8601
            private static readonly MethodInfo GetDynamicValueMethod = typeof(JsonData).GetMethod(nameof(GetDynamicProperty), BindingFlags.NonPublic | BindingFlags.Instance)!;

            private static readonly MethodInfo GetDynamicEnumerableMethod = typeof(JsonData).GetMethod(nameof(GetDynamicEnumerable), BindingFlags.NonPublic | BindingFlags.Instance)!;

            private static readonly MethodInfo SetValueMethod = typeof(JsonData).GetMethod(nameof(SetValue), BindingFlags.NonPublic | BindingFlags.Instance)!;

            internal MetaObject(Expression parameter, IDynamicMetaObjectProvider value) : base(parameter, BindingRestrictions.Empty, value)
            {
            }

            public override DynamicMetaObject BindGetMember(GetMemberBinder binder)
            {
                var targetObject = Expression.Convert(Expression, LimitType);

                var arguments = new Expression[] { Expression.Constant(binder.Name) };
                var getPropertyCall = Expression.Call(targetObject, GetDynamicValueMethod, arguments);

                var restrictions = BindingRestrictions.GetTypeRestriction(Expression, LimitType);
                return new DynamicMetaObject(getPropertyCall, restrictions);
            }

            public override DynamicMetaObject BindConvert(ConvertBinder binder)
            {
                if (binder.Type == typeof(IEnumerable))
                {
                    var targetObject = Expression.Convert(Expression, LimitType);
                    var getPropertyCall = Expression.Call(targetObject, GetDynamicEnumerableMethod);

                    var restrictions = BindingRestrictions.GetTypeRestriction(Expression, LimitType);
                    return new DynamicMetaObject(getPropertyCall, restrictions);
                }
                return base.BindConvert(binder);
            }

            public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value)
            {
                Expression targetObject = Expression.Convert(Expression, LimitType);
                var arguments = new Expression[2] { Expression.Constant(binder.Name), Expression.Convert(value.Expression, typeof(object)) };

                Expression setPropertyCall = Expression.Call(targetObject, SetValueMethod, arguments);
                BindingRestrictions restrictions = BindingRestrictions.GetTypeRestriction(Expression, LimitType);
                DynamicMetaObject setProperty = new DynamicMetaObject(setPropertyCall, restrictions);
                return setProperty;
            }
        }

        internal class JsonDataDebuggerProxy
        {
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private readonly JsonData _jsonData;

            public JsonDataDebuggerProxy(JsonData jsonData)
            {
                _jsonData = jsonData;
            }

            [DebuggerDisplay("{Value.DebuggerDisplay,nq}", Name = "{Name,nq}")]
            internal class PropertyMember
            {
                [DebuggerBrowsable(DebuggerBrowsableState.Never)]
                public string? Name { get; set; }
                [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
                public JsonData? Value { get; set; }
            }

            [DebuggerDisplay("{Value,nq}")]
            internal class SingleMember
            {
                public object? Value { get; set; }
            }

            [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
            public object Members
            {
                get
                {
                    if (_jsonData.Kind != JsonValueKind.Array &&
                        _jsonData.Kind != JsonValueKind.Object)
                        return new SingleMember() { Value = _jsonData.ToJsonString() };

                    return BuildMembers().ToArray();
                }
            }

            private IEnumerable<object> BuildMembers()
            {
                if (_jsonData.Kind == JsonValueKind.Object)
                {
                    foreach (var property in _jsonData.Properties)
                    {
                        yield return new PropertyMember() { Name = property, Value = _jsonData.Get(property) };
                    }
                }
                else if (_jsonData.Kind == JsonValueKind.Array)
                {
                    foreach (var property in _jsonData.Items)
                    {
                        yield return property;
                    }
                }
            }
        }

        /// <summary>
        /// The default serialization behavior for <see cref="JsonData"/> is not the behavior we want, we want to use
        /// the underlying JSON value that <see cref="JsonData"/> wraps, instead of using the default behavior for
        /// POCOs.
        /// </summary>
        private class JsonConverter : JsonConverter<JsonData>
        {
            public override JsonData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return new JsonData(JsonDocument.ParseValue(ref reader));
            }

            public override void Write(Utf8JsonWriter writer, JsonData value, JsonSerializerOptions options)
            {
                value.WriteTo(writer);
            }
        }
    }
}
