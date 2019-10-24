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

            Random generator = new Random();
            int enemyNumber

            while (f1.IsAlive() == true && f2.IsAlive() == true)
            {
                /*fighter A attackerar först
                f1.Attack();
                f2.Hurt(f1.Attack()); //Fighter B tar skada beroende på amount från f1.Attack()
                Thread.Sleep(1000); //gör så att amount slumpas olika, annars blir amount detsamma för båda fighters
                f2.Attack();
                f1.Hurt(f2.Attack());
                f1.GetHP(); //skriver ut hp för fighter A och B
                f2.GetHP();
                Console.ReadLine();
                Console.Clear();*/
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
