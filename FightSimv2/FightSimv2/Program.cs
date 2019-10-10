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

            f1.Attack();
            f2.Hurt(f1.Attack());
            Console.WriteLine(f1.Attack());
            f2.GetHP();
            

            Console.ReadLine();

       
            


        }
    }
}
