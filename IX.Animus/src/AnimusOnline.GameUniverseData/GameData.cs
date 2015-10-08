using IX.Animus.GlobalContracts.Containers;
using IX.Animus.GlobalContracts.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimusOnline.GameUniverseData
{
    /// <summary>
    /// The game data.
    /// </summary>
    public static class GameData
    {
        /// <summary>
        /// The game data constructor.
        /// </summary>
        static GameData()
        {
            Container = new GlobalObjectsContainer();

            // Alignments
            Container.Alignments = new Dictionary<int, Alignment>();
            Container.Alignments.Add(1, new Alignment
            {
                Id = 1,
                ImageUrl = "???",
                NameResourceKey = "Alignment_Good",
                ThumbnailUrl = "???"
            });
            Container.Alignments.Add(2, new Alignment
            {
                Id = 2,
                ImageUrl = "???",
                NameResourceKey = "Alignment_Neutral",
                ThumbnailUrl = "???"
            });
            Container.Alignments.Add(3, new Alignment
            {
                Id = 3,
                ImageUrl = "???",
                NameResourceKey = "Alignment_Bad",
                ThumbnailUrl = "???"
            });

            // Spheres
            Container.Spheres = new Dictionary<int, Sphere>();
            Container.Spheres.Add(1, new Sphere
            {
                Id = 1,
                ImageUrl = "???",
                NameResourceKey = "Sphere_Earth",
                ThumbnailUrl = "???"
            });
            Container.Spheres.Add(2, new Sphere
            {
                Id = 2,
                ImageUrl = "???",
                NameResourceKey = "Sphere_Air",
                ThumbnailUrl = "???"
            });
            Container.Spheres.Add(3, new Sphere
            {
                Id = 3,
                ImageUrl = "???",
                NameResourceKey = "Sphere_Water",
                ThumbnailUrl = "???"
            });
            Container.Spheres.Add(4, new Sphere
            {
                Id = 4,
                ImageUrl = "???",
                NameResourceKey = "Sphere_Fire",
                ThumbnailUrl = "???"
            });
            Container.Spheres.Add(5, new Sphere
            {
                Id = 5,
                ImageUrl = "???",
                NameResourceKey = "Sphere_Chaos",
                ThumbnailUrl = "???"
            });
            Container.Spheres.Add(6, new Sphere
            {
                Id = 6,
                ImageUrl = "???",
                NameResourceKey = "Sphere_Order",
                ThumbnailUrl = "???"
            });
            Container.Spheres.Add(7, new Sphere
            {
                Id = 7,
                ImageUrl = "???",
                NameResourceKey = "Sphere_Life",
                ThumbnailUrl = "???"
            });
            Container.Spheres.Add(8, new Sphere
            {
                Id = 8,
                ImageUrl = "???",
                NameResourceKey = "Sphere_Death",
                ThumbnailUrl = "???"
            });
        }
            
        public static GlobalObjectsContainer Container { get; private set; }
    }
}
