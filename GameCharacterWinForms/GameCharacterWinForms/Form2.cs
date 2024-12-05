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
        private GameCharacter selectedCharacter;
        public GameCharacter currentCharacter;
        public static Form2 Instance;

        public Form2()
        {
            InitializeComponent();
            Instance = this;
        }

        private void btnToBattle_Click(object sender, EventArgs e)
        {
            //Default
            cmbCharacterType.SelectedItem = "Warrior";

            if (cmbCharacterType.SelectedItem.ToString() == null)
            {
                MessageBox.Show("Please select a character class.");
                return;
            }
            if (txtName.Text == null)
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
                }
                currentCharacter = selectedCharacter;

                this.Hide();
                Form3 form3 = new Form3();
                form3.Show();
            }
        }

        private void panelMage_Click(object sender, EventArgs e)
        {
            cmbCharacterType.SelectedItem = "Mage";
            lblSelectedClass.Text = "Mage";
            //string imageFilePath = Path.Combine(Application.StartupPath, "Assets", "wizard-hat.png");
            //pictureSelectedClass.Image = Image.FromFile(imageFilePath);
            //pictureSelectedClass.Invalidate();
        }

        private void panelWarrior_Click(object sender, EventArgs e)
        {
            cmbCharacterType.SelectedItem = "Warrior";
            lblSelectedClass.Text = "Warrior";
            //string imageFilePath = Path.Combine(Application.StartupPath, "Assets", "sword (3).png");
            //pictureSelectedClass.Image = Image.FromFile(imageFilePath);
        }
    }
}
