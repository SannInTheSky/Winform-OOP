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
            this.pictureTitle = new System.Windows.Forms.PictureBox();
            this.pictureBackground = new System.Windows.Forms.PictureBox();
            this.lblClickStart = new System.Windows.Forms.Label();
            this.lblClickExit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureTitle
            // 
            this.pictureTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureTitle.BackColor = System.Drawing.Color.Transparent;
            this.pictureTitle.Image = global::GameCharacterWinForms.Properties.Resources.Title;
            this.pictureTitle.Location = new System.Drawing.Point(122, 82);
            this.pictureTitle.Name = "pictureTitle";
            this.pictureTitle.Size = new System.Drawing.Size(582, 128);
            this.pictureTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTitle.TabIndex = 3;
            this.pictureTitle.TabStop = false;
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
            // lblClickStart
            // 
            this.lblClickStart.AutoSize = true;
            this.lblClickStart.BackColor = System.Drawing.Color.Transparent;
            this.lblClickStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClickStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClickStart.Location = new System.Drawing.Point(351, 277);
            this.lblClickStart.Name = "lblClickStart";
            this.lblClickStart.Size = new System.Drawing.Size(84, 16);
            this.lblClickStart.TabIndex = 4;
            this.lblClickStart.Text = "Start Game";
            this.lblClickStart.Click += new System.EventHandler(this.lblClickStart_Click);
            // 
            // lblClickExit
            // 
            this.lblClickExit.AutoSize = true;
            this.lblClickExit.BackColor = System.Drawing.Color.Transparent;
            this.lblClickExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClickExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClickExit.Location = new System.Drawing.Point(372, 308);
            this.lblClickExit.Name = "lblClickExit";
            this.lblClickExit.Size = new System.Drawing.Size(32, 16);
            this.lblClickExit.TabIndex = 5;
            this.lblClickExit.Text = "Exit";
            this.lblClickExit.Click += new System.EventHandler(this.lblClickExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblClickExit);
            this.Controls.Add(this.lblClickStart);
            this.Controls.Add(this.pictureTitle);
            this.Controls.Add(this.pictureBackground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBackground;
        private System.Windows.Forms.PictureBox pictureTitle;
        private System.Windows.Forms.Label lblClickStart;
        private System.Windows.Forms.Label lblClickExit;
    }
}

