using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    { static void WriteSecond()
        {
            int counter=0;
            Console.ForegroundColor = ConsoleColor.Red;
            while (true)
            {
                // Thread.Sleep(500);
               
                Console.WriteLine(new string(' ', 15) + "Hello word");
                counter++;
                Console.ResetColor();
            }
             
        }
        static void Main(string[] args)
        {
            ThreadStart wrineSecond = new ThreadStart(WriteSecond);
            Thread thread = new Thread(wrineSecond);
             thread.Start();

            while (true)
            {
                Console.WriteLine("Hello Potok");
                 Console.ResetColor();

            } 
        }
    }
}
