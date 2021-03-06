﻿using IX.Animus.GlobalContracts.HardCodedPrimitives;
using System.Runtime.Serialization;

namespace IX.Animus.GlobalContracts.Primitives
{
    /// <summary>
    /// A non-resource-based characteristic that can be applied to entities.
    /// </summary>
    [DataContract]
    public class UnitCharacteristic
    {
        /// <summary>
        /// The Id.
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// The resource key of this entity's name.
        /// </summary>
        [DataMember]
        public string NameResourceKey { get; set; }

        /// <summary>
        /// The big image URL for this entity.
        /// </summary>
        [DataMember]
        public string ImageUrl { get; set; }

        /// <summary>
        /// An URL for the thumbnail of this entity.
        /// </summary>
        [DataMember]
        public string ThumbnailUrl { get; set; }

        /// <summary>
        /// The type of the characteristic.
        /// </summary>
        [DataMember]
        public CharacteristicType Type { get; set; }

        /// <summary>
        /// <c>true</c> if the unit should die if this characteristic reaches zero.
        /// </summary>
        [DataMember]
        public bool UnitDiesIfZero { get; set; }
    }
}
