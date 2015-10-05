using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace IX.Animus.GlobalContracts
{
    [DataContract]
    public class Sphere
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string NameResourceKey { get; set; }

        [DataMember]
        public string ImageUrl { get; set; }

        [DataMember]
        public string ThumbnailUrl { get; set; }
    }
}
