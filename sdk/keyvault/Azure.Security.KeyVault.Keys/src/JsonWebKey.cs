﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.

using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text.Json;

namespace Azure.Security.KeyVault.Keys
{
    /// <summary>
    /// A JSON Web Key (JWK) is a JavaScript Object Notation (JSON) data
    /// structure that represents a cryptographic key.
    /// For more information, see <see href="http://tools.ietf.org/html/draft-ietf-jose-json-web-key-18"/>.
    /// </summary>
    public partial class JsonWebKey : IJsonDeserializable, IJsonSerializable
    {
        /// <summary>
        /// The identifier of the key.
        /// </summary>
        public string KeyId { get; set; }

        /// <summary>
        /// Supported JsonWebKey key types (kty) based on the cryptographic algorithm used for the key.
        /// For valid values, see <see cref="KeyType"/>.
        /// </summary>
        public KeyType KeyType { get; set; }

        /// <summary>
        /// Supported Key Operations
        /// </summary>
        public IList<KeyOperations> KeyOps { get; set; }

        /// <summary>
        /// Creates an instance of <see cref="JsonWebKey"/>
        /// </summary>
        public JsonWebKey()
        {
            KeyOps = new List<KeyOperations>();
        }

        /// <summary>
        /// Creates an instance of <see cref="JsonWebKey"/> using type <see cref="KeyType.Octet"/>.
        /// </summary>
        /// <param name="aesProvider">An <see cref="Aes"/> provider.</param>
        /// <exception cref="ArgumentNullException"><paramref name="aesProvider"/> is null.</exception>
        public JsonWebKey(Aes aesProvider) : this()
        {
            if (aesProvider is null) throw new ArgumentNullException(nameof(aesProvider));

            KeyType = KeyType.Octet;
            K = aesProvider.Key;
        }

        /// <summary>
        /// Creates an instance of <see cref="JsonWebKey"/> using type <see cref="KeyType.Rsa"/>.
        /// </summary>
        /// <param name="rsaProvider">An <see cref="RSA"/> provider.</param>
        /// <param name="includePrivateParameters">Whether to include private parameters.</param>
        /// <exception cref="ArgumentNullException"><paramref name="rsaProvider"/> is null.</exception>
        public JsonWebKey(RSA rsaProvider, bool includePrivateParameters = default)
            : this(rsaProvider?.ExportParameters(includePrivateParameters) ?? throw new ArgumentNullException(nameof(rsaProvider)))
        {
        }

        private JsonWebKey(RSAParameters rsaParameters) : this()
        {
            KeyType = KeyType.Rsa;

            E = rsaParameters.Exponent;
            N = rsaParameters.Modulus;

            D = rsaParameters.D;
            DP = rsaParameters.DP;
            DQ = rsaParameters.DQ;
            P = rsaParameters.P;
            Q = rsaParameters.Q;
            QI = rsaParameters.InverseQ;
        }

        /// <summary>
        /// Gets a value indicating whether this <see cref="JsonWebKey"/> has a private key.
        /// </summary>
        public bool HasPrivateKey
        {
            get
            {
                switch (KeyType)
                {
                    case KeyType.Octet:
                        return K != null;

                    case KeyType.EllipticCurve:
                    case KeyType.EllipticCurveHsm:
                        return D != null;

                    case KeyType.Rsa:
                    case KeyType.RsaHsm:
                        return D != null && DP != null && DQ != null && P != null && Q != null && QI != null;

                    default:
                        return false;
                }
            }
        }

        #region RSA Public Key Parameters

        /// <summary>
        /// RSA modulus, in Base64.
        /// </summary>
        public byte[] N { get; set; }

        /// <summary>
        /// RSA public exponent, in Base64.
        /// </summary>
        public byte[] E { get; set; }

        #endregion

        #region RSA Private Key Parameters

        /// <summary>
        /// RSA Private Key Parameter
        /// </summary>
        public byte[] DP { get; set; }

        /// <summary>
        /// RSA Private Key Parameter
        /// </summary>
        public byte[] DQ { get; set; }

        /// <summary>
        /// RSA Private Key Parameter
        /// </summary>
        public byte[] QI { get; set; }

        /// <summary>
        /// RSA secret prime
        /// </summary>
        public byte[] P { get; set; }

