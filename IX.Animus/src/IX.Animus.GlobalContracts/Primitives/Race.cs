﻿using System.Collections.Generic;
using System.Runtime.Serialization;

namespace IX.Animus.GlobalContracts.Primitives
{
    /// <summary>
    /// A race.
    /// </summary>
    [DataContract]
    public class Race
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
        /// The resources that are associated with this race.
        /// </summary>
        [DataMember]
        public IList<Resource> Resources { get; set; }
    }
}
