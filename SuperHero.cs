using System;
using System.Collections.Generic;
using System.Text;

namespace myStory
{
    class SuperHero : SuperHuman
    {
        public string _specialty { get; set; }
        public SuperHero (string name, int hp, int strength, string specialty) : base (name, hp, strength)
        {
            _name = name;
            _hp = hp;
            _strength = strength;
            _specialty = specialty;
        }
    }
}
