using System.Drawing;
using System.Windows.Forms;

namespace GameCharacterWinForms
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.txtCharacterDetails = new System.Windows.Forms.TextBox();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnDefend = new System.Windows.Forms.Button();
            this.btnLevelUp = new System.Windows.Forms.Button();
            this.battleLog = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.customProgressBar4 = new GameCharacterWinForms.Models.CustomProgressBar();
            this.customProgressBar3 = new GameCharacterWinForms.Models.CustomProgressBar();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lblMana = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCharacterDetails
            // 
            this.txtCharacterDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCharacterDetails.Location = new System.Drawing.Point(12, 130);
            this.txtCharacterDetails.Multiline = true;
            this.txtCharacterDetails.Name = "txtCharacterDetails";
            this.txtCharacterDetails.ReadOnly = true;
            this.txtCharacterDetails.Size = new System.Drawing.Size(137, 168);
            this.txtCharacterDetails.TabIndex = 17;
            this.txtCharacterDetails.Text = "Character details will appear here.";
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(596, 324);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(192, 34);
            this.btnAttack.TabIndex = 18;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            // 
            // btnDefend
            // 
            this.btnDefend.Location = new System.Drawing.Point(596, 364);
            this.btnDefend.Name = "btnDefend";
            this.btnDefend.Size = new System.Drawing.Size(192, 34);
            this.btnDefend.TabIndex = 19;
            this.btnDefend.Text = "Defend";
            this.btnDefend.UseVisualStyleBackColor = true;
            // 
            // btnLevelUp
            // 
            this.btnLevelUp.Location = new System.Drawing.Point(596, 404);
            this.btnLevelUp.Name = "btnLevelUp";
            this.btnLevelUp.Size = new System.Drawing.Size(192, 34);
            this.btnLevelUp.TabIndex = 20;
            this.btnLevelUp.Text = "Level Up";
            this.btnLevelUp.UseVisualStyleBackColor = true;
            // 
            // battleLog
            // 
            this.battleLog.FormattingEnabled = true;
            this.battleLog.Location = new System.Drawing.Point(12, 317);
            this.battleLog.Name = "battleLog";
            this.battleLog.Size = new System.Drawing.Size(578, 121);
            this.battleLog.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 113);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(707, 8);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(81, 20);
            this.btnMenu.TabIndex = 29;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // customProgressBar4
            // 
            this.customProgressBar4.Location = new System.Drawing.Point(200, 39);
            this.customProgressBar4.Name = "customProgressBar4";
            this.customProgressBar4.ProgressBarColor = System.Drawing.Color.DeepSkyBlue;
            this.customProgressBar4.Size = new System.Drawing.Size(100, 8);
            this.customProgressBar4.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.customProgressBar4.TabIndex = 35;
            this.customProgressBar4.Value = 100;
            // 
            // customProgressBar3
            // 
            this.customProgressBar3.Location = new System.Drawing.Point(200, 20);
            this.customProgressBar3.Name = "customProgressBar3";
            this.customProgressBar3.ProgressBarColor = System.Drawing.Color.Red;
            this.customProgressBar3.Size = new System.Drawing.Size(140, 8);
            this.customProgressBar3.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.customProgressBar3.TabIndex = 34;
            this.customProgressBar3.Value = 100;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(157, 35);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(15, 15);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 33;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(157, 15);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(15, 15);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 32;
            this.pictureBox7.TabStop = false;
            // 
            // lblMana
            // 
            this.lblMana.AutoSize = true;
            this.lblMana.Location = new System.Drawing.Point(173, 35);
            this.lblMana.Name = "lblMana";
            this.lblMana.Size = new System.Drawing.Size(23, 13);
            this.lblMana.TabIndex = 31;
            this.lblMana.Text = "MP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "HP";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customProgressBar4);
            this.Controls.Add(this.customProgressBar3);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.lblMana);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.battleLog);
            this.Controls.Add(this.btnLevelUp);
            this.Controls.Add(this.btnDefend);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.txtCharacterDetails);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCharacterDetails;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnDefend;
        private System.Windows.Forms.Button btnLevelUp;
        private System.Windows.Forms.ListBox battleLog;
        private PictureBox pictureBox1;
        private Button btnMenu;
        private Models.CustomProgressBar customProgressBar4;
        private Models.CustomProgressBar customProgressBar3;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private Label lblMana;
        private Label label5;
    }
}