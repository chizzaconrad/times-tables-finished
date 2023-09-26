using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace times_tables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to the timetable game, here i will quiz you on a times table of your choice");
            Console.WriteLine("please enter your name");
            Console.WriteLine("name=");
            string name = Console.ReadLine();
            Console.WriteLine("hello" + " " + name);
            Console.WriteLine("please enter  a number between 1 and 12");
            Random RNG = new Random();
            int number = 0;
            int check = 0;
            int score = 0;


            do
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                    check = 1;

                }
                catch
                {
                    Console.WriteLine("please enter a number");
                    check = 0;

                }
                if (number > 12)
                {
                    check = 0;
                    Console.WriteLine("please pick a number between one and 12");

                }

            } while (check == 0);
            Console.WriteLine("get ready for your times tables");
            for (int attempts = 0; attempts < 10; attempts++)
            {
                int multiplier = RNG.Next(1,12);
                int question = number * multiplier;
                Console.WriteLine("what is" + " " +  number + " " + "times" + " " + multiplier);
                int answer = int.Parse(Console.ReadLine());
                if(answer == number * multiplier)
                {
                    Console.WriteLine("congratulations that is the right answer");
                    score++;
                }
                else
                {
                    Console.WriteLine("maybe next time");
                }
            }
            if (score > 5)
            {
             Console.WriteLine("you got" + " " + score + " " + "points, well done!");
            }
            else
            {
             Console.WriteLine("you got" + " " + score + " " + "points, im sure you can get better next time!2");
            }
            Console.ReadLine();
        }   
            
    }
}
