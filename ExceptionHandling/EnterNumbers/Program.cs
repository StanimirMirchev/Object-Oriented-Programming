using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterNumbers
{
    class Program
    {

        static void Main()
        {
            int startNumber = 1;
            int endNumber = 100;
            int currNumber = 0;

            for (int i = 0; i < 10; i++)
            {
                 currNumber = ReadNumber(startNumber, endNumber);
            }
        }
        static int ReadNumber(int startNumber, int endNumber)
        {
            int currNumber = 0;

            try
            {

                Console.Write("Enter number in interval [ {0},{1} ]: ", startNumber, endNumber);
                currNumber = int.Parse(Console.ReadLine());
                if ( !(startNumber < currNumber && currNumber < endNumber) )
                {
                    while ( !(startNumber < currNumber && currNumber < endNumber) )
                    {
                        Console.WriteLine("Entered number not in interval [ {0},{1} ] !", startNumber, endNumber);
                        Console.Write("Enter number in interval [ {0},{1} ]: ", startNumber, endNumber);
                        currNumber = int.Parse(Console.ReadLine());
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Number you entered is invalid!");
                throw;
            }

            return currNumber;
        }
    }
}
