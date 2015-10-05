using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace IX.Animus.GlobalContracts
{
    [DataContract]
    public class Province
    {
        [DataMember]
        Coordinates Coordinates { get; set; }
    }
}
