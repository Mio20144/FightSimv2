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

            Fighter f1 = new Fighter();
            Fighter f2 = new Fighter();
            Console.WriteLine("Hello. Please choose your Champion");
            Console.WriteLine("1. Barbarian");
            Console.WriteLine("2. Rouge");
            Console.WriteLine("3. Knight");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                f1 = new Barbarian();
            }
            else if (choice == "2")
            {
                f1 = new Rouge();
            }
            else if (choice == "3")
            {
                f1 = new Knight();
            }
            Console.WriteLine("Time to find an opponent");

            f2 = new Enemy();
            Console.WriteLine("We have our fighters");
            Console.WriteLine(f1.name + " vs " + f2.name);
            Console.ReadLine();

            while (f1.IsAlive() == true && f2.IsAlive() == true)
            {

                //fighter A attackerar först
                Console.Clear();
                f1.HeavyAttack();
                f2.Hurt(f1.HeavyAttack()); //Fighter B tar skada beroende på amount från f1.Attack()
                Thread.Sleep(1000); //gör så att amount slumpas olika, annars blir amount detsamma för båda fighters
                f2.HeavyAttack();
                f1.Hurt(f2.HeavyAttack());
                f1.GetHP(); //skriver ut hp för fighter A och B
                f2.GetHP();
                Console.ReadLine();
               
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
