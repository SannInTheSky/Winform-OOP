using GameCharacterWinForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            }
            else if (Form2.Instance.selectedClassType == "Warrior")
            {
                lblEnergy.Text = "SP";
                barEnergy.ProgressBarColor = Color.LimeGreen;
                iconEnergy.Image = Properties.Resources.health_care__1_;
            }
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
    }
}
