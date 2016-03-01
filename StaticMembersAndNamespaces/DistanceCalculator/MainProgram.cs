using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceCalculator
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Point3D pointOne = new Point3D(1, 2, 3);
            Point3D pointTwo = new Point3D(4, 5, 6);


            double result = DistanceCalculator.CalculateDistance(pointOne, pointTwo);
            Console.WriteLine("The distance is: {0:F3}", result);

        }
    }
}
