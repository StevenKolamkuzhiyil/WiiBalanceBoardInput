using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiiBalanceBoardInput
{
    class VirtualCoordinates
    {
        private Coordinate center;
        private float xPos_NeutralArea;
        private float xNeg_NeutralArea;
        private float yPos_NeutralArea;
        private float yNeg_NeutralArea;

        public void SetPoint(float x, float y)
        {
            center = new Coordinate(x, y);
        }

        public void SetNeutralArea(Coordinate c)
        {
            xPos_NeutralArea = 9f;                      // Adjust constants if necessary
            xNeg_NeutralArea = -9f;                     // Adjust constants if necessary
            yNeg_NeutralArea = c.Y() - 6.5f;            // Adjust constants if necessary
            yPos_NeutralArea = c.Y() + 2.5f;            // Adjust constants if necessary
        }

        public float XPosNA()
        {
            return xPos_NeutralArea;
        }

        public float XNegNA()
        {
            return xNeg_NeutralArea;
        }

        public float YPosNA()
        {
            return yPos_NeutralArea;
        }

        public float YNegNA()
        {
            return yNeg_NeutralArea;
        }

        public Coordinate GetCenter()
        {
            return center;
        }

    }
}
