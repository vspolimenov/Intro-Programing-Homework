﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayingGame.Interfaces
{
   public interface IWorldObject
    {
          int HitPoints { get; set; }
         Point Position { get; set; }

    }
}
