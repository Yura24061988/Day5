using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Task_1
{
    class Program

    {
     
        
        static void WriteSecond()
        { 
            while (true)
            {
                
                Console.WriteLine(new string(' ',  20) + "Secondary");
            }
        }
        static void Main(string[] args)
        {
 
            ThreadStart writeSecond = new ThreadStart(WriteSecond);
            Thread theread = new Thread(writeSecond);
            theread.Start();
            while (true)
            {
                Console.WriteLine("Primary");

            }
        }
    }
}
