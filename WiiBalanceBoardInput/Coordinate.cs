using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiiBalanceBoardInput
{
    public class Coordinate
    {
        private float x;
        private float y;

        public Coordinate(float IN, bool axis)
        {
            if (axis)
            {
                x = IN;
            }
            else
            {
                y = IN;
            }
        }

        public Coordinate(float INx, float INy)
        {
            x = INx;
            y = INy;
        }

        public float X()
        {
            return x;
        }

        public float Y()
        {
            return y;
        }
    }
}
