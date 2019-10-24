using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSimv2
{
    class Knight : Fighter
    {

        public Knight()
        {
            hp = 100;
            name = "Sir Madelene";
            minDamage = 20;
            maxDamage = 26;
            accuracy = 5;
            critValue = 5;
        }
    }
}
