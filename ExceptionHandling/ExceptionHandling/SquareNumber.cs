using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class SquareNumber
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter number: ");
                int number = int.Parse(Console.ReadLine());
                if(number < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                IntegerNumber enteredNumber = new IntegerNumber(number);
                Console.WriteLine(enteredNumber.squareRoot());
               
            }
            catch(FormatException)
            {
                Console.WriteLine("Invalid number!");
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("Number must be positive!");
            }
            finally
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}