        /// <summary>
        /// RSA secret prime, with p &lt; q
        /// </summary>
        public byte[] Q { get; set; }

        #endregion

        #region EC Public Key Parameters

        /// <summary>
        /// The curve for Elliptic Curve Cryptography (ECC) algorithms
        /// </summary>
        public string CurveName { get; set; }

        /// <summary>
        /// X coordinate for the Elliptic Curve point.
        /// </summary>
        public byte[] X { get; set; }

        /// <summary>
        /// Y coordinate for the Elliptic Curve point.
        /// </summary>
        public byte[] Y { get; set; }

        #endregion

        #region EC and RSA Private Key Parameters

        /// <summary>
        /// RSA private exponent or ECC private key.
        /// </summary>
        public byte[] D { get; set; }

        #endregion

        #region Symmetric Key Parameters

        /// <summary>
        /// Symmetric key
        /// </summary>
        public byte[] K { get; set; }

        #endregion

        /// <summary>
        /// HSM Token, used with "Bring Your Own Key"
        /// </summary>
        public byte[] T { get; set; }

        /// <summary>
        /// Converts this <see cref="JsonWebKey"/> of type <see cref="KeyType.Octet"/> to an <see cref="Aes"/> object.
        /// </summary>
        /// <returns>An <see cref="Aes"/> object.</returns>
        /// <exception cref="InvalidOperationException">This key is not oif type <see cref="KeyType.Octet"/> or <see cref="K"/> is null.</exception>
        public Aes ToAes()
        {
            if (KeyType != KeyType.Octet)
            {
                throw new InvalidOperationException("key is not an octet key");
            }

            if (K is null)
            {
                throw new InvalidOperationException("key does not contain a value");
            }

            Aes key = Aes.Create();
            if (key != null)
            {
                key.Key = K;
            }

            return key;
        }

        private const string KeyIdPropertyName = "kid";
        private const string KeyTypePropertyName = "kty";
        private static readonly JsonEncodedText KeyTypePropertyNameBytes = JsonEncodedText.Encode(KeyTypePropertyName);
        private const string KeyOpsPropertyName = "key_ops";
        private static readonly JsonEncodedText KeyOpsPropertyNameBytes = JsonEncodedText.Encode(KeyOpsPropertyName);
        private const string CurveNamePropertyName = "curveName";
        private static readonly JsonEncodedText CurveNamePropertyNameBytes = JsonEncodedText.Encode(CurveNamePropertyName);
        private const string NPropertyName = "n";
        private static readonly JsonEncodedText NPropertyNameBytes = JsonEncodedText.Encode(NPropertyName);
        private const string EPropertyName = "e";
        private static readonly JsonEncodedText EPropertyNameBytes = JsonEncodedText.Encode(EPropertyName);
        private const string DPPropertyName = "dp";
        private static readonly JsonEncodedText DPPropertyNameBytes = JsonEncodedText.Encode(DPPropertyName);
        private const string DQPropertyName = "dq";
        private static readonly JsonEncodedText DQPropertyNameBytes = JsonEncodedText.Encode(DQPropertyName);
        private const string QIPropertyName = "qi";
        private static readonly JsonEncodedText QIPropertyNameBytes = JsonEncodedText.Encode(QIPropertyName);
        private const string PPropertyName = "p";
        private static readonly JsonEncodedText PPropertyNameBytes = JsonEncodedText.Encode(PPropertyName);
        private const string QPropertyName = "q";
        private static readonly JsonEncodedText QPropertyNameBytes = JsonEncodedText.Encode(QPropertyName);
        private const string XPropertyName = "x";
        private static readonly JsonEncodedText XPropertyNameBytes = JsonEncodedText.Encode(XPropertyName);
        private const string YPropertyName = "y";
        private static readonly JsonEncodedText YPropertyNameBytes = JsonEncodedText.Encode(YPropertyName);
        private const string DPropertyName = "d";
        private static readonly JsonEncodedText DPropertyNameBytes = JsonEncodedText.Encode(DPropertyName);
        private const string KPropertyName = "k";
        private static readonly JsonEncodedText KPropertyNameBytes = JsonEncodedText.Encode(KPropertyName);
        private const string TPropertyName = "t";
        private static readonly JsonEncodedText TPropertyNameBytes = JsonEncodedText.Encode(TPropertyName);

