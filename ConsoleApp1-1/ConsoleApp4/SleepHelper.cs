using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ConsoleApp4
{
    class SleepHelper
    {
       // name = "second";
        public static void SleepAWhile(int second)
        {
            int ms = second * 1000 * 2;

            System.Threading.Thread.Sleep(ms);
        }
    
    }
}
