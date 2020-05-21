using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using InputManager;

namespace WiiBalanceBoardInput
{
    public partial class Form1 : Form
    {
        System.Timers.Timer infoUpdateTimer = new System.Timers.Timer() { Interval = 50, Enabled = false };        

        WiiDevice BalanceBoard = new WiiDevice();
        VirtualCoordinates CoordSystem = new VirtualCoordinates();

        private float x;
        private float y;
        private float xPos;
        private float xNeg;
        private float yPos;
        private float yNeg;
        private float kgTL;
        private float kgTR;
        private float kgBL;
        private float kgBR;
        private string keys;
        private int currentNESW;
        private int previousNESW;
        private bool centerSet;

        // Creates the program window with all its components
        public Form1()
        {
            InitializeComponent();
        }        

        // Method which runs if Button1 is clicked
        private void Button1_Click(object sender, EventArgs e)
        {
            if (TextStatus.Text == "Status: Not connected")
            {
                // Runs the ConnectWiiDevice from the class WiiDevice
                BalanceBoard.ConnectWiiDevice(TextStatus);
                // Sets previousNESW with the current value of NESW
                previousNESW = BalanceBoard.GetNESW();

                // Initializes centerSet with false
                centerSet = false;

                // Sets the center of the neutral area
                while (!centerSet)
                {
                    BalanceBoard.GetValues();

                    x = BalanceBoard.GetCoord().X();
                    y = BalanceBoard.GetCoord().Y();

                    if (!(float.IsNaN(x) && float.IsNaN(y)) && y != 0)
                    {
                        CoordSystem.SetPoint(x, y);
                        CoordSystem.SetNeutralArea(CoordSystem.GetCenter());
                        centerSet = true;
                    }
                }

                // Initializes xPos, xNeg, yPos and yNeg with the border values of the neutral area
                xPos = CoordSystem.XPosNA();
                xNeg = CoordSystem.XNegNA();
                yPos = CoordSystem.YPosNA();
                yNeg = CoordSystem.YNegNA();

                infoUpdateTimer.Enabled = true;

                // Sets the text of Button1
                Button1.Text = "Disconnect Wii Balance Board";
            }
            else
            {
                // Disconnects the Balance Board if it is already connected
                BalanceBoard.GetWiiMote().Disconnect();
                TextStatus.Text = "Status: Not connected";
                Button1.Text = "Connect to Wii Balance Board";
            }
        }

        void InfoUpdateTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            // Pass event onto the form GUI thread.

            this.BeginInvoke(new Action(() => InfoUpdate()));
        }

        // Gets and sets the updated values
        private void InfoUpdate()
        {
            BalanceBoard.GetValues();

            x    = BalanceBoard.GetCoord().X();
            y    = BalanceBoard.GetCoord().Y();
            kgTL = BalanceBoard.GetSensorValuesKg().TopLeft;
            kgTR = BalanceBoard.GetSensorValuesKg().TopRight;
            kgBL = BalanceBoard.GetSensorValuesKg().BottomLeft;
            kgBR = BalanceBoard.GetSensorValuesKg().BottomRight;

            if (!checkBox2.Checked)
            {
                BalanceBoard.ComChangeD_BalanceBoard(x, y, xPos, xNeg, yPos, yNeg);
            }
            else
            {
                BalanceBoard.ComChangeD_BalanceBoard_seated(kgTL, kgTR, kgBL, kgBR);
            }
            currentNESW = BalanceBoard.GetNESW();

            TextX.Text           = String.Format("X: {0}", x);
            TextY.Text           = String.Format("Y: {0}", y);
            TextTopLeft.Text     = String.Format("{0}", kgTL);
            TextTopRight.Text    = String.Format("{0}", kgTR);
            TextCenter.Text      = String.Format("{0}", (kgTL + kgTR + kgBL + kgBR) / 4);
            TextBottomLeft.Text  = String.Format("{0}", kgBL);
            TextBottomRight.Text = String.Format("{0}", kgBR);
            TextDirection.Text   = String.Format("{0}", BalanceBoard.GetPosition());
            TextNESW.Text        = String.Format("{0}", currentNESW);

            if (GetActiveWindowTitle() == TextProgramName.Text && previousNESW != currentNESW)
            {
                switch (currentNESW)
                {
                    case 0:
                        Keyboard.KeyDown(Keys.W);
                        Keyboard.KeyUp(Keys.W);
                        keys = "W";
                        break;
                    case 1:
                        Keyboard.KeyDown(Keys.D);
                        Keyboard.KeyUp(Keys.D);
                        keys = "D";
                        break;
                    case 2:
                        Keyboard.KeyDown(Keys.S);
                        Keyboard.KeyUp(Keys.S);
                        keys = "S";
                        break;
                    case 3:
                        Keyboard.KeyDown(Keys.A);
                        Keyboard.KeyUp(Keys.A);
                        keys = "A";
                        break;
                }
                previousNESW = currentNESW;
            }
            else if (GetActiveWindowTitle() != TextProgramName.Text)
            {
                keys = "None";
            }
            switch (keys)
            {
                case "W": case "D": case "S": case "A": 
                    TextKeyDown.Text = String.Format("{0}", keys);
                    break;
                default:
                    TextKeyDown.Text = String.Format("{0}", "None");
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            infoUpdateTimer.Elapsed += new ElapsedEventHandler(InfoUpdateTimer_Elapsed);
        }

        private void Form1_Closing(object sender, EventArgs e)
        {
            // Disconnects the Balance Board if it is still connected while the window is closing
            if (TextStatus.Text == "Status: Connected")
            {
                Button1.PerformClick();
            }
        }

        public WiiDevice GetWiiDevice()
        {
            return BalanceBoard;
        }

        // Impots the library user32 and gets the methods GetForegroundWindow and GetWindowText
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        // Gets the title of the focused window
        private string GetActiveWindowTitle()
        {
            // sets the max. limit of chars the title can have
            const int nChars = 256;
            // creates a StringBuilder object with a max. char number of nChars
            StringBuilder Buff = new StringBuilder(nChars);
            // initializes handle with the current foreground window
            IntPtr handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                // creates a string with the window title
                return Buff.ToString();
            }
            return null;
        }

    }
}
