using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FightSimv2
{
    class Program
    {
        static void Main(string[] args)
        {
            //fighter A
            Fighter f1 = new Fighter();
            //fighter B
            Fighter f2 = new Fighter();
            //användaren väljer namn på båda fighters
            Console.WriteLine("Please enter a name for Fighter A");
            f1.name = Console.ReadLine();
            Console.WriteLine("Please enter a name for Fighter B");
            f2.name = Console.ReadLine();
            //spelet körs när båda fighters har mer än 0 hp
            while (f1.IsAlive() == true && f2.IsAlive() == true)
            {
                //fighter A attackerar först
                f1.Attack();
                f2.Hurt(f1.Attack()); //Fighter B tar skada beroende på amount från f1.Attack()
                Thread.Sleep(1000); //gör så att amount slumpas olika, annars blir amount detsamma för båda fighters
                f2.Attack();
                f1.Hurt(f2.Attack());
                f1.GetHP(); //skriver ut hp för fighter A och B
                f2.GetHP();
                Console.ReadLine();
                Console.Clear();
            }
            //om Fighter A har mindre än eller lika med 0 hp
            if (f1.IsAlive() == false)
            {
                Console.WriteLine("Congratulations " + f2.name + "!");
            }
            //om Fighter B har mindre än eller lika med 0 hp
            else if (f2.IsAlive() == false)
            {
                Console.WriteLine("Congratulations " + f1.name + "!");
            }
            //om båda fighters har 0 eller mindre hp samtidigt.
            else if (f1.IsAlive() == false && f2.IsAlive() == false)
            {
                Console.WriteLine("It's a tie");
            }
            
            

            Console.ReadLine();

       
            


        }
    }
}
