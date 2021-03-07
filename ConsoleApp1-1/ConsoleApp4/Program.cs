using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

            Console.WriteLine("Program start.");
            sw.Start();
            ConsoleApp4.SleepHelper.SleepAWhile(3);
            sw.Stop();

            sw.Start();
            ConsoleApp4.SleepHelper.SleepAWhile(6);
            sw.Stop();

            Console.WriteLine("Program End. Total use" + sw.ElapsedMilliseconds);
            Console.ReadLine();

        }
    }
}
