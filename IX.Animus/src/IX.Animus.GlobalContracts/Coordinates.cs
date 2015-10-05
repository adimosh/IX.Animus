using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace IX.Animus.GlobalContracts
{
    [DataContract]
    public abstract class Coordinates : IComparable<Coordinates>, IEquatable<Coordinates>
    {
        public int CompareTo(Coordinates other)
        {
            double distance = GetDistance(other);

            if (distance > 0 && distance < 1)
                return 1;
            if (distance < 0 && distance > -1)
                return -1;

            return (int)distance;
        }

        public bool Equals(Coordinates other)
        {
            return CompareTo(other) == 0;
        }

        public abstract double GetDistance(Coordinates other);
    }
}
