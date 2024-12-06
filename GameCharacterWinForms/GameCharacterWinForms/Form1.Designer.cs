namespace GameCharacterWinForms
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
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBackground = new System.Windows.Forms.PictureBox();
            this.pictureTitle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(311, 265);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(190, 32);
            this.btnStartGame.TabIndex = 0;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(311, 313);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(190, 32);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // pictureBackground
            // 
            this.pictureBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBackground.Image = global::GameCharacterWinForms.Properties.Resources.bg_main;
            this.pictureBackground.Location = new System.Drawing.Point(0, 0);
            this.pictureBackground.Name = "pictureBackground";
            this.pictureBackground.Size = new System.Drawing.Size(800, 450);
            this.pictureBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBackground.TabIndex = 2;
            this.pictureBackground.TabStop = false;
            // 
            // pictureTitle
            // 
            this.pictureTitle.BackColor = System.Drawing.Color.Transparent;
            this.pictureTitle.Image = global::GameCharacterWinForms.Properties.Resources.Title;
            this.pictureTitle.Location = new System.Drawing.Point(200, 97);
            this.pictureTitle.Name = "pictureTitle";
            this.pictureTitle.Size = new System.Drawing.Size(420, 81);
            this.pictureTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTitle.TabIndex = 3;
            this.pictureTitle.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.pictureBackground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBackground;
        private System.Windows.Forms.PictureBox pictureTitle;
    }
}

