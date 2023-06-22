using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    public class LineBase
    {
        public void Line()
        {
            // Get the coordinates of the two points from the user
            Console.WriteLine("Enter the coordinates of the first point (x1, y1):");
            double x_one = Convert.ToDouble(Console.ReadLine());
            double y_one = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of the second point (x2, y2):");
            double x_two = Convert.ToDouble(Console.ReadLine());
            double y_two = Convert.ToDouble(Console.ReadLine());
           
            double length = Math.Sqrt(Math.Pow(x_two - x_one, 2) + Math.Pow(y_two - y_one, 2));
            Console.WriteLine("The length of the line is: " + length);
        }
    }
}
