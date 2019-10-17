using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSimv2
{
    class Rouge : Fighter
    {
        public Rouge()
        {
            hp = 90;
            name = "Sneaky Steve";
            minDamage = 15;
            maxDamage = 26;
            accuracy = 3;
            critValue = 3;
        }

    }
}
