using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace IX.Animus.GlobalContracts.HardCodedPrimitives
{
    /// <summary>
    /// The type of technologies available.
    /// </summary>
    [Flags]
    [DataContract]
    public enum TechnologyType
    {
        Generic = 0,
        Economy = 1,
        Structural = 2,
        Military = 4,
        Espionage = 8,

    }
}
