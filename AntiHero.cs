using System;
using System.Collections.Generic;
using System.Text;

namespace myStory
{
    class AntiHero : SuperHuman
    {
        public string _attribute { get; set; }
        public AntiHero(string name, int hp, int strength, string attribute) : base(name, hp, strength)
        {
            _name = name;
            _hp = hp;
            _strength = strength;
            _attribute = attribute;
        }
    }
}
