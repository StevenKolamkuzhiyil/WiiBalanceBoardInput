using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiimoteLib;
using System.Windows.Forms;

namespace WiiBalanceBoardInput
{
    public class WiiDevice
    {
        private Wiimote bb;
        private WiimoteState s;
        private BalanceBoardState bbs;
        private BalanceBoardSensorsF bbKg;
        private Coordinate coord;

        private int NESW = 2;
        private string currentPosition = "down";

        // Methode which connects the Wiimote
        public void ConnectWiiDevice(Label label)
        {
            try
            {
                // Creating a new Wiimote object
                bb = new Wiimote();

                // Initializing the Wiimote object with a Wiimote
                bb.Connect();
                // Turning on the first Wiimote LED
                bb.SetLEDs(1);
                // Changing the text of label to "Status Connected"
                label.Text = "Status: Connected";
            }
            catch
            {
                label.Text = "Status: Not Connected";
            }
        }

        public void GetValues()
        {
            // Initializing s with the current Wiimote state
            s = bb.WiimoteState;
            // Initailizing bbs with the current Balance Board state
            bbs = s.BalanceBoardState;
            // Initializing bbKg with the current weight distribution
            bbKg = bbs.SensorValuesKg;

            // Creating a new Coordinate Object and initializing it through a constructor
            coord = new Coordinate(bbs.CenterOfGravity.X, bbs.CenterOfGravity.Y);
        }
        
        public BalanceBoardSensorsF GetSensorValuesKg()
        {
            return bbKg;
        }

        public Coordinate GetCoord()
        {
            return coord;
        }

        public Wiimote GetWiiMote()
        {
            return bb;
        }

        // Methode which sets NESW and currentPosition while standing on the Balance Board
        public void ComChangeD_BalanceBoard(float x, float y, float xPosNA, float xNegNA, float yPosNA, float yNegNA)
        {
            if (xNegNA <= x && x <= xPosNA && yNegNA <= y && y <= yPosNA)
            {
                currentPosition = "neutral";
            }
            if (y < yNegNA && xNegNA <= x && x <= xPosNA)
            {
                NESW = 0;
                currentPosition = "up";
            }
            else if (x > xPosNA)
            {
                NESW = 1;
                currentPosition = "right";
            }
            else if (yPosNA < y && Math.Abs(x) <= y)
            {
                NESW = 2;
                currentPosition = "down";
            }
            else if (x < xNegNA) 
            {
                NESW = 3;
                currentPosition = "left";
            }
        }

        // Methode which sets NESW and currentPosition while sitting and putting the feet on the Balance Board
        public void ComChangeD_BalanceBoard_seated (float kgTL, float kgTR, float kgBL, float kgBR)
        {
            if ((kgTL >= 0 && kgBL >= 0 && (kgTR >= 0 || kgBR >= 0)) || (kgTR >= 0 && kgBR >= 0 && (kgTL >= 0 || kgBL >= 0)))
            {
                currentPosition = "neutral";
            }
            else if (kgBL < 0 && kgBR < 0)
            {
                NESW = 0;
                currentPosition = "up";
            }
            else if (kgTL < 0 && kgBL < 0)
            {
                NESW = 1;
                currentPosition = "right";
            }
            else if (kgTL < 0 && kgTR < 0)
            {
                NESW = 2;
                currentPosition = "down";
            }
            else if (kgTR < 0 && kgBR < 0)
            {
                NESW = 3;
                currentPosition = "left";
            }
        }

        public int GetNESW()
        {
            return NESW;
        }

        public string GetPosition()
        {
            return currentPosition;
        }
    }
}
