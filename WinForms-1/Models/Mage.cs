using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_1.Models
{
    internal class Mage : GameCharacter 
    {
        private int SpellPower { get; set; } = 10;

        public Mage(string name, int level, int health, int mana, int intelligence)
            : base(name, level, health, mana, 0, intelligence)
        {

        }

        public override void Attack()
        {
            int magicDamage = (Intelligence * 3) + SpellPower;
            int burnChance = new Random().Next(0, 99);
            bool burnEffect = burnChance < 25 ? true : false;

            if (burnEffect)
                Console.WriteLine($"Attack: {Name} casts a spell and deals {magicDamage} magic damage. Additional burn effect is applied.");
            else
                Console.WriteLine($"Attack: {Name} casts a spell and deals {magicDamage} magic damage.");
        }

        public override void Defend()
        {
            int damageReduction = Mana / 4;
            int evadeChance = new Random().Next(0, 99);
            bool evadeAttack = evadeChance < 20 ? true : false;

            if (evadeAttack)
                Console.WriteLine($"Defend: {Name} evades the attack and negates all incoming damage.");
            else
                Console.WriteLine($"Defend: {Name} guards for the incoming attack. Damage received is reduced by {damageReduction}.");
        }

        public override void LevelUp()
        {
            const int INT = 5, MP = 15, SP = 3;

            Level++;
            Intelligence += INT;
            Mana += MP;
            SpellPower += SP;

            Console.WriteLine($"{Name} has reached Level {Level}!");
            Console.WriteLine($"Stats Increased: Intelligence +{INT}, Mana +{MP}, Spell Power +{SP}");
        }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
            $"Class: Mage\n" +
            $"\nLevel: {Level}\n" +
            $"Health: {Health}\n" +
            $"Mana: {Mana}\n" +
            $"Intelligence: {Intelligence}\n" +
            $"Spell Power: {SpellPower}";
        }
    }
}
