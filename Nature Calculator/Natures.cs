using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nature_Calculator
{
    class Natures
    {
        enum NatureNames
        { 
          modest,   // special attack+  attack-
          adamant,  // special attack-  attack+
          timid,    // speed+  attack-
          jolly,    // speed+  special attack-
          lonely,   // attack+  defense-
          naughty,  // attack+  special defense-
          mild,     // special attack+  defense-
          rash,     // special attack+  special defense-
          hasty,    // speed+  defense-
          naive,    // speed+  special defense-
          hardy,    // neutral
          docile,   // neutral
          bashful,  // neutral
          quirky,   // neutral
          serious,  // neutral
        }
        string[] Nature = { "modest", "adamant", "timid", "jolly", "lonely", "naughty", 
        "mild", "rash", "hasty", "naive", "hardy", "docile", "bashful", "quirky", "serious"};
    }
}
