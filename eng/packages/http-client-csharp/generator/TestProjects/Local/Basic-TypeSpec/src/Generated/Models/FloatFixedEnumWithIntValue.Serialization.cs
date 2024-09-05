// <auto-generated/>

#nullable disable

using System;

namespace BasicTypeSpec.Models
{
    internal static partial class FloatFixedEnumWithIntValueExtensions
    {
        public static FloatFixedEnumWithIntValue ToFloatFixedEnumWithIntValue(this int value)
        {
            if (value == 1)
            {
                return FloatFixedEnumWithIntValue.One;
            }
            if (value == 2)
            {
                return FloatFixedEnumWithIntValue.Two;
            }
            if (value == 4)
            {
                return FloatFixedEnumWithIntValue.Four;
            }
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown FloatFixedEnumWithIntValue value.");
        }
    }
}
