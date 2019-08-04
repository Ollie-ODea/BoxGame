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

        bool spawncoin;
        Random rand = new Random();
        Random Spawn = new Random();
        int Score = 0;


        Random hit = new Random();

        //speeds
        int EnemySpdud = 1;
        int EnemySpdlr = 1;

        int PlayerSpd = 8;
        int FallSpd = 1;
        

        public BoxGame()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TmrPlayer_Tick(object sender, EventArgs e)
        {
            // 1. side collision of pad
            if (Player.Right > Pad.Left && Player.Left < Pad.Right - Player.Width && Player.Bottom < Pad.Bottom && Player.Bottom > Pad.Top)
            {
                right = false;
            }

            if (Player.Left < Pad.Right && Player.Right > Pad.Left - Player.Width && Player.Bottom < Pad.Bottom && Player.Bottom > Pad.Top)
            {
                left = false;
            }


            // side collision of pad1
            if (Player.Right > Pad1.Left && Player.Left < Pad1.Right - Player.Width && Player.Bottom < Pad1.Bottom && Player.Bottom > Pad1.Top)
            {
                right = false;
            }

            if (Player.Left < Pad1.Right && Player.Right > Pad1.Left - Player.Width && Player.Bottom < Pad1.Bottom && Player.Bottom > Pad1.Top)
            {
                left = false;
            }


            // side collision of pad2
            if (Player.Right > Pad2.Left && Player.Left < Pad2.Right - Player.Width && Player.Bottom < Pad2.Bottom && Player.Bottom > Pad2.Top)
            {
                right = false;
            }

            if (Player.Left < Pad2.Right && Player.Right > Pad2.Left - Player.Width && Player.Bottom < Pad2.Bottom && Player.Bottom > Pad2.Top)
            {
                left = false;
            }

            // side collision of pad3
            if (Player.Right > Pad3.Left && Player.Left < Pad3.Right - Player.Width && Player.Bottom < Pad3.Bottom && Player.Bottom > Pad3.Top)
            {
                right = false;
            }

            if (Player.Left < Pad3.Right && Player.Right > Pad3.Left - Player.Width && Player.Bottom < Pad3.Bottom && Player.Bottom > Pad3.Top)
            {
                left = false;
            }

            // side collision of pad4
            if (Player.Right > Pad4.Left && Player.Left < Pad4.Right - Player.Width && Player.Bottom < Pad4.Bottom && Player.Bottom > Pad4.Top)
            {
                right = false;
            }

            if (Player.Left < Pad4.Right && Player.Right > Pad4.Left - Player.Width && Player.Bottom < Pad4.Bottom && Player.Bottom > Pad4.Top)
            {
                left = false;
            }

            // side collision of pad5
            if (Player.Right > Pad5.Left && Player.Left < Pad5.Right - Player.Width && Player.Bottom < Pad5.Bottom && Player.Bottom > Pad5.Top)
            {
                right = false;
            }

            if (Player.Left < Pad5.Right && Player.Right > Pad5.Left - Player.Width && Player.Bottom < Pad5.Bottom && Player.Bottom > Pad5.Top)
            {
                left = false;
            }

            // side collision of pad6
            if (Player.Right > Pad6.Left && Player.Left < Pad6.Right - Player.Width && Player.Bottom < Pad6.Bottom && Player.Bottom > Pad6.Top)
            {
                right = false;
            }

            if (Player.Left < Pad6.Right && Player.Right > Pad6.Left - Player.Width && Player.Bottom < Pad6.Bottom && Player.Bottom > Pad6.Top)
            {
                left = false;
            }








            //Falling/movement on pads
            if (right == true) { Player.Left += PlayerSpd; }
            if (left == true) { Player.Left -= PlayerSpd; }

            if (jump == true)
            {
                //falling when player jumps
                Player.Top -= Force;
                Force -= FallSpd;
            }


            if (Player.Top + Player.Height >= Screen.Height)
            {
                Player.Top = Screen.Height - Player.Height; //Stop falling when at bottom
                jump = false;


            }
            else
            {
                Player.Top += 10; //falling speed
            }








            //top and bottom collision of Pad
            if (Player.Left + Player.Width > Pad.Left && Player.Left + Player.Width < Pad.Left + Pad.Width + Player.Width && Player.Top + Player.Height >= Pad.Top && Player.Top < Pad.Top)
            {
                Player.Top = Pad.Location.Y - Player.Height;
                Force = 0;
                jump = false;

            }
            //head collision
            if (Player.Left + Player.Width > Pad.Left && Player.Left + Player.Width < Pad.Left + Pad.Width + Player.Width && Player.Top - Pad.Bottom <= 10 && Player.Top - Pad.Top > -10)
            {
                Force = -1;
            }


            // top collision of pad1
            if (Player.Left + Player.Width > Pad1.Left && Player.Left + Player.Width < Pad1.Left + Pad1.Width + Player.Width && Player.Top + Player.Height >= Pad1.Top && Player.Top < Pad1.Top)
            {
                Player.Top = Pad1.Location.Y - Player.Height;
                Force = 0;
                jump = false;

            }
            //head collision
            if (Player.Left + Player.Width > Pad1.Left && Player.Left + Player.Width < Pad1.Left + Pad1.Width + Player.Width && Player.Top - Pad1.Bottom <= 10 && Player.Top - Pad1.Top > -10)
            {
                Force = -1;
            }

            // top collision of pad2
            if (Player.Left + Player.Width > Pad2.Left && Player.Left + Player.Width < Pad2.Left + Pad2.Width + Player.Width && Player.Top + Player.Height >= Pad2.Top && Player.Top < Pad2.Top)
            {
                Player.Top = Pad2.Location.Y - Player.Height;
                Force = 0;
                jump = false;

            }
            //head collision
            if (Player.Left + Player.Width > Pad2.Left && Player.Left + Player.Width < Pad2.Left + Pad2.Width + Player.Width && Player.Top - Pad2.Bottom <= 10 && Player.Top - Pad2.Top > -10)
            {
                Force = -1;
            }

            // top collision of pad3
            if (Player.Left + Player.Width > Pad3.Left && Player.Left + Player.Width < Pad3.Left + Pad3.Width + Player.Width && Player.Top + Player.Height >= Pad3.Top && Player.Top < Pad3.Top)
            {
                Player.Top = Pad3.Location.Y - Player.Height;
                Force = 0;
                jump = false;

            }
            //head collision
            if (Player.Left + Player.Width > Pad3.Left && Player.Left + Player.Width < Pad3.Left + Pad3.Width + Player.Width && Player.Top - Pad3.Bottom <= 10 && Player.Top - Pad3.Top > -10)
            {
                Force = -1;
            }

            // top collision of pad4
            if (Player.Left + Player.Width > Pad4.Left && Player.Left + Player.Width < Pad4.Left + Pad4.Width + Player.Width && Player.Top + Player.Height >= Pad4.Top && Player.Top < Pad4.Top)
            {
                Player.Top = Pad4
                    .Location.Y - Player.Height;
                Force = 0;
                jump = false;

            }
            //head collision
            if (Player.Left + Player.Width > Pad4.Left && Player.Left + Player.Width < Pad4.Left + Pad4.Width + Player.Width && Player.Top - Pad4.Bottom <= 10 && Player.Top - Pad4.Top > -10)
            {
                Force = -1;
            }

            // top collision of pad5
            if (Player.Left + Player.Width > Pad5.Left && Player.Left + Player.Width < Pad5.Left + Pad5.Width + Player.Width && Player.Top + Player.Height >= Pad5.Top && Player.Top < Pad5.Top)
            {
                Player.Top = Pad5
                    .Location.Y - Player.Height;
                Force = 0;
                jump = false;

            }
            //head collision
            if (Player.Left + Player.Width > Pad5.Left && Player.Left + Player.Width < Pad5.Left + Pad5.Width + Player.Width && Player.Top - Pad5.Bottom <= 10 && Player.Top - Pad5.Top > -10)
            {
                Force = -1;
            }

            // top collision of pad6
            if (Player.Left + Player.Width > Pad6.Left && Player.Left + Player.Width < Pad6.Left + Pad6.Width + Player.Width && Player.Top + Player.Height >= Pad6.Top && Player.Top < Pad6.Top)
            {
                Player.Top = Pad6
                    .Location.Y - Player.Height;
                Force = 0;
                jump = false;

            }
            //head collision
            if (Player.Left + Player.Width > Pad6.Left && Player.Left + Player.Width < Pad6.Left + Pad6.Width + Player.Width && Player.Top - Pad6.Bottom <= 10 && Player.Top - Pad6.Top > -10)
            {
                Force = -1;
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

        private void TrmEnemy_Tick(object sender, EventArgs e)
        {
            if (Enemy.Left + Enemy.Width > Player.Left)
            {
                Enemy.Left -= EnemySpdlr;
            }
            if (Enemy.Left + Enemy.Width < Player.Left)
            {
                Enemy.Left += EnemySpdlr;
            }
            if (Enemy.Top + Enemy.Height > Player.Top)
            {
                Enemy.Top -= EnemySpdud;
            }
            if (Enemy.Top + Enemy.Height < Player.Top)
            {
                Enemy.Top += EnemySpdud;
            }
             if (Enemy.Bounds.IntersectsWith(Player.Bounds))
            {
                Player.Top = hit.Next(10, 951);
                Player.Left = hit.Next(10, 1114);
            }



        }

        private void Screen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TrmCoin_Tick(object sender, EventArgs e)
        {
            //Coin Collect
            if (Player.Bounds.IntersectsWith(Coin1.Bounds))
            {
                spawncoin = true;

            }

            if (spawncoin == true)
            {
                Score += 1;
                LblScore.Text = Score.ToString();
            }


            if (spawncoin == true)
            {
                if (Spawn.Next(1, 7) == 1)
                {
                    Coin1.Left = 535;
                    Coin1.Top = 73;
                    spawncoin = false;
                }
                if (Spawn.Next(1, 7) == 2)
                {
                    Coin1.Left = 908;
                    Coin1.Top = 254;
                    spawncoin = false;
                }
                if (Spawn.Next(1, 7) == 3)
                {
                    Coin1.Left = 195;
                    Coin1.Top = 254;
                    spawncoin = false;
                }
                if (Spawn.Next(1, 7) == 4)
                {
                    Coin1.Left = 535;
                    Coin1.Top = 423;
                    spawncoin = false;
                }
                if (Spawn.Next(1, 7) == 5)
                {
                    Coin1.Left = 195;
                    Coin1.Top = 582;
                    spawncoin = false;
                }
                if (Spawn.Next(1, 7) == 6)
                {
                    Coin1.Left = 908;
                    Coin1.Top = 582;
                    spawncoin = false;
                }
                if (Spawn.Next(1, 7) == 7)
                {
                    Coin1.Left = 535;
                    Coin1.Top = 797;
                    spawncoin = false;
                }

            }
        }

        private void Coin1_Click(object sender, EventArgs e)
        {

        }

        private void TrmEnemySpd_Tick(object sender, EventArgs e)
        {
            if (Score == 10)
            {
                EnemySpdud = 7;
                EnemySpdlr = 7;
            }
        }

        private void TrmCollect_Tick(object sender, EventArgs e)
        {
                
        }

        private void BoxGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { right = false; }
            if (e.KeyCode == Keys.Left) { left = false; }
        }
    }
}
