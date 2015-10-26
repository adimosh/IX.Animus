using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace IX.Animus.GlobalContracts.Primitives
{
    /// <summary>
    /// A defined level for an entity.
    /// </summary>
    [DataContract]
    public class Level
    {
        /// <summary>
        /// The actual level that is defined.
        /// </summary>
        [DataMember]
        public int ActualLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public ResourceCost[] Costs { get; set; }

        /// <summary>
        /// The progression algorithm towards the next defined level, or ad infinitum.
        /// </summary>
        [DataMember]
        public int Progression { get; set; }
    }
}
