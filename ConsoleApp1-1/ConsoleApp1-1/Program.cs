using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string item in args)
                Console.WriteLine($" { item}");
                Console.ReadLine();
        }
    }
}
