using IX.Animus.Math;
using System.Runtime.Serialization;

namespace IX.Animus.GlobalContracts
{
    [DataContract]
    public class Province
    {
        [DataMember]
        Coordinates Coordinates { get; set; }
    }
}
