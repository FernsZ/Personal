namespace testGame
{
    partial class frmMain
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        int gravity = 5;
        int speed = 3;
        int jumpTimes = 0;

        private void moveLeft()
        {

        }

        private void moveRight()
        {

        }

        private void jump()
        {
            jumpTimes++;
            if(jumpTimes >= 3)
            {

            }
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.player = new System.Windows.Forms.PictureBox();
            this.ground1 = new System.Windows.Forms.PictureBox();
            this.frontWall = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frontWall)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.Location = new System.Drawing.Point(285, 200);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(30, 50);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // ground1
            // 
            this.ground1.Location = new System.Drawing.Point(0, 250);
            this.ground1.Name = "ground1";
            this.ground1.Size = new System.Drawing.Size(1000, 115);
            this.ground1.TabIndex = 1;
            this.ground1.TabStop = false;
            // 
            // frontWall
            // 
            this.frontWall.Location = new System.Drawing.Point(0, 0);
            this.frontWall.Name = "frontWall";
            this.frontWall.Size = new System.Drawing.Size(285, 250);
            this.frontWall.TabIndex = 2;
            this.frontWall.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.frontWall);
            this.Controls.Add(this.ground1);
            this.Controls.Add(this.player);
            this.Name = "frmMain";
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frontWall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox ground1;
        private System.Windows.Forms.PictureBox frontWall;
    }
}

