using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AsynchronousTimer
{
    public class Timer
    {
        public static void propFirst(int num)
        {
            Console.WriteLine(num);
        }

        public static void propSecond(int num)
        {
            Console.Beep();
        }

        static void Main(string[] args)
        {
            AsyncTimer asyncTimerOne = new AsyncTimer(propFirst, 1000, 15);
            asyncTimerOne.Start();

            AsyncTimer asyncTimerTwo = new AsyncTimer(propSecond, 900, 15);
            asyncTimerTwo.Start();
        }
    }
}
