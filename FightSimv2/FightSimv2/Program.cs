using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSimv2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter f1 = new Fighter();
            Fighter f2 = new Fighter();
            Console.WriteLine("Please enter a name for Fighter A");
            f1.name = Console.ReadLine();
            Console.WriteLine("Please enter a name for Fighter B");
            f2.name = Console.ReadLine();
            while (f1.IsAlive() == true && f2.IsAlive() == true)
            {
                f1.Attack();
                f2.Hurt(f1.Attack());
                f2.Attack();
                f1.Hurt(f2.Attack());
                f1.GetHP();
                f2.GetHP();
                Console.ReadLine();
                Console.Clear();
            }
            if (f1.IsAlive() == false)
            {
                Console.WriteLine("Congratulations " + f2.name + "!");
            }
            else if (f2.IsAlive() == false)
            {
                Console.WriteLine("Congratulations " + f1.name + "!");
            }
            else
            {
                Console.WriteLine("It's a tie");
            }
            
            

            Console.ReadLine();

       
            


        }
    }
}
