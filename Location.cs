using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Game
{
    internal class Location
    {
        public int distance { get; set; }
        public string name { get; set; }
        public int? timeOfReach { get; set; }

        public Location(int aDistance, string aName)
        {
            distance = aDistance;
            name = aName;
            timeOfReach = null;

        }




    }
}
