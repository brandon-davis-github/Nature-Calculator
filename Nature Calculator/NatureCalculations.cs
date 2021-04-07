using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Nature_Calculator
{
    class NatureCalculations
    {
        enum NatureNames
        {
            Modest,   // special attack+  attack-
            Adamant,  // special attack-  attack+
            Timid,    // speed+  attack-
            Jolly,    // speed+  special attack-
            Lonely,   // attack+  defense-
            Naughty,  // attack+  special defense-
            Mild,     // special attack+  defense-
            Rash,     // special attack+  special defense-
            Hasty,    // speed+  defense-
            Naive,    // speed+  special defense-
            Hardy,    // neutral
            Docile,   // neutral
            Bashful,  // neutral
            Quirky,   // neutral
            Serious,  // neutral
        }
        static string[] Nature = { "Modest", "Adamant", "Timid", "Jolly", "Lonely", "Naughty",
        "Mild", "Rash", "Hasty", "Naive", "Hardy", "Docile", "Bashful", "Quirky", "Serious"};
        public static string GetNature(PokemonStats Stats)  // runs calculations to return ideal nature
        {
            if (Stats._speed < 100)
            {
                if (Stats._specialAttack > Stats._attack)
                {
                    return "Modest[Special Attack+  Attack-]";
                }
                if (Stats._attack > Stats._specialAttack)
                { 
                    return "Adamant[Attack+  Special Attack-]"; 
                }
            }
            if (Stats._speed >= 100)
            {
                if (Stats._specialAttack > Stats._attack)
                {
                    return "Modest[Special Attack+  Attack-], Timid[Speed+  Attack-]";
                }
                if (Stats._attack > Stats._specialAttack)
                {
                    return "Adamant[Attack+  Special Attack-], Jolly[Speed+  SpecialAttack-]";
                }
            }
            if (Stats._defense <= 60)
            {
                if (Stats._attack > Stats._specialAttack)
                {
                    if (Stats._speed >= 100)
                    {
                        return "Lonely[Attack+  Defense-], Hasty[Speed+  Defense-]";
                    }
                    return "Lonely[Attack+  Defense-]";
                }
                if (Stats._specialAttack > Stats._attack)
                {
                    if (Stats._speed >= 100)
                    {
                        return "Mild[Special Attack+  Defense-], Hasty[Speed+  Defense-]";
                    }
                    return "Mild[Special Attack+  Defense-]";
                }
            }
            if (Stats._specialDefense <= 60)
            {
                if (Stats._attack > Stats._specialAttack)
                {
                    if (Stats._speed >= 100)
                    {
                        return "Naughty[Attack+  Special Defense-], Naive[Speed+  Special Defense-]";
                    }
                    return "Naughty[Attack+  Special Defense-]";
                }
            }
            if (Stats._specialDefense <= 60)
            {
                if (Stats._specialAttack > Stats._attack)
                {
                    if (Stats._speed >= 100)
                    {
                        return "Rash[Special Attack+  Special Defense-], Naive[Speed+  Special Defense-]";
                    }
                    return "Rash[Special Attack+  Special Defense-]";
                }
            }
            // if none of the above calculations are met, a neutral nature is best
            return "You should use a neutral nature like: Hardy, Docile, Bashful, Quirky, Serious";
        }
    }
}

