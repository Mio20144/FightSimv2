using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSimv2
{
    class Fighter
    {

        protected int hp;
        public string name;
        protected int minDamage;
        protected int maxDamage;
        protected int accuracy;
        protected int critValue;
        int amount = 0;
        

        //attack metod som slumpar amount av skada
        public int HeavyAttack()
        {
            Random generator = new Random();
            int accurate = generator.Next(0, 10);
            if (accurate > accuracy)
            {
                amount = generator.Next(minDamage, maxDamage);
                return amount;
            }
            else
            {
                return amount;
            }
            
        }
        public int QuickAttack()
        {
            Random generator = new Random();
            int accurate = generator.Next(0, 10);
            if (accurate > accuracy)
            {
                int critical = generator.Next(0, 10);
                if (critical > critValue)
                {
                    amount = generator.Next(minDamage / 2, maxDamage / 2);
                    amount *= 2;
                    return amount;
                }
                else
                {
                    amount = generator.Next(minDamage / 2, maxDamage / 2);
                    return amount;
                }
                
            }
            else
            {
                return amount;
            }
            
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
