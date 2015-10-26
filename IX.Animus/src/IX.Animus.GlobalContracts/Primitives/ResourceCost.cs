using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace IX.Animus.GlobalContracts.Primitives
{
    /// <summary>
    /// A cost, in a resource.
    /// </summary>
    [DataContract]
    public class ResourceCost
    {
        /// <summary>
        /// How much the cost is.
        /// </summary>
        [DataMember]
        public double Value { get; set; }

        /// <summary>
        /// What resource the cost is in.
        /// </summary>
        [DataMember]
        public Resource Resource { get; set; }
    }
}
