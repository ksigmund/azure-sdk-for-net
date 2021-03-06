// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for EntropyMode.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(EntropyModeConverter))]
    public struct EntropyMode : System.IEquatable<EntropyMode>
    {
        private EntropyMode(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        /// <summary>
        /// Context Adaptive Binary Arithmetic Coder (CABAC) entropy encoding.
        /// </summary>
        public static readonly EntropyMode Cabac = "Cabac";

        /// <summary>
        /// Context Adaptive Variable Length Coder (CAVLC) entropy encoding.
        /// </summary>
        public static readonly EntropyMode Cavlc = "Cavlc";


        /// <summary>
        /// Underlying value of enum EntropyMode
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for EntropyMode
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue == null ? null : UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type EntropyMode
        /// </summary>
        public bool Equals(EntropyMode e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to EntropyMode
        /// </summary>
        public static implicit operator EntropyMode(string value)
        {
            return new EntropyMode(value);
        }

        /// <summary>
        /// Implicit operator to convert EntropyMode to string
        /// </summary>
        public static implicit operator string(EntropyMode e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum EntropyMode
        /// </summary>
        public static bool operator == (EntropyMode e1, EntropyMode e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum EntropyMode
        /// </summary>
        public static bool operator != (EntropyMode e1, EntropyMode e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for EntropyMode
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is EntropyMode && Equals((EntropyMode)obj);
        }

        /// <summary>
        /// Returns for hashCode EntropyMode
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
