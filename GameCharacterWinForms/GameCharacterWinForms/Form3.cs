using GameCharacterWinForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCharacterWinForms
{

    public partial class Form3 : Form
    {
        GameCharacter selectedCharacter = Form2.Instance.currentCharacter;
        public Form3()
        {
            InitializeComponent();
            
            txtCharacterDetails.Text = selectedCharacter.ToString();

            if (Form2.Instance.selectedClassType == "Mage")
            {
                lblEnergy.Text = "MP";
                barEnergy.ProgressBarColor = Color.DeepSkyBlue;
                iconEnergy.Image = Properties.Resources.magic;

                iconStatus1.Image = Properties.Resources.wizard;
                iconStatus5.Image = Properties.Resources.magic;
                iconStatus6.Image = Properties.Resources.wizard_hat;
                iconStatus7.Image = Properties.Resources.magic_wand;

                CharacterIdle.Image = Properties.Resources.Mage_IDLE_animation;
                CharacterAction.Image = Properties.Resources.Mage_Attack_animation;
            }
            else if (Form2.Instance.selectedClassType == "Warrior")
            {
                lblEnergy.Text = "SP";
                barEnergy.ProgressBarColor = Color.LimeGreen;
                iconEnergy.Image = Properties.Resources.health_care__1_;

                iconStatus1.Image = Properties.Resources.viking;
                iconStatus5.Image = Properties.Resources.health_care__1_;
                iconStatus6.Image = Properties.Resources.sword__3_;
                iconStatus7.Image = Properties.Resources.shield__2_;

                CharacterIdle.Image = Properties.Resources.Warrior_IDLE_animation;
                CharacterIdle.Size = new Size(186, 185);
                CharacterIdle.Location = new Point(152, 129);


                CharacterAction.Image = Properties.Resources.Warrior_Attack_animation;
                CharacterAction.Size = new Size(200, 233);
                CharacterAction.Location = new Point(432, 85);

            }

            CharacterIdle.Visible = true;
            CharacterAction.Visible = false;
            animationTimer.Tick += animationTimer_Tick;

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            AddToBattleLog(selectedCharacter.Attack());
            txtCharacterDetails.Text = selectedCharacter.ToString();

            CharacterIdle.Visible = false;
            CharacterAction.Visible = true;
            animationTimer.Start();
        }

        private void btnDefend_Click(object sender, EventArgs e)
        {
            AddToBattleLog(selectedCharacter.Defend());
            txtCharacterDetails.Text = selectedCharacter.ToString();
        }

        private void btnLevelUp_Click(object sender, EventArgs e)
        {
            selectedCharacter.LevelUp();
            battleLog.Items.Add($"{selectedCharacter.Name} leveled up.");
            txtCharacterDetails.Text = selectedCharacter.ToString();
        }

        private void AddToBattleLog(string message)
        {
            int maxLineLength = 100;
            List<string> lines = new List<string>();

            while (message.Length > maxLineLength)
            {
                int splitIndex = message.LastIndexOf(' ', maxLineLength);
                if (splitIndex == -1) splitIndex = maxLineLength;

                lines.Add(message.Substring(0, splitIndex));
                message = message.Substring(splitIndex).TrimStart();
            }

            if (message.Length > 0)
            {
                lines.Add(message);
            }

            foreach (var line in lines)
            {
                battleLog.Items.Add(line);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            animationTimer.Stop();
            CharacterIdle.Visible = true;
            CharacterAction.Visible = false;
        }
    }
}
