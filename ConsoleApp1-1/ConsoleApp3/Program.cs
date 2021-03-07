using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        
        //日期
        static void Main(string[] args)
        {
            DateTime startTime = DateTime.Now;
            Console.WriteLine("Program start.");
            SleepHelper.SleepAWhile(3);

            DateTime endTime = DateTime.Now;
            TimeSpan ts = endTime - startTime;
            Console.WriteLine("program End, Total use " + ts.TotalMilliseconds);
            Console.ReadLine();
        }
    }
}
