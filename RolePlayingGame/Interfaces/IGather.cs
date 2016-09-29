using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayingGame.Interfaces
{
  public  interface IGather
    {
        bool TryGather(IResource res);
    }
}
