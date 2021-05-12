
namespace RouletteGame
{
    partial class Form1
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
            this.labelStat = new System.Windows.Forms.Label();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSpin = new System.Windows.Forms.Button();
            this.buttonFire = new System.Windows.Forms.Button();
            this.pictureGame = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGame)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStat
            // 
            this.labelStat.AutoSize = true;
            this.labelStat.Font = new System.Drawing.Font("Consolas", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStat.ForeColor = System.Drawing.Color.Olive;
            this.labelStat.Location = new System.Drawing.Point(228, 9);
            this.labelStat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStat.Name = "labelStat";
            this.labelStat.Size = new System.Drawing.Size(694, 51);
            this.labelStat.TabIndex = 9;
            this.labelStat.Text = "TOTAL GAME: 0 WIN: 0 LOSE: 0";
            // 
            // buttonPlay
            // 
            this.buttonPlay.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.ForeColor = System.Drawing.Color.Olive;
            this.buttonPlay.Location = new System.Drawing.Point(13, 94);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(327, 63);
            this.buttonPlay.TabIndex = 10;
            this.buttonPlay.Text = "Play Game";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.ForeColor = System.Drawing.Color.Olive;
            this.buttonLoad.Location = new System.Drawing.Point(13, 206);
            this.buttonLoad.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(327, 63);
            this.buttonLoad.TabIndex = 11;
            this.buttonLoad.Text = "Load Bullet";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSpin
            // 
            this.buttonSpin.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSpin.ForeColor = System.Drawing.Color.Olive;
            this.buttonSpin.Location = new System.Drawing.Point(13, 321);
            this.buttonSpin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSpin.Name = "buttonSpin";
            this.buttonSpin.Size = new System.Drawing.Size(327, 63);
            this.buttonSpin.TabIndex = 12;
            this.buttonSpin.Text = "Spin Chamber";
            this.buttonSpin.UseVisualStyleBackColor = true;
            this.buttonSpin.Click += new System.EventHandler(this.buttonSpin_Click);
            // 
            // buttonFire
            // 
            this.buttonFire.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFire.ForeColor = System.Drawing.Color.Olive;
            this.buttonFire.Location = new System.Drawing.Point(13, 430);
            this.buttonFire.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFire.Name = "buttonFire";
            this.buttonFire.Size = new System.Drawing.Size(327, 63);
            this.buttonFire.TabIndex = 13;
            this.buttonFire.Text = "Fire ->";
            this.buttonFire.UseVisualStyleBackColor = true;
            this.buttonFire.Click += new System.EventHandler(this.buttonFire_Click);
            // 
            // pictureGame
            // 
            this.pictureGame.Image = global::RouletteGame.Properties.Resources.Cover;
            this.pictureGame.Location = new System.Drawing.Point(412, 94);
            this.pictureGame.Name = "pictureGame";
            this.pictureGame.Size = new System.Drawing.Size(652, 399);
            this.pictureGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureGame.TabIndex = 14;
            this.pictureGame.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 547);
            this.Controls.Add(this.pictureGame);
            this.Controls.Add(this.buttonFire);
            this.Controls.Add(this.buttonSpin);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.labelStat);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roussian Roulette Tournament";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStat;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSpin;
        private System.Windows.Forms.Button buttonFire;
        private System.Windows.Forms.PictureBox pictureGame;
    }
}

