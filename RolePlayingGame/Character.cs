using RolePlayingGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayingGame
{
    public abstract class Character : IControllable
    {
        public string Name
        {
            get;

            set;
        }
    }
}
