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
            this.barEnergy = new GameCharacterWinForms.Models.CustomProgressBar();
            this.barHealth = new GameCharacterWinForms.Models.CustomProgressBar();
            this.iconEnergy = new System.Windows.Forms.PictureBox();
            this.iconHealth = new System.Windows.Forms.PictureBox();
            this.lblEnergy = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEnergy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHealth)).BeginInit();
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
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // btnDefend
            // 
            this.btnDefend.Location = new System.Drawing.Point(596, 364);
            this.btnDefend.Name = "btnDefend";
            this.btnDefend.Size = new System.Drawing.Size(192, 34);
            this.btnDefend.TabIndex = 19;
            this.btnDefend.Text = "Defend";
            this.btnDefend.UseVisualStyleBackColor = true;
            this.btnDefend.Click += new System.EventHandler(this.btnDefend_Click);
            // 
            // btnLevelUp
            // 
            this.btnLevelUp.Location = new System.Drawing.Point(596, 404);
            this.btnLevelUp.Name = "btnLevelUp";
            this.btnLevelUp.Size = new System.Drawing.Size(192, 34);
            this.btnLevelUp.TabIndex = 20;
            this.btnLevelUp.Text = "Level Up";
            this.btnLevelUp.UseVisualStyleBackColor = true;
            this.btnLevelUp.Click += new System.EventHandler(this.btnLevelUp_Click);
            // 
            // battleLog
            // 
            this.battleLog.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.battleLog.FormattingEnabled = true;
            this.battleLog.ItemHeight = 17;
            this.battleLog.Location = new System.Drawing.Point(12, 317);
            this.battleLog.Name = "battleLog";
            this.battleLog.Size = new System.Drawing.Size(578, 106);
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
            // barEnergy
            // 
            this.barEnergy.Location = new System.Drawing.Point(200, 39);
            this.barEnergy.Name = "barEnergy";
            this.barEnergy.ProgressBarColor = System.Drawing.Color.DeepSkyBlue;
            this.barEnergy.Size = new System.Drawing.Size(100, 8);
            this.barEnergy.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.barEnergy.TabIndex = 35;
            this.barEnergy.Value = 100;
            // 
            // barHealth
            // 
            this.barHealth.Location = new System.Drawing.Point(200, 20);
            this.barHealth.Name = "barHealth";
            this.barHealth.ProgressBarColor = System.Drawing.Color.Red;
            this.barHealth.Size = new System.Drawing.Size(140, 8);
            this.barHealth.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.barHealth.TabIndex = 34;
            this.barHealth.Value = 100;
            // 
            // iconEnergy
            // 
            this.iconEnergy.Image = ((System.Drawing.Image)(resources.GetObject("iconEnergy.Image")));
            this.iconEnergy.Location = new System.Drawing.Point(157, 35);
            this.iconEnergy.Name = "iconEnergy";
            this.iconEnergy.Size = new System.Drawing.Size(15, 15);
            this.iconEnergy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconEnergy.TabIndex = 33;
            this.iconEnergy.TabStop = false;
            // 
            // iconHealth
            // 
            this.iconHealth.Image = ((System.Drawing.Image)(resources.GetObject("iconHealth.Image")));
            this.iconHealth.Location = new System.Drawing.Point(157, 15);
            this.iconHealth.Name = "iconHealth";
            this.iconHealth.Size = new System.Drawing.Size(15, 15);
            this.iconHealth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconHealth.TabIndex = 32;
            this.iconHealth.TabStop = false;
            // 
            // lblEnergy
            // 
            this.lblEnergy.AutoSize = true;
            this.lblEnergy.Location = new System.Drawing.Point(173, 35);
            this.lblEnergy.Name = "lblEnergy";
            this.lblEnergy.Size = new System.Drawing.Size(23, 13);
            this.lblEnergy.TabIndex = 31;
            this.lblEnergy.Text = "MP";
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
            this.Controls.Add(this.barEnergy);
            this.Controls.Add(this.barHealth);
            this.Controls.Add(this.iconEnergy);
            this.Controls.Add(this.iconHealth);
            this.Controls.Add(this.lblEnergy);
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
            ((System.ComponentModel.ISupportInitialize)(this.iconEnergy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHealth)).EndInit();
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
        private Models.CustomProgressBar barEnergy;
        private Models.CustomProgressBar barHealth;
        private PictureBox iconEnergy;
        private PictureBox iconHealth;
        private Label lblEnergy;
        private Label label5;
    }
}