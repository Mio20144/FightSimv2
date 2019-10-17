using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSimv2
{
    class Barbarian : Fighter
    {
        public Barbarian()
        {
            hp = 120;
            name = "Wolfrid the Bad-Looking";
            minDamage = 20;
            maxDamage = 31;
            accuracy = 6;
            critValue = 4;
        }
    }
}
