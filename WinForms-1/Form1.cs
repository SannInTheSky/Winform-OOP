using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_1.Models;

namespace WinForms_1
{
    public partial class Form1 : Form
    {
        private List<GameCharacter> characterCollection = new List<GameCharacter>();
        private GameCharacter selectedCharacter;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCharacter_Click_1(object sender, EventArgs e)
        {
            // Create a new character based on user input
            string name = txtName.Text;
            int level = int.Parse(txtLevel.Text);
            int health = int.Parse(txtHealth.Text);

            GameCharacter newCharacter;

            if (cmbCharacterType.SelectedItem.ToString() == "Warrior")
            {
                int strength = int.Parse(txtStrength.Text);
                newCharacter = new Warrior(name, level, health, strength);
            }
            else if (cmbCharacterType.SelectedItem.ToString() == "Mage")
            {
                int mana = int.Parse(txtMana.Text);
                int intelligence = int.Parse(txtIntelligence.Text);
                newCharacter = new Mage(name, level, health, mana, intelligence);
            }
            else
            {
                MessageBox.Show("Please select a valid character type.");
                return;
            }

            // Add the character to the collection and update the UI
            characterCollection.Add(newCharacter);
            listBoxCharacters.Items.Add(newCharacter.Name);
            MessageBox.Show($"{newCharacter.Name} added to your collection!");
        }

        private void btnSelectCharacter_Click_1(object sender, EventArgs e)
        {
            // Select a character from the collection
            if (listBoxCharacters.SelectedIndex >= 0)
            {
                selectedCharacter = characterCollection[listBoxCharacters.SelectedIndex];
                txtCharacterDetails.Text = selectedCharacter.ToString();
                MessageBox.Show($"{selectedCharacter.Name} selected!");
            }
            else
            {
                MessageBox.Show("Please select a character from the list.");
            }
        }

        private void btnAttack_Click_1(object sender, EventArgs e)
        {
            if (selectedCharacter == null)
            {
                MessageBox.Show("No character selected!");
                return;
            }
            AddToBattleLog(selectedCharacter.Attack());
            txtCharacterDetails.Text = selectedCharacter.ToString();
        }

        private void btnDefend_Click_1(object sender, EventArgs e)
        {

            if (selectedCharacter == null)
            {
                MessageBox.Show("No character selected!");
                return;
            }

            AddToBattleLog(selectedCharacter.Defend());
            txtCharacterDetails.Text = selectedCharacter.ToString();
        }

        private void btnLevelUp_Click_1(object sender, EventArgs e)
        {
            if (selectedCharacter == null)
            {
                MessageBox.Show("No character selected!");
                return;
            }
            selectedCharacter.LevelUp();
            battleLog.Items.Add($"{selectedCharacter.Name} leveled up.");
            txtCharacterDetails.Text = selectedCharacter.ToString();
        }

        private void cmbCharacterType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbCharacterType.SelectedItem.ToString() == "Warrior")
            {
                txtStrength.Enabled = true;
                txtMana.Enabled = false;
                txtIntelligence.Enabled = false;
            }
            else if (cmbCharacterType.SelectedItem.ToString() == "Mage")
            {
                txtMana.Enabled = true;
                txtIntelligence.Enabled = true;
                txtStrength.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please select a valid character type.");
                return;
            }
        }

        private void AddToBattleLog(string message)
        {
            int maxLineLength = 40;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
