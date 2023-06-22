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
            // Get the coordinates of the two points from the user for LINE1
            Console.WriteLine("Enter Cordinate For LINE1");
            Console.WriteLine("Enter the coordinates of the first point (x1, y1):");
            double x_one = Convert.ToDouble(Console.ReadLine());
            double y_one = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of the second point (x2, y2):");
            double x_two = Convert.ToDouble(Console.ReadLine());
            double y_two = Convert.ToDouble(Console.ReadLine());
           
            double length_one = Math.Sqrt(Math.Pow((x_two - x_one), 2) + Math.Pow((y_two - y_one), 2));
            Console.WriteLine("The length of the line1 is: " + length_one);

            // Get the coordinates of the two points from the user for LINE2
            Console.WriteLine("Enter Cordinate For LINE2");
            Console.WriteLine("Enter the coordinates of the first point (A1, B1):");
            double a_one = Convert.ToDouble(Console.ReadLine());
            double b_one = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of the second point (A2, B2):");
            double a_two = Convert.ToDouble(Console.ReadLine());
            double b_two = Convert.ToDouble(Console.ReadLine());

            double length_two = Math.Sqrt(Math.Pow((a_two - a_one), 2) + Math.Pow((b_two - b_one), 2));
            Console.WriteLine("The length of the line2 is: " + length_two);

            if (length_one == length_two)
            {
                Console.WriteLine( "Both Lines are Equal" );
            }
            else if (length_one > length_two)
            {
                Console.WriteLine("Line1 is greater than Line2");
            }
            else
            {
                Console.WriteLine("Line1 is less than Line2");
            }
        }
    }
}
