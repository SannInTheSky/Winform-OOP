﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_1.Models
{
    internal class Warrior : GameCharacter
    {
        private int Armor { get; set; } = 10;

        public Warrior(string name, int level, int health, int strength)
            : base(name, level, health, 0, strength, 0)
        {

        }

        public override void Attack()
        {
            int baseDamage = Strength * 2;
            int criticalRate = new Random().Next(0, 99);
            bool criticalHit = criticalRate < 20 ? true : false;
            int finalDamage = criticalHit ? baseDamage * 2 : baseDamage;

            if (criticalHit)
                Console.WriteLine($"Attack: {Name} attacks and deals {finalDamage} damage. It was a critical hit!");
            else
                Console.WriteLine($"Attack: {Name} attacks and deals {finalDamage} damage.");
        }

        public override void Defend()
        {
            int damageReduction = Armor / 2;
            int blockRate = new Random().Next(0, 99);
            bool blockedDamage = blockRate < 15 ? true : false;

            if (blockedDamage)
                Console.WriteLine($"Defend: {Name} blocked the incoming attack! All damage is negated.");
            else
                Console.WriteLine($"Defend: {Name} guards for the incoming attack. Damage received is reduced by {damageReduction}.");
        }

        public override void LevelUp()
        {
            const int STR = 5, HP = 20, DF = 2;

            Level++;
            Strength += STR;
            Health += HP;
            Armor += DF;

            Console.WriteLine($"{Name} has reached Level {Level}!");
            Console.WriteLine($"Stats Increased: Strength +{STR}, Health +{HP}, Armor +{DF}");
        }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
            $"Class: Warrior\n" +
            $"\nLevel: {Level}\n" +
            $"Health: {Health}\n" +
            $"Strength: {Strength}\n" +
            $"Armor: {Armor}";
        }
    }
}
