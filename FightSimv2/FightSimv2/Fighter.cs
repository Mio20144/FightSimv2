using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSimv2
{
    class Fighter
    {

        private int hp = 100;
        public string name;
        


        public int Attack()
        {
            Random generator = new Random();
            int amount = generator.Next(15, 30);
            return amount;
        }
        public void Hurt(int amount)
        {
            hp -= amount;
        }
        public bool IsAlive()
        {
            if (hp > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int GetHP()
        {
            Console.WriteLine(name + " " + hp);
            return hp;
        }


    }
}
