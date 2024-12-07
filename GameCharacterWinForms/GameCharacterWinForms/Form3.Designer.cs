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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.txtCharacterDetails = new System.Windows.Forms.TextBox();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnDefend = new System.Windows.Forms.Button();
            this.btnLevelUp = new System.Windows.Forms.Button();
            this.battleLog = new System.Windows.Forms.ListBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblEnergy = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gboxStatus = new System.Windows.Forms.GroupBox();
            this.iconStatus3 = new System.Windows.Forms.PictureBox();
            this.iconStatus2 = new System.Windows.Forms.PictureBox();
            this.iconStatus1 = new System.Windows.Forms.PictureBox();
            this.iconStatus7 = new System.Windows.Forms.PictureBox();
            this.iconStatus6 = new System.Windows.Forms.PictureBox();
            this.iconStatus5 = new System.Windows.Forms.PictureBox();
            this.iconStatus4 = new System.Windows.Forms.PictureBox();
            this.iconEnergy = new System.Windows.Forms.PictureBox();
            this.iconHealth = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CharacterIdle = new System.Windows.Forms.PictureBox();
            this.CharacterAction = new System.Windows.Forms.PictureBox();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.barEnergy = new GameCharacterWinForms.Models.CustomProgressBar();
            this.barHealth = new GameCharacterWinForms.Models.CustomProgressBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gboxStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconStatus3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconStatus2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconStatus1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconStatus7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconStatus6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconStatus5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconStatus4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEnergy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterIdle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCharacterDetails
            // 
            this.txtCharacterDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCharacterDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCharacterDetails.Location = new System.Drawing.Point(29, 28);
            this.txtCharacterDetails.Multiline = true;
            this.txtCharacterDetails.Name = "txtCharacterDetails";
            this.txtCharacterDetails.ReadOnly = true;
            this.txtCharacterDetails.Size = new System.Drawing.Size(102, 147);
            this.txtCharacterDetails.TabIndex = 17;
            this.txtCharacterDetails.Text = resources.GetString("txtCharacterDetails.Text");
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
            this.battleLog.Location = new System.Drawing.Point(12, 324);
            this.battleLog.Name = "battleLog";
            this.battleLog.Size = new System.Drawing.Size(578, 106);
            this.battleLog.TabIndex = 21;
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
            // lblEnergy
            // 
            this.lblEnergy.AutoSize = true;
            this.lblEnergy.BackColor = System.Drawing.Color.Transparent;
            this.lblEnergy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnergy.ForeColor = System.Drawing.Color.White;
            this.lblEnergy.Location = new System.Drawing.Point(173, 35);
            this.lblEnergy.Name = "lblEnergy";
            this.lblEnergy.Size = new System.Drawing.Size(26, 15);
            this.lblEnergy.TabIndex = 31;
            this.lblEnergy.Text = "MP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(173, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "HP";
            // 
            // gboxStatus
            // 
            this.gboxStatus.Controls.Add(this.iconStatus3);
            this.gboxStatus.Controls.Add(this.iconStatus2);
            this.gboxStatus.Controls.Add(this.iconStatus1);
            this.gboxStatus.Controls.Add(this.iconStatus7);
            this.gboxStatus.Controls.Add(this.txtCharacterDetails);
            this.gboxStatus.Controls.Add(this.iconStatus6);
            this.gboxStatus.Controls.Add(this.iconStatus5);
            this.gboxStatus.Controls.Add(this.iconStatus4);
            this.gboxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxStatus.Location = new System.Drawing.Point(12, 133);
            this.gboxStatus.Name = "gboxStatus";
            this.gboxStatus.Size = new System.Drawing.Size(137, 181);
            this.gboxStatus.TabIndex = 36;
            this.gboxStatus.TabStop = false;
            this.gboxStatus.Text = "STATUS";
            // 
            // iconStatus3
            // 
            this.iconStatus3.Image = global::GameCharacterWinForms.Properties.Resources.level_up__2_;
            this.iconStatus3.Location = new System.Drawing.Point(6, 77);
            this.iconStatus3.Name = "iconStatus3";
            this.iconStatus3.Size = new System.Drawing.Size(15, 15);
            this.iconStatus3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconStatus3.TabIndex = 42;
            this.iconStatus3.TabStop = false;
            // 
            // iconStatus2
            // 
            this.iconStatus2.Image = global::GameCharacterWinForms.Properties.Resources.swords;
            this.iconStatus2.Location = new System.Drawing.Point(6, 44);
            this.iconStatus2.Name = "iconStatus2";
            this.iconStatus2.Size = new System.Drawing.Size(15, 15);
            this.iconStatus2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconStatus2.TabIndex = 41;
            this.iconStatus2.TabStop = false;
            // 
            // iconStatus1
            // 
            this.iconStatus1.Image = global::GameCharacterWinForms.Properties.Resources.wizard;
            this.iconStatus1.Location = new System.Drawing.Point(6, 28);
            this.iconStatus1.Name = "iconStatus1";
            this.iconStatus1.Size = new System.Drawing.Size(15, 15);
            this.iconStatus1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconStatus1.TabIndex = 40;
            this.iconStatus1.TabStop = false;
            // 
            // iconStatus7
            // 
            this.iconStatus7.Image = global::GameCharacterWinForms.Properties.Resources.magic_wand;
            this.iconStatus7.Location = new System.Drawing.Point(6, 142);
            this.iconStatus7.Name = "iconStatus7";
            this.iconStatus7.Size = new System.Drawing.Size(15, 15);
            this.iconStatus7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconStatus7.TabIndex = 39;
            this.iconStatus7.TabStop = false;
            // 
            // iconStatus6
            // 
            this.iconStatus6.Image = global::GameCharacterWinForms.Properties.Resources.wizard_hat;
            this.iconStatus6.Location = new System.Drawing.Point(6, 126);
            this.iconStatus6.Name = "iconStatus6";
            this.iconStatus6.Size = new System.Drawing.Size(15, 15);
            this.iconStatus6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconStatus6.TabIndex = 38;
            this.iconStatus6.TabStop = false;
            // 
            // iconStatus5
            // 
            this.iconStatus5.Image = ((System.Drawing.Image)(resources.GetObject("iconStatus5.Image")));
            this.iconStatus5.Location = new System.Drawing.Point(6, 109);
            this.iconStatus5.Name = "iconStatus5";
            this.iconStatus5.Size = new System.Drawing.Size(15, 15);
            this.iconStatus5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconStatus5.TabIndex = 37;
            this.iconStatus5.TabStop = false;
            // 
            // iconStatus4
            // 
            this.iconStatus4.Image = ((System.Drawing.Image)(resources.GetObject("iconStatus4.Image")));
            this.iconStatus4.Location = new System.Drawing.Point(6, 93);
            this.iconStatus4.Name = "iconStatus4";
            this.iconStatus4.Size = new System.Drawing.Size(15, 15);
            this.iconStatus4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconStatus4.TabIndex = 37;
            this.iconStatus4.TabStop = false;
            // 
            // iconEnergy
            // 
            this.iconEnergy.BackColor = System.Drawing.Color.Transparent;
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
            this.iconHealth.BackColor = System.Drawing.Color.Transparent;
            this.iconHealth.Image = ((System.Drawing.Image)(resources.GetObject("iconHealth.Image")));
            this.iconHealth.Location = new System.Drawing.Point(157, 15);
            this.iconHealth.Name = "iconHealth";
            this.iconHealth.Size = new System.Drawing.Size(15, 15);
            this.iconHealth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconHealth.TabIndex = 32;
            this.iconHealth.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 113);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // CharacterIdle
            // 
            this.CharacterIdle.BackColor = System.Drawing.Color.Transparent;
            this.CharacterIdle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CharacterIdle.Image = global::GameCharacterWinForms.Properties.Resources.Mage_IDLE_animation;
            this.CharacterIdle.Location = new System.Drawing.Point(167, 161);
            this.CharacterIdle.Name = "CharacterIdle";
            this.CharacterIdle.Size = new System.Drawing.Size(164, 157);
            this.CharacterIdle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CharacterIdle.TabIndex = 37;
            this.CharacterIdle.TabStop = false;
            // 
            // CharacterAction
            // 
            this.CharacterAction.BackColor = System.Drawing.Color.Transparent;
            this.CharacterAction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CharacterAction.Image = global::GameCharacterWinForms.Properties.Resources.Mage_IDLE_animation;
            this.CharacterAction.Location = new System.Drawing.Point(167, 161);
            this.CharacterAction.Name = "CharacterAction";
            this.CharacterAction.Size = new System.Drawing.Size(164, 157);
            this.CharacterAction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CharacterAction.TabIndex = 38;
            this.CharacterAction.TabStop = false;
            this.CharacterAction.Visible = false;
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 1000;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
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
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::GameCharacterWinForms.Properties.Resources.villain;
            this.pictureBox2.Location = new System.Drawing.Point(421, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(446, 311);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameCharacterWinForms.Properties.Resources.Battleground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CharacterIdle);
            this.Controls.Add(this.CharacterAction);
            this.Controls.Add(this.gboxStatus);
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
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.gboxStatus.ResumeLayout(false);
            this.gboxStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconStatus3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconStatus2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconStatus1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconStatus7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconStatus6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconStatus5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconStatus4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEnergy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterIdle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private GroupBox gboxStatus;
        private PictureBox iconStatus4;
        private PictureBox iconStatus5;
        private PictureBox iconStatus7;
        private PictureBox iconStatus6;
        private PictureBox iconStatus2;
        private PictureBox iconStatus1;
        private PictureBox iconStatus3;
        private PictureBox CharacterIdle;
        private PictureBox CharacterAction;
        private Timer animationTimer;
        private PictureBox pictureBox2;
    }
}