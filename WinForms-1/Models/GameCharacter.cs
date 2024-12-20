﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_1.Models
{
    internal abstract class GameCharacter
    {
        public string Name { get; protected set; }
        private int _Level { get; set; }
        private int _Health { get; set; }
        private int _Mana { get; set; }
        private int _Strength { get; set; }
        private int _Intelligence { get; set; }

        public int Level
        {
            get => _Level;
            protected set
            {
                if (value < 0)
                    throw new ArgumentException("Error: Character Level cannot be negative");
                _Level = value;
            }
        }

        public int Health
        {
            get => _Health;
            protected set
            {
                if (value < 0)
                    throw new ArgumentException("Error: Character Health cannot be negative");
                _Health = value;
            }
        }

        public int Mana
        {
            get => _Mana;
            protected set
            {
                if (value < 0)
                    throw new ArgumentException("Error: Character Mana cannot be negative");
                _Mana = value;
            }
        }

        public int Strength
        {
            get => _Strength;
            protected set
            {
                if (value < 0)
                    throw new ArgumentException("Error: Character Strength cannot be negative");
                _Strength = value;
            }
        }

        public int Intelligence
        {
            get => _Intelligence;
            protected set
            {
                if (value < 0)
                    throw new ArgumentException("Error: Character Intelligence cannot be negative");
                _Intelligence = value;
            }
        }

        public GameCharacter(string name, int level, int health, int mana, int strength, int intelligence)
        {
            Name = name;
            Level = level;
            Health = health;
            Mana = mana;
            Strength = strength;
            Intelligence = intelligence;
        }

        public abstract string Attack();
        public abstract string Defend();
        public abstract void LevelUp();
    }
}
