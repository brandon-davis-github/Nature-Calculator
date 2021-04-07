using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nature_Calculator
{
    class PokemonStats
    {
        // constructors for all relevant stats
        public string _name { get; set; }
        public int _hp { get; set; }
        public int _attack { get; set; }
        public int _defense { get; set; }
        public int _specialAttack { get; set; }
        public int _specialDefense { get; set; }
        public int _speed { get; set; }

        public PokemonStats(string name, int hp, int attack, int defense, int specialAttack, int specialDefense, int speed)
        {
            _name = name;
            _hp = hp;
            _attack = attack;
            _defense = defense;
            _specialAttack = specialAttack;
            _specialDefense = specialDefense;
            _speed = speed;
        }

        // builds the output string to the user for their input Pokemon
        public override string ToString()
        {
            return $"Name: {UppercaseFirst(_name)}\nHP: {_hp},  Attack: {_attack},  Defense: {_defense},  " + 
            $"Special Attack: {_specialAttack},  Special Defense: { _specialDefense},  Speed: { _speed}\n";
        }
        // uppercases the first letter of the user input for visual appeal of case sensitivity
        private static string UppercaseFirst(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }
    } 
}

