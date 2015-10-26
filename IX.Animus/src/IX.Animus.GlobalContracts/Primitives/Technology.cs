using IX.Animus.GlobalContracts.HardCodedPrimitives;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace IX.Animus.GlobalContracts.Primitives
{
    [DataContract]
    public class Technology
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
        /// The type of the technology.
        /// </summary>
        [DataMember]
        public TechnologyType Type { get; set; }
    }
}
