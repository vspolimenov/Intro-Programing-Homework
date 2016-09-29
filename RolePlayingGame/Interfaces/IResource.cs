using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayingGame.Interfaces
{
  public  interface IResource
    {
         int Quantity { get; set; }
         int Type { get; set; }
    }
}
