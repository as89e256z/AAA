using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ConsoleApp3
{
    public class SleepHelper
    {
       // name = "second";
        public static void SleepAWhile(int second)
        {
            int ms = second * 1000;

            System.Threading.Thread.Sleep(ms);
        }
    
    }
}
