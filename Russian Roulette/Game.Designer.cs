namespace Russian_Roulette
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLoadBullet = new System.Windows.Forms.Button();
            this.btnSpinChambers = new System.Windows.Forms.Button();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.btnPlayer = new System.Windows.Forms.Button();
            this.btnAway = new System.Windows.Forms.Button();
            this.pbShot1 = new System.Windows.Forms.PictureBox();
            this.pbShot2 = new System.Windows.Forms.PictureBox();
            this.pbShot3 = new System.Windows.Forms.PictureBox();
            this.pbShot4 = new System.Windows.Forms.PictureBox();
            this.pbShot5 = new System.Windows.Forms.PictureBox();
            this.pbShot6 = new System.Windows.Forms.PictureBox();
            this.btnNewPlayer = new System.Windows.Forms.Button();
            this.lbPlayerName = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.lbShotsLeft = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbShot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShot3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShot4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShot5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShot6)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(16, 645);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(180, 31);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLoadBullet
            // 
            this.btnLoadBullet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadBullet.Location = new System.Drawing.Point(703, 41);
            this.btnLoadBullet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoadBullet.Name = "btnLoadBullet";
            this.btnLoadBullet.Size = new System.Drawing.Size(223, 42);
            this.btnLoadBullet.TabIndex = 1;
            this.btnLoadBullet.Text = "LOAD BULLET";
            this.btnLoadBullet.UseVisualStyleBackColor = true;
            this.btnLoadBullet.Click += new System.EventHandler(this.btnLoadBullet_Click);
            // 
            // btnSpinChambers
            // 
            this.btnSpinChambers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpinChambers.Location = new System.Drawing.Point(703, 119);
            this.btnSpinChambers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSpinChambers.Name = "btnSpinChambers";
            this.btnSpinChambers.Size = new System.Drawing.Size(223, 42);
            this.btnSpinChambers.TabIndex = 2;
            this.btnSpinChambers.Text = "SPIN CHAMBERS";
            this.btnSpinChambers.UseVisualStyleBackColor = true;
            this.btnSpinChambers.Click += new System.EventHandler(this.btnSpinChambers_Click);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.Location = new System.Drawing.Point(703, 535);
            this.btnPlayAgain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(223, 42);
            this.btnPlayAgain.TabIndex = 3;
            this.btnPlayAgain.Text = "PLAY AGAIN";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(56, 484);
            this.txtPlayerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPlayerName.MaxLength = 10;
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(244, 22);
            this.txtPlayerName.TabIndex = 0;
            this.txtPlayerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(337, 484);
            this.txtScore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtScore.Name = "txtScore";
            this.txtScore.ReadOnly = true;
            this.txtScore.Size = new System.Drawing.Size(240, 22);
            this.txtScore.TabIndex = 18;
            this.txtScore.Text = "0";
            this.txtScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPlayer
            // 
            this.btnPlayer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlayer.BackgroundImage")));
            this.btnPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlayer.Location = new System.Drawing.Point(57, 49);
            this.btnPlayer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlayer.Name = "btnPlayer";
            this.btnPlayer.Size = new System.Drawing.Size(244, 286);
            this.btnPlayer.TabIndex = 22;
            this.btnPlayer.Text = "YOURSELF";
            this.btnPlayer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPlayer.UseVisualStyleBackColor = true;
            this.btnPlayer.Click += new System.EventHandler(this.btnPlayer_Click);
            // 
            // btnAway
            // 
            this.btnAway.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAway.BackgroundImage")));
            this.btnAway.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAway.Location = new System.Drawing.Point(337, 49);
            this.btnAway.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAway.Name = "btnAway";
            this.btnAway.Size = new System.Drawing.Size(244, 286);
            this.btnAway.TabIndex = 23;
            this.btnAway.Text = "STAG";
            this.btnAway.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAway.UseVisualStyleBackColor = true;
            this.btnAway.Click += new System.EventHandler(this.btnAway_Click);
            // 
            // pbShot1
            // 
            this.pbShot1.Image = ((System.Drawing.Image)(resources.GetObject("pbShot1.Image")));
            this.pbShot1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbShot1.InitialImage")));
            this.pbShot1.Location = new System.Drawing.Point(711, 289);
            this.pbShot1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbShot1.Name = "pbShot1";
            this.pbShot1.Size = new System.Drawing.Size(31, 151);
            this.pbShot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShot1.TabIndex = 8;
            this.pbShot1.TabStop = false;
            // 
            // pbShot2
            // 
            this.pbShot2.Image = ((System.Drawing.Image)(resources.GetObject("pbShot2.Image")));
            this.pbShot2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbShot2.InitialImage")));
            this.pbShot2.Location = new System.Drawing.Point(749, 289);
            this.pbShot2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbShot2.Name = "pbShot2";
            this.pbShot2.Size = new System.Drawing.Size(31, 151);
            this.pbShot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShot2.TabIndex = 9;
            this.pbShot2.TabStop = false;
            // 
            // pbShot3
            // 
            this.pbShot3.Image = ((System.Drawing.Image)(resources.GetObject("pbShot3.Image")));
            this.pbShot3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbShot3.InitialImage")));
            this.pbShot3.Location = new System.Drawing.Point(788, 289);
            this.pbShot3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbShot3.Name = "pbShot3";
            this.pbShot3.Size = new System.Drawing.Size(31, 151);
            this.pbShot3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShot3.TabIndex = 10;
            this.pbShot3.TabStop = false;
            // 
            // pbShot4
            // 
            this.pbShot4.Image = ((System.Drawing.Image)(resources.GetObject("pbShot4.Image")));
            this.pbShot4.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbShot4.InitialImage")));
            this.pbShot4.Location = new System.Drawing.Point(827, 289);
            this.pbShot4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbShot4.Name = "pbShot4";
            this.pbShot4.Size = new System.Drawing.Size(31, 151);
            this.pbShot4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShot4.TabIndex = 11;
            this.pbShot4.TabStop = false;
            // 
            // pbShot5
            // 
            this.pbShot5.Image = ((System.Drawing.Image)(resources.GetObject("pbShot5.Image")));
            this.pbShot5.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbShot5.InitialImage")));
            this.pbShot5.Location = new System.Drawing.Point(865, 289);
            this.pbShot5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbShot5.Name = "pbShot5";
            this.pbShot5.Size = new System.Drawing.Size(31, 151);
            this.pbShot5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShot5.TabIndex = 12;
            this.pbShot5.TabStop = false;
            // 
            // pbShot6
            // 
            this.pbShot6.Image = ((System.Drawing.Image)(resources.GetObject("pbShot6.Image")));
            this.pbShot6.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbShot6.InitialImage")));
            this.pbShot6.Location = new System.Drawing.Point(904, 289);
            this.pbShot6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbShot6.Name = "pbShot6";
            this.pbShot6.Size = new System.Drawing.Size(31, 151);
            this.pbShot6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShot6.TabIndex = 13;
            this.pbShot6.TabStop = false;
            // 
            // btnNewPlayer
            // 
            this.btnNewPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPlayer.Location = new System.Drawing.Point(703, 585);
            this.btnNewPlayer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewPlayer.Name = "btnNewPlayer";
            this.btnNewPlayer.Size = new System.Drawing.Size(223, 42);
            this.btnNewPlayer.TabIndex = 4;
            this.btnNewPlayer.Text = "NEW PLAYER";
            this.btnNewPlayer.UseVisualStyleBackColor = true;
            this.btnNewPlayer.Click += new System.EventHandler(this.btnNewPlayer_Click);
            // 
            // lbPlayerName
            // 
            this.lbPlayerName.AutoSize = true;
            this.lbPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerName.Location = new System.Drawing.Point(103, 455);
            this.lbPlayerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPlayerName.Name = "lbPlayerName";
            this.lbPlayerName.Size = new System.Drawing.Size(138, 20);
            this.lbPlayerName.TabIndex = 25;
            this.lbPlayerName.Text = "PLAYER NAME";
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.Location = new System.Drawing.Point(416, 455);
            this.lbScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(73, 20);
            this.lbScore.TabIndex = 26;
            this.lbScore.Text = "SCORE";
            // 
            // lbShotsLeft
            // 
            this.lbShotsLeft.AutoSize = true;
            this.lbShotsLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShotsLeft.Location = new System.Drawing.Point(756, 258);
            this.lbShotsLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbShotsLeft.Name = "lbShotsLeft";
            this.lbShotsLeft.Size = new System.Drawing.Size(123, 20);
            this.lbShotsLeft.TabIndex = 28;
            this.lbShotsLeft.Text = "SHOTS LEFT";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.ControlBox = false;
            this.Controls.Add(this.lbShotsLeft);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.lbPlayerName);
            this.Controls.Add(this.btnNewPlayer);
            this.Controls.Add(this.btnAway);
            this.Controls.Add(this.btnPlayer);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.btnSpinChambers);
            this.Controls.Add(this.btnLoadBullet);
            this.Controls.Add(this.pbShot6);
            this.Controls.Add(this.pbShot5);
            this.Controls.Add(this.pbShot4);
            this.Controls.Add(this.pbShot3);
            this.Controls.Add(this.pbShot2);
            this.Controls.Add(this.pbShot1);
            this.Controls.Add(this.btnExit);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ll";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbShot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShot3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShot4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShot5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShot6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLoadBullet;
        private System.Windows.Forms.Button btnSpinChambers;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Button btnPlayer;
        private System.Windows.Forms.Button btnAway;
        private System.Windows.Forms.PictureBox pbShot1;
        private System.Windows.Forms.PictureBox pbShot2;
        private System.Windows.Forms.PictureBox pbShot3;
        private System.Windows.Forms.PictureBox pbShot4;
        private System.Windows.Forms.PictureBox pbShot5;
        private System.Windows.Forms.PictureBox pbShot6;
        private System.Windows.Forms.Button btnNewPlayer;
        private System.Windows.Forms.Label lbPlayerName;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label lbShotsLeft;
    }
}