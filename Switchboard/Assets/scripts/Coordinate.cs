using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.scripts
{
    class Coordinate
    {
        public int x;
        public int y;
        public Coordinate()
        {
            var rand = new Random();
            x = rand.Next(0,3);
            y = rand.Next(0,3);
        }
    }
}
