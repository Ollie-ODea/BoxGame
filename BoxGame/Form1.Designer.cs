namespace BoxGame
{
    partial class BoxGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Screen = new System.Windows.Forms.Panel();
            this.Pad6 = new System.Windows.Forms.PictureBox();
            this.Pad5 = new System.Windows.Forms.PictureBox();
            this.Pad4 = new System.Windows.Forms.PictureBox();
            this.Coin1 = new System.Windows.Forms.PictureBox();
            this.Pad3 = new System.Windows.Forms.PictureBox();
            this.Pad2 = new System.Windows.Forms.PictureBox();
            this.Pad1 = new System.Windows.Forms.PictureBox();
            this.Enemy = new System.Windows.Forms.PictureBox();
            this.Pad = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.TmrPlayer = new System.Windows.Forms.Timer(this.components);
            this.TrmEnemy = new System.Windows.Forms.Timer(this.components);
            this.TrmCoin = new System.Windows.Forms.Timer(this.components);
            this.TrmEnemySpd = new System.Windows.Forms.Timer(this.components);
            this.LblScore = new System.Windows.Forms.Label();
            this.TrmCollect = new System.Windows.Forms.Timer(this.components);
            this.Screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pad6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pad5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pad4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pad3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pad2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // Screen
            // 
            this.Screen.BackColor = System.Drawing.SystemColors.Desktop;
            this.Screen.Controls.Add(this.LblScore);
            this.Screen.Controls.Add(this.Pad6);
            this.Screen.Controls.Add(this.Pad5);
            this.Screen.Controls.Add(this.Pad4);
            this.Screen.Controls.Add(this.Coin1);
            this.Screen.Controls.Add(this.Pad3);
            this.Screen.Controls.Add(this.Pad2);
            this.Screen.Controls.Add(this.Pad1);
            this.Screen.Controls.Add(this.Enemy);
            this.Screen.Controls.Add(this.Pad);
            this.Screen.Controls.Add(this.Player);
            this.Screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Screen.Location = new System.Drawing.Point(0, 0);
            this.Screen.Name = "Screen";
            this.Screen.Size = new System.Drawing.Size(1124, 961);
            this.Screen.TabIndex = 0;
            this.Screen.Paint += new System.Windows.Forms.PaintEventHandler(this.Screen_Paint);
            // 
            // Pad6
            // 
            this.Pad6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Pad6.Location = new System.Drawing.Point(385, 844);
            this.Pad6.Name = "Pad6";
            this.Pad6.Size = new System.Drawing.Size(346, 48);
            this.Pad6.TabIndex = 9;
            this.Pad6.TabStop = false;
            // 
            // Pad5
            // 
            this.Pad5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Pad5.Location = new System.Drawing.Point(42, 638);
            this.Pad5.Name = "Pad5";
            this.Pad5.Size = new System.Drawing.Size(318, 48);
            this.Pad5.TabIndex = 8;
            this.Pad5.TabStop = false;
            // 
            // Pad4
            // 
            this.Pad4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Pad4.Location = new System.Drawing.Point(751, 638);
            this.Pad4.Name = "Pad4";
            this.Pad4.Size = new System.Drawing.Size(331, 48);
            this.Pad4.TabIndex = 7;
            this.Pad4.TabStop = false;
            // 
            // Coin1
            // 
            this.Coin1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Coin1.Location = new System.Drawing.Point(540, 415);
            this.Coin1.Name = "Coin1";
            this.Coin1.Size = new System.Drawing.Size(17, 29);
            this.Coin1.TabIndex = 6;
            this.Coin1.TabStop = false;
            this.Coin1.Click += new System.EventHandler(this.Coin1_Click);
            // 
            // Pad3
            // 
            this.Pad3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Pad3.Location = new System.Drawing.Point(385, 128);
            this.Pad3.Name = "Pad3";
            this.Pad3.Size = new System.Drawing.Size(346, 48);
            this.Pad3.TabIndex = 5;
            this.Pad3.TabStop = false;
            // 
            // Pad2
            // 
            this.Pad2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Pad2.Location = new System.Drawing.Point(42, 299);
            this.Pad2.Name = "Pad2";
            this.Pad2.Size = new System.Drawing.Size(331, 48);
            this.Pad2.TabIndex = 4;
            this.Pad2.TabStop = false;
            // 
            // Pad1
            // 
            this.Pad1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Pad1.Location = new System.Drawing.Point(751, 299);
            this.Pad1.Name = "Pad1";
            this.Pad1.Size = new System.Drawing.Size(331, 48);
            this.Pad1.TabIndex = 3;
            this.Pad1.TabStop = false;
            // 
            // Enemy
            // 
            this.Enemy.BackColor = System.Drawing.Color.Red;
            this.Enemy.Location = new System.Drawing.Point(33, 49);
            this.Enemy.Name = "Enemy";
            this.Enemy.Size = new System.Drawing.Size(25, 25);
            this.Enemy.TabIndex = 2;
            this.Enemy.TabStop = false;
            // 
            // Pad
            // 
            this.Pad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Pad.Location = new System.Drawing.Point(385, 468);
            this.Pad.Name = "Pad";
            this.Pad.Size = new System.Drawing.Size(346, 48);
            this.Pad.TabIndex = 1;
            this.Pad.TabStop = false;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Aqua;
            this.Player.Location = new System.Drawing.Point(475, 341);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(30, 30);
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // TmrPlayer
            // 
            this.TmrPlayer.Enabled = true;
            this.TmrPlayer.Interval = 1;
            this.TmrPlayer.Tick += new System.EventHandler(this.TmrPlayer_Tick);
            // 
            // TrmEnemy
            // 
            this.TrmEnemy.Enabled = true;
            this.TrmEnemy.Interval = 10;
            this.TrmEnemy.Tick += new System.EventHandler(this.TrmEnemy_Tick);
            // 
            // TrmCoin
            // 
            this.TrmCoin.Enabled = true;
            this.TrmCoin.Interval = 1;
            this.TrmCoin.Tick += new System.EventHandler(this.TrmCoin_Tick);
            // 
            // TrmEnemySpd
            // 
            this.TrmEnemySpd.Interval = 1;
            this.TrmEnemySpd.Tick += new System.EventHandler(this.TrmEnemySpd_Tick);
            // 
            // LblScore
            // 
            this.LblScore.AutoSize = true;
            this.LblScore.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LblScore.Location = new System.Drawing.Point(95, 315);
            this.LblScore.Name = "LblScore";
            this.LblScore.Size = new System.Drawing.Size(0, 13);
            this.LblScore.TabIndex = 10;
            // 
            // TrmCollect
            // 
            this.TrmCollect.Interval = 1;
            this.TrmCollect.Tick += new System.EventHandler(this.TrmCollect_Tick);
            // 
            // BoxGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 961);
            this.Controls.Add(this.Screen);
            this.Name = "BoxGame";
            this.Text = "BoxGame";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BoxGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BoxGame_KeyUp);
            this.Screen.ResumeLayout(false);
            this.Screen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pad6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pad5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pad4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pad3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pad2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Screen;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer TmrPlayer;
        private System.Windows.Forms.PictureBox Pad;
        private System.Windows.Forms.PictureBox Enemy;
        private System.Windows.Forms.Timer TrmEnemy;
        private System.Windows.Forms.PictureBox Pad3;
        private System.Windows.Forms.PictureBox Pad2;
        private System.Windows.Forms.PictureBox Pad1;
        private System.Windows.Forms.PictureBox Coin;
        private System.Windows.Forms.PictureBox Coin1;
        private System.Windows.Forms.Timer TrmCoin;
        private System.Windows.Forms.PictureBox Pad6;
        private System.Windows.Forms.PictureBox Pad5;
        private System.Windows.Forms.PictureBox Pad4;
        private System.Windows.Forms.Timer TrmEnemySpd;
        private System.Windows.Forms.Label LblScore;
        private System.Windows.Forms.Timer TrmCollect;
    }
}

