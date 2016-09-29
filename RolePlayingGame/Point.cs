using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayingGame
{
    public struct Point
    {
        public int x { get; set; }
        public int y { get; set; }
        int[] Parse(string number)
        {

            int[] coordinates = new int[2];
            coordinates[0] = int.Parse(number.Remove(0, 1).Substring(0, number.IndexOf(',')));
            coordinates[1] = int.Parse(number.Remove(number.Length - 1).Substring(number.IndexOf(',')));
            return coordinates;

        }
        public override string ToString()
        {
            return "(" + this.x.ToString() + ", " + this.y.ToString() + ")";
        }


    }
}
