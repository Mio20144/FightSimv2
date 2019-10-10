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
        

        //attack metod som slumpar amount av skada
        public int Attack()
        {
            Random generator = new Random();
            int amount = generator.Next(15, 30);
            return amount;
        }
        //drar bort amount från fighters hp
        public void Hurt(int amount)
        {
            hp -= amount;
        }
        //undersöker om hp är mindre än 0 och fighter är död
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
        //skriver ut fighters hp
        public int GetHP()
        {
            Console.WriteLine(name + " " + hp);
            return hp;
        }


    }
}
