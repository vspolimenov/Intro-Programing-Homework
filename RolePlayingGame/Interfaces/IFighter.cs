using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayingGame.Interfaces
{
  public  interface IFighter
    {
         int AtackPoints { get; set; }
         int DefensePoints { get; set; }
        int GetTargetIndex(List<WorldObject> obj);
    }
}
