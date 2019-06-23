using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoxGame
{
    public partial class BoxGame : Form
    {

        bool left, right;
        bool jump;
        int g = 30;
        int Force;


        public BoxGame()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TmrPlayer_Tick(object sender, EventArgs e)
        {
           // 1. side collision of object
           if (Player.Right > Pad.Left && Player.Left < Pad.Right - Player.Width / 2 && Player.Bottom > Pad.Top)
            {
                right = false;
            }

           if (Player.Left < Pad.Right && Player.Right > Pad.Left - Player.Width)
            {
                left = false;
            }

           ////
           //2.
            if (right == true) { Player.Left += 5; }
            if (left == true) { Player.Left -= 5; }

           if (jump == true)
            {
                //falling when player jumps
                Player.Top -= Force;
                Force -= 1;
            }

           if (Player.Top + Player.Height >= Screen.Height)
            {
                Player.Top = Screen.Height - Player.Height; //Stop falling whne a bottom
                jump = false;
            }
           else
            {
                Player.Top += 5; //falling speed
            }

           ////
           //3.
           //Top collision
           if (Player.Left + Player.Width - 5 > Pad.Left && Player.Left + Player.Width + 5 < Pad.Left + Pad.Width + Player.Width && Player.Top + Player.Height >= Pad.Top && Player.Top < Pad.Top)
            {
                Player.Top = Screen.Height - Pad.Height - Player.Height;
                Force = 0;
                jump = false;
            }


        }


        private void BoxGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { right = true; }
            if (e.KeyCode == Keys.Left) { left = true; }
            if (e.KeyCode == Keys.Escape) { this.Close(); } //Escape = Exit

            if (jump != true)
            {
                if (e.KeyCode == Keys.Space)
                {
                    jump = true;
                    Force = g;
                }
            }
        }

        private void BoxGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { right = false; }
            if (e.KeyCode == Keys.Left) { left = false; }
        }
    }
}
