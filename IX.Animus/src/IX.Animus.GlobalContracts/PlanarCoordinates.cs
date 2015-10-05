using System;
using System.Runtime.Serialization;

namespace IX.Animus.GlobalContracts
{
    [DataContract]
    public class PlanarCoordinates : Coordinates
    {
        [DataMember]
        public int X { get; set; }

        [DataMember]
        public int Y { get; set; }

        public override double GetDistance(Coordinates other)
        {
            if (other == null)
                throw new ArgumentNullException(nameof(other));

            PlanarCoordinates otherCoordinates = other as PlanarCoordinates;

            if (otherCoordinates == null)
                throw new ArgumentException(nameof(other));

            int xDistance = otherCoordinates.X - X;
            int yDistance = otherCoordinates.Y - Y;

            return Math.Sqrt(xDistance * xDistance + yDistance * yDistance);
        }
    }
}
