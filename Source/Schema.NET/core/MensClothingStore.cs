﻿namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A men's clothing store.
    /// </summary>
    public partial interface IMensClothingStore : IStore
    {
    }

    /// <summary>
    /// A men's clothing store.
    /// </summary>
    [DataContract]
    public partial class MensClothingStore : Store, IMensClothingStore, IEquatable<MensClothingStore>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MensClothingStore";

        /// <inheritdoc/>
        public bool Equals(MensClothingStore other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as MensClothingStore);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
