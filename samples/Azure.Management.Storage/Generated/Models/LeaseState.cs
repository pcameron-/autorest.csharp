// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Management.Storage.Models
{
    /// <summary> Lease state of the container. </summary>
    public readonly partial struct LeaseState : IEquatable<LeaseState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LeaseState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LeaseState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AvailableValue = "Available";
        private const string LeasedValue = "Leased";
        private const string ExpiredValue = "Expired";
        private const string BreakingValue = "Breaking";
        private const string BrokenValue = "Broken";

        /// <summary> Available. </summary>
        public static LeaseState Available { get; } = new LeaseState(AvailableValue);
        /// <summary> Leased. </summary>
        public static LeaseState Leased { get; } = new LeaseState(LeasedValue);
        /// <summary> Expired. </summary>
        public static LeaseState Expired { get; } = new LeaseState(ExpiredValue);
        /// <summary> Breaking. </summary>
        public static LeaseState Breaking { get; } = new LeaseState(BreakingValue);
        /// <summary> Broken. </summary>
        public static LeaseState Broken { get; } = new LeaseState(BrokenValue);
        /// <summary> Determines if two <see cref="LeaseState"/> values are the same. </summary>
        public static bool operator ==(LeaseState left, LeaseState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LeaseState"/> values are not the same. </summary>
        public static bool operator !=(LeaseState left, LeaseState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LeaseState"/>. </summary>
        public static implicit operator LeaseState(string value) => new LeaseState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LeaseState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LeaseState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
