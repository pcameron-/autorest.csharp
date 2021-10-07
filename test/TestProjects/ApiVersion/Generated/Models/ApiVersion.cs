// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ApiVersion.Models
{
    /// <summary> The ApiVersion. </summary>
    public readonly partial struct ApiVersion : IEquatable<ApiVersion>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ApiVersion"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ApiVersion(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string Two0Value = "2.0";

        /// <summary> 2.0. </summary>
        public static ApiVersion Two0 { get; } = new ApiVersion(Two0Value);
        /// <summary> Determines if two <see cref="ApiVersion"/> values are the same. </summary>
        public static bool operator ==(ApiVersion left, ApiVersion right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ApiVersion"/> values are not the same. </summary>
        public static bool operator !=(ApiVersion left, ApiVersion right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ApiVersion"/>. </summary>
        public static implicit operator ApiVersion(string value) => new ApiVersion(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ApiVersion other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ApiVersion other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}