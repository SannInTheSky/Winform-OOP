using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using GameCharacterWinForms.Models;
using System.Security.Cryptography.X509Certificates;
using System.IO;

namespace GameCharacterWinForms
{
    public partial class Form2 : Form
    {
        public static Form2 Instance;
        private GameCharacter selectedCharacter;
        public GameCharacter currentCharacter;
        public string selectedClassType;

        public Form2()
        {
            InitializeComponent();
            Instance = this;

            cmbCharacterType.SelectedItem = null;
        }

        private void btnToBattle_Click(object sender, EventArgs e)
        {
            //Default

            if (cmbCharacterType.SelectedItem == null)
            {
                MessageBox.Show("Please select a character class.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter character name.");
                return;
            }
            else
            {
                GameCharacter newCharacter;

                if (cmbCharacterType.SelectedItem.ToString() == "Warrior")
                {
                    newCharacter = new Warrior {
                        Name = txtName.Text,
                        Level = 1,
                        Health = 100,
                        Stamina = 50,
                        Strength = 25,
                        Armor = 10
                    };
                    this.selectedCharacter = newCharacter;
                }
                else if (cmbCharacterType.SelectedItem.ToString() == "Mage")
                {
                    newCharacter = new Mage
                    {
                        Name = txtName.Text,
                        Level = 1,
                        Health = 100,
                        Mana = 50,
                        Intelligence = 25,
                        SpellPower = 10
                    };
                    this.selectedCharacter = newCharacter;
                }
                currentCharacter = selectedCharacter;
                selectedClassType = cmbCharacterType.SelectedItem.ToString();

                this.Hide();
                Form3 form3 = new Form3();
                form3.Show();
            }
        }

        private void panelMage_Click(object sender, EventArgs e)
        {
            cmbCharacterType.SelectedItem = "Mage";
            lblSelectedClass.Text = "Mage";
            pictureSelectedClass.Image = Properties.Resources.wizard_hat;
        }

        private void panelWarrior_Click(object sender, EventArgs e)
        {
            cmbCharacterType.SelectedItem = "Warrior";
            lblSelectedClass.Text = "Warrior";
            pictureSelectedClass.Image = Properties.Resources.sword__3_;
        }
    }
}