        internal void ReadProperties(JsonElement json)
        {
            foreach (JsonProperty prop in json.EnumerateObject())
            {
                switch (prop.Name)
                {
                    case KeyIdPropertyName:
                        KeyId = prop.Value.GetString();
                        break;
                    case KeyTypePropertyName:
                        KeyType = KeyTypeExtensions.ParseFromString(prop.Value.GetString());
                        break;
                    case KeyOpsPropertyName:
                        foreach (var element in prop.Value.EnumerateArray())
                        {
                            KeyOps.Add(KeyOperationsExtensions.ParseFromString(element.ToString()));
                        }
                        break;
                    case CurveNamePropertyName:
                        CurveName = prop.Value.GetString();
                        break;
                    case NPropertyName:
                        N = Base64Url.Decode(prop.Value.GetString());
                        break;
                    case EPropertyName:
                        E = Base64Url.Decode(prop.Value.GetString());
                        break;
                    case DPPropertyName:
                        DP = Base64Url.Decode(prop.Value.GetString());
                        break;
                    case DQPropertyName:
                        DQ = Base64Url.Decode(prop.Value.GetString());
                        break;
                    case QIPropertyName:
                        QI = Base64Url.Decode(prop.Value.GetString());
                        break;
                    case PPropertyName:
                        P = Base64Url.Decode(prop.Value.GetString());
                        break;
                    case QPropertyName:
                        Q = Base64Url.Decode(prop.Value.GetString());
                        break;
                    case XPropertyName:
                        X = Base64Url.Decode(prop.Value.GetString());
                        break;
                    case YPropertyName:
                        Y = Base64Url.Decode(prop.Value.GetString());
                        break;
                    case DPropertyName:
                        D = Base64Url.Decode(prop.Value.GetString());
                        break;
                    case KPropertyName:
                        K = Base64Url.Decode(prop.Value.GetString());
                        break;
                    case TPropertyName:
                        T = Base64Url.Decode(prop.Value.GetString());
                        break;
                }
            }
        }

        internal void WriteProperties(Utf8JsonWriter json)
        {
            if (KeyType != default)
            {
                json.WriteString(KeyTypePropertyNameBytes, KeyTypeExtensions.AsString(KeyType));
            }
            if (KeyOps != null)
            {
                json.WriteStartArray(KeyOpsPropertyNameBytes);
                foreach (var operation in KeyOps)
                {
                    json.WriteStringValue(KeyOperationsExtensions.AsString(operation));
                }
                json.WriteEndArray();
            }
            if (!string.IsNullOrEmpty(CurveName))
            {
                json.WriteString(CurveNamePropertyNameBytes, CurveName);
            }
            if (N != null)
            {
                json.WriteString(NPropertyNameBytes, Base64Url.Encode(N));
            }
            if (E != null)
            {
                json.WriteString(EPropertyNameBytes, Base64Url.Encode(E));
            }
            if (DP != null)
            {
                json.WriteString(DPPropertyNameBytes, Base64Url.Encode(DP));
            }
            if (DQ != null)
            {
                json.WriteString(DQPropertyNameBytes, Base64Url.Encode(DQ));
            }
            if (QI != null)
            {
                json.WriteString(QIPropertyNameBytes, Base64Url.Encode(QI));
            }
            if (P != null)
            {
                json.WriteString(PPropertyNameBytes, Base64Url.Encode(P));
            }
            if (Q != null)
            {
                json.WriteString(QPropertyNameBytes, Base64Url.Encode(Q));
            }
            if (X != null)
            {
                json.WriteString(XPropertyNameBytes, Base64Url.Encode(X));
            }
            if (Y != null)
            {
                json.WriteString(YPropertyNameBytes, Base64Url.Encode(Y));
            }
            if (D != null)
            {
                json.WriteString(DPropertyNameBytes, Base64Url.Encode(D));
            }
            if (K != null)
            {
                json.WriteString(KPropertyNameBytes, Base64Url.Encode(K));
            }
            if (T != null)
            {
                json.WriteString(TPropertyNameBytes, Base64Url.Encode(T));
            }
        }

        void IJsonDeserializable.ReadProperties(JsonElement json) => ReadProperties(json);

        void IJsonSerializable.WriteProperties(Utf8JsonWriter json) => WriteProperties(json);
    }
}

