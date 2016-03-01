using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program1
{
     static void Main(string[] args)
     {
         Console.Write("Name: ");
         string personName = Console.ReadLine();
         Console.Write("Age: ");
         int personAge = int.Parse(Console.ReadLine());
         Console.Write("Email: ");
         string personEmail = Console.ReadLine();

         Persons Ivo = new Persons(personName,personAge,personEmail);
         Console.WriteLine(Ivo.ToString());
      }
}

