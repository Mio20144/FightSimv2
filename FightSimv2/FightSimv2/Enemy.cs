using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSimv2
{
    class Enemy : Fighter
    {
        public Enemy()
        {
            Random generator = new Random();
            hp = generator.Next(90, 121);
            name = "Bad Guy";
            minDamage = generator.Next(10, 16);
            maxDamage = generator.Next(20, 36);
            accuracy = generator.Next(4, 7);
            critValue = generator.Next(4, 7);
        }

    }
}
