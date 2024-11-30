namespace WinForms_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            labelName = new Label();
            txtName = new TextBox();
            txtLevel = new TextBox();
            labelLevel = new Label();
            txtHealth = new TextBox();
            labelHealth = new Label();
            labelClassType = new Label();
            cmbCharacterType = new ComboBox();
            labelStrength = new Label();
            txtStrength = new TextBox();
            txtMana = new TextBox();
            labelMana = new Label();
            txtIntelligence = new TextBox();
            labelIntelligence = new Label();
            listBoxCharacters = new ListBox();
            btnAddCharacter = new Button();
            btnSelectCharacter = new Button();
            txtCharacterDetails = new TextBox();
            btnAttack = new Button();
            btnDefend = new Button();
            btnLevelUp = new Button();
            battleLog = new ListBox();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(14, 31);
            labelName.Name = "labelName";
            labelName.Size = new Size(44, 17);
            labelName.TabIndex = 0;
            labelName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(102, 28);
            txtName.Name = "txtName";
            txtName.Size = new Size(170, 22);
            txtName.TabIndex = 1;
            // 
            // txtLevel
            // 
            txtLevel.Location = new Point(102, 65);
            txtLevel.Name = "txtLevel";
            txtLevel.Size = new Size(170, 22);
            txtLevel.TabIndex = 3;
            // 
            // labelLevel
            // 
            labelLevel.AutoSize = true;
            labelLevel.Location = new Point(14, 68);
            labelLevel.Name = "labelLevel";
            labelLevel.Size = new Size(41, 17);
            labelLevel.TabIndex = 2;
            labelLevel.Text = "Level";
            // 
            // txtHealth
            // 
            txtHealth.Location = new Point(102, 102);
            txtHealth.Name = "txtHealth";
            txtHealth.Size = new Size(170, 22);
            txtHealth.TabIndex = 5;
            // 
            // labelHealth
            // 
            labelHealth.AutoSize = true;
            labelHealth.Location = new Point(14, 105);
            labelHealth.Name = "labelHealth";
            labelHealth.Size = new Size(47, 17);
            labelHealth.TabIndex = 4;
            labelHealth.Text = "Health";
            // 
            // labelClassType
            // 
            labelClassType.AutoSize = true;
            labelClassType.Location = new Point(14, 142);
            labelClassType.Name = "labelClassType";
            labelClassType.Size = new Size(38, 17);
            labelClassType.TabIndex = 8;
            labelClassType.Text = "Class";
            // 
            // cmbCharacterType
            // 
            cmbCharacterType.FormattingEnabled = true;
            cmbCharacterType.Items.AddRange(new object[] { "Warrior", "Mage" });
            cmbCharacterType.Location = new Point(102, 139);
            cmbCharacterType.Name = "cmbCharacterType";
            cmbCharacterType.Size = new Size(170, 25);
            cmbCharacterType.TabIndex = 9;
            cmbCharacterType.SelectedIndexChanged += cmbCharacterType_SelectedIndexChanged_1;
            // 
            // labelStrength
            // 
            labelStrength.AutoSize = true;
            labelStrength.Location = new Point(14, 179);
            labelStrength.Name = "labelStrength";
            labelStrength.Size = new Size(59, 17);
            labelStrength.TabIndex = 6;
            labelStrength.Text = "Strength";
            // 
            // txtStrength
            // 
            txtStrength.Location = new Point(102, 176);
            txtStrength.Name = "txtStrength";
            txtStrength.Size = new Size(170, 22);
            txtStrength.TabIndex = 7;
            // 
            // txtMana
            // 
            txtMana.Location = new Point(102, 213);
            txtMana.Name = "txtMana";
            txtMana.Size = new Size(170, 22);
            txtMana.TabIndex = 11;
            // 
            // labelMana
            // 
            labelMana.AutoSize = true;
            labelMana.Location = new Point(14, 216);
            labelMana.Name = "labelMana";
            labelMana.Size = new Size(42, 17);
            labelMana.TabIndex = 10;
            labelMana.Text = "Mana";
            // 
            // txtIntelligence
            // 
            txtIntelligence.Location = new Point(102, 250);
            txtIntelligence.Name = "txtIntelligence";
            txtIntelligence.Size = new Size(170, 22);
            txtIntelligence.TabIndex = 13;
            // 
            // labelIntelligence
            // 
            labelIntelligence.AutoSize = true;
            labelIntelligence.Location = new Point(14, 253);
            labelIntelligence.Name = "labelIntelligence";
            labelIntelligence.Size = new Size(79, 17);
            labelIntelligence.TabIndex = 12;
            labelIntelligence.Text = "Intelligence";
            // 
            // listBoxCharacters
            // 
            listBoxCharacters.FormattingEnabled = true;
            listBoxCharacters.ItemHeight = 17;
            listBoxCharacters.Location = new Point(17, 313);
            listBoxCharacters.Name = "listBoxCharacters";
            listBoxCharacters.Size = new Size(110, 89);
            listBoxCharacters.TabIndex = 14;
            // 
            // btnAddCharacter
            // 
            btnAddCharacter.Location = new Point(133, 313);
            btnAddCharacter.Name = "btnAddCharacter";
            btnAddCharacter.Size = new Size(134, 23);
            btnAddCharacter.TabIndex = 15;
            btnAddCharacter.Text = "Add Character";
            btnAddCharacter.UseVisualStyleBackColor = true;
            btnAddCharacter.Click += btnAddCharacter_Click_1;
            // 
            // btnSelectCharacter
            // 
            btnSelectCharacter.Location = new Point(133, 342);
            btnSelectCharacter.Name = "btnSelectCharacter";
            btnSelectCharacter.Size = new Size(134, 23);
            btnSelectCharacter.TabIndex = 16;
            btnSelectCharacter.Text = "Select Character";
            btnSelectCharacter.UseVisualStyleBackColor = true;
            btnSelectCharacter.Click += btnSelectCharacter_Click_1;
            // 
            // txtCharacterDetails
            // 
            txtCharacterDetails.Location = new Point(346, 31);
            txtCharacterDetails.Multiline = true;
            txtCharacterDetails.Name = "txtCharacterDetails";
            txtCharacterDetails.ReadOnly = true;
            txtCharacterDetails.ScrollBars = ScrollBars.Vertical;
            txtCharacterDetails.Size = new Size(207, 241);
            txtCharacterDetails.TabIndex = 17;
            txtCharacterDetails.Text = "Character details will appear here.";
            // 
            // btnAttack
            // 
            btnAttack.Location = new Point(346, 288);
            btnAttack.Name = "btnAttack";
            btnAttack.Size = new Size(207, 34);
            btnAttack.TabIndex = 18;
            btnAttack.Text = "Attack";
            btnAttack.UseVisualStyleBackColor = true;
            btnAttack.Click += btnAttack_Click_1;
            // 
            // btnDefend
            // 
            btnDefend.Location = new Point(346, 328);
            btnDefend.Name = "btnDefend";
            btnDefend.Size = new Size(207, 34);
            btnDefend.TabIndex = 19;
            btnDefend.Text = "Defend";
            btnDefend.UseVisualStyleBackColor = true;
            btnDefend.Click += btnDefend_Click_1;
            // 
            // btnLevelUp
            // 
            btnLevelUp.Location = new Point(346, 368);
            btnLevelUp.Name = "btnLevelUp";
            btnLevelUp.Size = new Size(207, 34);
            btnLevelUp.TabIndex = 20;
            btnLevelUp.Text = "Level Up";
            btnLevelUp.UseVisualStyleBackColor = true;
            btnLevelUp.Click += btnLevelUp_Click_1;
            // 
            // battleLog
            // 
            battleLog.FormattingEnabled = true;
            battleLog.ItemHeight = 17;
            battleLog.Location = new Point(572, 31);
            battleLog.Name = "battleLog";
            battleLog.Size = new Size(235, 361);
            battleLog.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 415);
            Controls.Add(battleLog);
            Controls.Add(btnLevelUp);
            Controls.Add(btnDefend);
            Controls.Add(btnAttack);
            Controls.Add(txtCharacterDetails);
            Controls.Add(btnSelectCharacter);
            Controls.Add(btnAddCharacter);
            Controls.Add(listBoxCharacters);
            Controls.Add(txtIntelligence);
            Controls.Add(labelIntelligence);
            Controls.Add(txtMana);
            Controls.Add(labelMana);
            Controls.Add(cmbCharacterType);
            Controls.Add(labelClassType);
            Controls.Add(txtStrength);
            Controls.Add(labelStrength);
            Controls.Add(txtHealth);
            Controls.Add(labelHealth);
            Controls.Add(txtLevel);
            Controls.Add(labelLevel);
            Controls.Add(txtName);
            Controls.Add(labelName);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Game Character";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.TextBox txtHealth;
        private System.Windows.Forms.Label labelHealth;
        private System.Windows.Forms.Label labelClassType;
        private System.Windows.Forms.ComboBox cmbCharacterType;
        private System.Windows.Forms.Label labelStrength;
        private System.Windows.Forms.TextBox txtStrength;
        private System.Windows.Forms.TextBox txtMana;
        private System.Windows.Forms.Label labelMana;
        private System.Windows.Forms.TextBox txtIntelligence;
        private System.Windows.Forms.Label labelIntelligence;
        private System.Windows.Forms.ListBox listBoxCharacters;
        private System.Windows.Forms.Button btnAddCharacter;
        private System.Windows.Forms.Button btnSelectCharacter;
        private System.Windows.Forms.TextBox txtCharacterDetails;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnDefend;
        private System.Windows.Forms.Button btnLevelUp;
        private System.Windows.Forms.ListBox battleLog;
    }
}
