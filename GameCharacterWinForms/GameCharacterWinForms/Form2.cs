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

namespace GameCharacterWinForms
{
    public partial class Form2 : Form
    {
        private GameCharacter selectedCharacter;

        public Form2()
        {
            InitializeComponent();

            //panelWarrior.Click += (s, e) =>
            //{
            //    MessageBox.Show("Panel clicked!");
            //    cmbCharacterType.SelectedItem = "Warrior";
            //};

            //panelMage.Click += (s, e) =>
            //{
            //    cmbCharacterType.SelectedItem = "Mage";
            //};
        }

        private void btnToBattle_Click(object sender, EventArgs e)
        {
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
                    this.selectedCharacter = newCharacter;
                }

                //txtCharacterDetails.Text = selectedCharacter.ToString();
                //this.Hide();
                //Form3 form3 = new Form3();
                //form3.Show();
            }
        }

        private void panelMage_Click(object sender, EventArgs e)
        {
                cmbCharacterType.SelectedItem = "Mage";
        }

        private void panelWarrior_Click(object sender, EventArgs e)
        {
            cmbCharacterType.SelectedItem = "Warrior";
        }
    }
}
