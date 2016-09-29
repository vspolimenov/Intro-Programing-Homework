using RolePlayingGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayingGame
{
    public abstract class WorldObject : IWorldObject
    {
        public int HitPoints
        {
            get;

            set;
        }

        public Point Position
        {
            get;
            set;
        }
        public int Owner { get; set; }
    }
}
