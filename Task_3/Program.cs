using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Task_3
{
    class Program
    {
        static void ListAllRuningProcess()
        {
        
         //  var runningProcs= from   proc in Process.GetProcesses(".") orderby proc.Id select proc;

 
        }
        static void Main(string[] args)
        {
            int [] numbers = { 1, 23,10, 4 };
            var sumf = from i in numbers orderby  i select i;
            foreach(var i in sumf)
            Console.WriteLine(i);
        }
    }
}
