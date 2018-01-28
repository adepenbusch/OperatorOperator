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

        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override bool Equals(Object obj)
        {
            Coordinate coordObj = obj as Coordinate;
            if (coordObj == null)
            {
                return false;
            }
            return (x == coordObj.x && y == coordObj.y);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
