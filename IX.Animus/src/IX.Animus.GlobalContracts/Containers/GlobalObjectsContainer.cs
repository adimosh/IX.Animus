using IX.Animus.GlobalContracts.Primitives;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace IX.Animus.GlobalContracts.Containers
{
    /// <summary>
    /// A container for top-level, global objects that usually defines the mechanics of the game itself.
    /// </summary>
    [DataContract]
    public class GlobalObjectsContainer
    {
        /// <summary>
        /// The spheres, by Id.
        /// </summary>
        [DataMember]
        public Dictionary<int, Sphere> Spheres { get; set; }

        /// <summary>
        /// The races, by Id.
        /// </summary>
        [DataMember]
        public Dictionary<int, Race> Races { get; set; }

        /// <summary>
        /// The alignments, by Id.
        /// </summary>
        [DataMember]
        public Dictionary<int, Alignment> Alignments { get; set; }

        /// <summary>
        /// The resources, by Id.
        /// </summary>
        [DataMember]
        public Dictionary<int, Resource> Resources { get; set; }

        /// <summary>
        /// The resources, by Id.
        /// </summary>
        [DataMember]
        public Dictionary<int, UnitCharacteristic> Characteristics { get; set; }
    }
}
