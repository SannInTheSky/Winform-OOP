﻿namespace GameCharacterWinForms
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnToBattle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbCharacterType = new System.Windows.Forms.ComboBox();
            this.lblSelectedClass = new System.Windows.Forms.Label();
            this.pictureSelectedClass = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.panelMage = new GameCharacterWinForms.Models.ClickablePanel();
            this.customProgressBar4 = new GameCharacterWinForms.Models.CustomProgressBar();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customProgressBar3 = new GameCharacterWinForms.Models.CustomProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblIntelligence = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lblMana = new System.Windows.Forms.Label();
            this.panelWarrior = new GameCharacterWinForms.Models.ClickablePanel();
            this.customProgressBar2 = new GameCharacterWinForms.Models.CustomProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblWarriorDescription = new System.Windows.Forms.Label();
            this.customProgressBar1 = new GameCharacterWinForms.Models.CustomProgressBar();
            this.lblArmor = new System.Windows.Forms.Label();
            this.lblWarriorLevel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblStrength = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblStamina = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSelectedClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.panelMage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panelWarrior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnToBattle
            // 
            this.btnToBattle.BackColor = System.Drawing.SystemColors.Control;
            this.btnToBattle.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToBattle.Location = new System.Drawing.Point(298, 389);
            this.btnToBattle.Name = "btnToBattle";
            this.btnToBattle.Size = new System.Drawing.Size(199, 42);
            this.btnToBattle.TabIndex = 0;
            this.btnToBattle.Text = "FIGHT!";
            this.btnToBattle.UseVisualStyleBackColor = false;
            this.btnToBattle.Click += new System.EventHandler(this.btnToBattle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(232, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(298, 353);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(199, 20);
            this.txtName.TabIndex = 16;
            // 
            // cmbCharacterType
            // 
            this.cmbCharacterType.FormattingEnabled = true;
            this.cmbCharacterType.Items.AddRange(new object[] {
            "Warrior",
            "Mage"});
            this.cmbCharacterType.Location = new System.Drawing.Point(337, 396);
            this.cmbCharacterType.Name = "cmbCharacterType";
            this.cmbCharacterType.Size = new System.Drawing.Size(121, 21);
            this.cmbCharacterType.TabIndex = 23;
            // 
            // lblSelectedClass
            // 
            this.lblSelectedClass.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectedClass.Font = new System.Drawing.Font("Montgomery", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedClass.ForeColor = System.Drawing.Color.White;
            this.lblSelectedClass.Location = new System.Drawing.Point(323, 316);
            this.lblSelectedClass.Name = "lblSelectedClass";
            this.lblSelectedClass.Size = new System.Drawing.Size(151, 27);
            this.lblSelectedClass.TabIndex = 24;
            this.lblSelectedClass.Text = "CHOOSE";
            this.lblSelectedClass.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureSelectedClass
            // 
            this.pictureSelectedClass.BackColor = System.Drawing.Color.Transparent;
            this.pictureSelectedClass.Location = new System.Drawing.Point(314, 307);
            this.pictureSelectedClass.Name = "pictureSelectedClass";
            this.pictureSelectedClass.Size = new System.Drawing.Size(33, 31);
            this.pictureSelectedClass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSelectedClass.TabIndex = 21;
            this.pictureSelectedClass.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(503, 389);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(43, 42);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 18;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(249, 389);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(43, 42);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 17;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox13.Image = global::GameCharacterWinForms.Properties.Resources.SelecChar;
            this.pictureBox13.Location = new System.Drawing.Point(241, -7);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(301, 131);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 21;
            this.pictureBox13.TabStop = false;
            // 
            // panelMage
            // 
            this.panelMage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelMage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMage.Controls.Add(this.customProgressBar4);
            this.panelMage.Controls.Add(this.pictureBox10);
            this.panelMage.Controls.Add(this.label1);
            this.panelMage.Controls.Add(this.customProgressBar3);
            this.panelMage.Controls.Add(this.label2);
            this.panelMage.Controls.Add(this.label6);
            this.panelMage.Controls.Add(this.pictureBox9);
            this.panelMage.Controls.Add(this.pictureBox6);
            this.panelMage.Controls.Add(this.lblIntelligence);
            this.panelMage.Controls.Add(this.label5);
            this.panelMage.Controls.Add(this.pictureBox8);
            this.panelMage.Controls.Add(this.pictureBox7);
            this.panelMage.Controls.Add(this.lblMana);
            this.panelMage.Location = new System.Drawing.Point(417, 88);
            this.panelMage.Name = "panelMage";
            this.panelMage.Size = new System.Drawing.Size(341, 210);
            this.panelMage.TabIndex = 22;
            this.panelMage.Click += new System.EventHandler(this.panelMage_Click);
            // 
            // customProgressBar4
            // 
            this.customProgressBar4.Location = new System.Drawing.Point(224, 47);
            this.customProgressBar4.Name = "customProgressBar4";
            this.customProgressBar4.ProgressBarColor = System.Drawing.Color.DeepSkyBlue;
            this.customProgressBar4.Size = new System.Drawing.Size(100, 8);
            this.customProgressBar4.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.customProgressBar4.TabIndex = 22;
            this.customProgressBar4.Value = 100;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Location = new System.Drawing.Point(13, 20);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(157, 175);
            this.pictureBox10.TabIndex = 0;
            this.pictureBox10.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 55);
            this.label1.TabIndex = 6;
            this.label1.Text = "A powerful spellcaster, the Mage harnesses elemental and mystical magic to contro" +
    "l the battlefield.";
            // 
            // customProgressBar3
            // 
            this.customProgressBar3.Location = new System.Drawing.Point(224, 28);
            this.customProgressBar3.Name = "customProgressBar3";
            this.customProgressBar3.ProgressBarColor = System.Drawing.Color.Red;
            this.customProgressBar3.Size = new System.Drawing.Size(100, 8);
            this.customProgressBar3.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.customProgressBar3.TabIndex = 21;
            this.customProgressBar3.Value = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Spell Power : 10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(176, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Level : 1";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(180, 95);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(15, 15);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 7;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(181, 43);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(15, 15);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // lblIntelligence
            // 
            this.lblIntelligence.AutoSize = true;
            this.lblIntelligence.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntelligence.Location = new System.Drawing.Point(200, 95);
            this.lblIntelligence.Name = "lblIntelligence";
            this.lblIntelligence.Size = new System.Drawing.Size(84, 15);
            this.lblIntelligence.TabIndex = 4;
            this.lblIntelligence.Text = "Intelligence : 25";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Milker", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(197, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 14);
            this.label5.TabIndex = 2;
            this.label5.Text = "HP";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(181, 114);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(15, 15);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 8;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(181, 23);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(15, 15);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 9;
            this.pictureBox7.TabStop = false;
            // 
            // lblMana
            // 
            this.lblMana.AutoSize = true;
            this.lblMana.Font = new System.Drawing.Font("Milker", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMana.Location = new System.Drawing.Point(197, 43);
            this.lblMana.Name = "lblMana";
            this.lblMana.Size = new System.Drawing.Size(25, 14);
            this.lblMana.TabIndex = 3;
            this.lblMana.Text = "MP";
            // 
            // panelWarrior
            // 
            this.panelWarrior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelWarrior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWarrior.Controls.Add(this.customProgressBar2);
            this.panelWarrior.Controls.Add(this.pictureBox1);
            this.panelWarrior.Controls.Add(this.lblWarriorDescription);
            this.panelWarrior.Controls.Add(this.customProgressBar1);
            this.panelWarrior.Controls.Add(this.lblArmor);
            this.panelWarrior.Controls.Add(this.lblWarriorLevel);
            this.panelWarrior.Controls.Add(this.pictureBox2);
            this.panelWarrior.Controls.Add(this.pictureBox5);
            this.panelWarrior.Controls.Add(this.lblStrength);
            this.panelWarrior.Controls.Add(this.lblHealth);
            this.panelWarrior.Controls.Add(this.pictureBox3);
            this.panelWarrior.Controls.Add(this.pictureBox4);
            this.panelWarrior.Controls.Add(this.lblStamina);
            this.panelWarrior.Location = new System.Drawing.Point(43, 88);
            this.panelWarrior.Name = "panelWarrior";
            this.panelWarrior.Size = new System.Drawing.Size(341, 210);
            this.panelWarrior.TabIndex = 21;
            this.panelWarrior.Click += new System.EventHandler(this.panelWarrior_Click);
            // 
            // customProgressBar2
            // 
            this.customProgressBar2.Location = new System.Drawing.Point(224, 46);
            this.customProgressBar2.Name = "customProgressBar2";
            this.customProgressBar2.ProgressBarColor = System.Drawing.Color.LimeGreen;
            this.customProgressBar2.Size = new System.Drawing.Size(100, 8);
            this.customProgressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.customProgressBar2.TabIndex = 20;
            this.customProgressBar2.Value = 100;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 175);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblWarriorDescription
            // 
            this.lblWarriorDescription.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarriorDescription.Location = new System.Drawing.Point(176, 139);
            this.lblWarriorDescription.Name = "lblWarriorDescription";
            this.lblWarriorDescription.Size = new System.Drawing.Size(152, 55);
            this.lblWarriorDescription.TabIndex = 6;
            this.lblWarriorDescription.Text = "A resilient frontline fighter, the Warrior excels in melee combat, using strength" +
    " and heavy armor.";
            // 
            // customProgressBar1
            // 
            this.customProgressBar1.Location = new System.Drawing.Point(224, 27);
            this.customProgressBar1.Name = "customProgressBar1";
            this.customProgressBar1.ProgressBarColor = System.Drawing.Color.Red;
            this.customProgressBar1.Size = new System.Drawing.Size(100, 8);
            this.customProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.customProgressBar1.TabIndex = 19;
            this.customProgressBar1.Value = 100;
            // 
            // lblArmor
            // 
            this.lblArmor.AutoSize = true;
            this.lblArmor.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArmor.Location = new System.Drawing.Point(202, 115);
            this.lblArmor.Name = "lblArmor";
            this.lblArmor.Size = new System.Drawing.Size(62, 15);
            this.lblArmor.TabIndex = 5;
            this.lblArmor.Text = "Armor : 10";
            // 
            // lblWarriorLevel
            // 
            this.lblWarriorLevel.AutoSize = true;
            this.lblWarriorLevel.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarriorLevel.Location = new System.Drawing.Point(176, 71);
            this.lblWarriorLevel.Name = "lblWarriorLevel";
            this.lblWarriorLevel.Size = new System.Drawing.Size(47, 15);
            this.lblWarriorLevel.TabIndex = 1;
            this.lblWarriorLevel.Text = "Level : 1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(180, 94);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 15);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(181, 42);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(15, 15);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // lblStrength
            // 
            this.lblStrength.AutoSize = true;
            this.lblStrength.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrength.Location = new System.Drawing.Point(200, 94);
            this.lblStrength.Name = "lblStrength";
            this.lblStrength.Size = new System.Drawing.Size(73, 15);
            this.lblStrength.TabIndex = 4;
            this.lblStrength.Text = "Strength : 25";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Font = new System.Drawing.Font("Milker", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealth.Location = new System.Drawing.Point(197, 22);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(24, 14);
            this.lblHealth.TabIndex = 2;
            this.lblHealth.Text = "HP";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(181, 113);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(15, 15);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(181, 22);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(15, 15);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // lblStamina
            // 
            this.lblStamina.AutoSize = true;
            this.lblStamina.Font = new System.Drawing.Font("Milker", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStamina.Location = new System.Drawing.Point(197, 42);
            this.lblStamina.Name = "lblStamina";
            this.lblStamina.Size = new System.Drawing.Size(23, 14);
            this.lblStamina.TabIndex = 3;
            this.lblStamina.Text = "SP";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::GameCharacterWinForms.Properties.Resources.bg_main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureSelectedClass);
            this.Controls.Add(this.lblSelectedClass);
            this.Controls.Add(this.panelMage);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnToBattle);
            this.Controls.Add(this.cmbCharacterType);
            this.Controls.Add(this.panelWarrior);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.pictureBox13);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureSelectedClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.panelMage.ResumeLayout(false);
            this.panelMage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panelWarrior.ResumeLayout(false);
            this.panelWarrior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToBattle;
        private System.Windows.Forms.Label lblWarriorLevel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblArmor;
        private System.Windows.Forms.Label lblStrength;
        private System.Windows.Forms.Label lblStamina;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label lblWarriorDescription;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIntelligence;
        private System.Windows.Forms.Label lblMana;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private Models.CustomProgressBar customProgressBar2;
        private Models.CustomProgressBar customProgressBar1;
        private Models.CustomProgressBar customProgressBar4;
        private Models.CustomProgressBar customProgressBar3;
        private Models.ClickablePanel panelWarrior;
        private Models.ClickablePanel panelMage;
        private System.Windows.Forms.ComboBox cmbCharacterType;
        private System.Windows.Forms.Label lblSelectedClass;
        private System.Windows.Forms.PictureBox pictureSelectedClass;
        private System.Windows.Forms.PictureBox pictureBox13;
    }
}