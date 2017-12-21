namespace ruinSpooksBeta
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
            this.mainMenuGroupBox = new System.Windows.Forms.GroupBox();
            this.titlePictureBox = new System.Windows.Forms.PictureBox();
            this.newGameButton = new System.Windows.Forms.PictureBox();
            this.backgroundPicBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.loadFileButton = new System.Windows.Forms.PictureBox();
            this.settings = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.mainMenuGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titlePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newGameButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadFileButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuGroupBox
            // 
            this.mainMenuGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.mainMenuGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainMenuGroupBox.Controls.Add(this.exitButton);
            this.mainMenuGroupBox.Controls.Add(this.settings);
            this.mainMenuGroupBox.Controls.Add(this.loadFileButton);
            this.mainMenuGroupBox.Controls.Add(this.newGameButton);
            this.mainMenuGroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mainMenuGroupBox.Location = new System.Drawing.Point(0, 461);
            this.mainMenuGroupBox.Name = "mainMenuGroupBox";
            this.mainMenuGroupBox.Size = new System.Drawing.Size(884, 100);
            this.mainMenuGroupBox.TabIndex = 1;
            this.mainMenuGroupBox.TabStop = false;
            // 
            // titlePictureBox
            // 
            this.titlePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.titlePictureBox.Image = global::ruinSpooksBeta.Properties.Resources.Title;
            this.titlePictureBox.Location = new System.Drawing.Point(267, 35);
            this.titlePictureBox.Name = "titlePictureBox";
            this.titlePictureBox.Size = new System.Drawing.Size(350, 150);
            this.titlePictureBox.TabIndex = 0;
            this.titlePictureBox.TabStop = false;
            // 
            // newGameButton
            // 
            this.newGameButton.BackgroundImage = global::ruinSpooksBeta.Properties.Resources.grossButton;
            this.newGameButton.Image = global::ruinSpooksBeta.Properties.Resources.newGameText;
            this.newGameButton.Location = new System.Drawing.Point(58, 29);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(75, 50);
            this.newGameButton.TabIndex = 0;
            this.newGameButton.TabStop = false;
            // 
            // backgroundPicBox
            // 
            this.backgroundPicBox.Image = global::ruinSpooksBeta.Properties.Resources.sakuraBackground;
            this.backgroundPicBox.Location = new System.Drawing.Point(0, 0);
            this.backgroundPicBox.Name = "backgroundPicBox";
            this.backgroundPicBox.Size = new System.Drawing.Size(884, 561);
            this.backgroundPicBox.TabIndex = 0;
            this.backgroundPicBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // loadFileButton
            // 
            this.loadFileButton.BackgroundImage = global::ruinSpooksBeta.Properties.Resources.grossButton;
            this.loadFileButton.Location = new System.Drawing.Point(292, 29);
            this.loadFileButton.Name = "loadFileButton";
            this.loadFileButton.Size = new System.Drawing.Size(75, 50);
            this.loadFileButton.TabIndex = 1;
            this.loadFileButton.TabStop = false;
            // 
            // settings
            // 
            this.settings.BackgroundImage = global::ruinSpooksBeta.Properties.Resources.grossButton;
            this.settings.Location = new System.Drawing.Point(516, 29);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(75, 50);
            this.settings.TabIndex = 2;
            this.settings.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImage = global::ruinSpooksBeta.Properties.Resources.grossButton;
            this.exitButton.Location = new System.Drawing.Point(753, 29);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 50);
            this.exitButton.TabIndex = 3;
            this.exitButton.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.titlePictureBox);
            this.Controls.Add(this.mainMenuGroupBox);
            this.Controls.Add(this.backgroundPicBox);
            this.Name = "Form1";
            this.Text = "Ruin Spook\'s";
            this.mainMenuGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.titlePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newGameButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadFileButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox backgroundPicBox;
        private System.Windows.Forms.GroupBox mainMenuGroupBox;
        private System.Windows.Forms.PictureBox titlePictureBox;
        private System.Windows.Forms.PictureBox newGameButton;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.PictureBox settings;
        private System.Windows.Forms.PictureBox loadFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

