using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
    public static class TriangleSolver
    {
        static string result;
        public static string Analyze(int a, int b, int c)
        {
           // string result = string.Empty;
            if ((a + b) > c && (b + c) > a && (a + c) > b)
            {
                Console.WriteLine("It is  a triangle");

                if (a == b && b == c && c == a)
                {
                    result = "It is equilateral";
                }
                else 
                    if (a == b || b == c || a == c)
                    {
                    result = "It is isosceles";
                }
                else
                {
                    result = "It is Scalene";
                }
            }
            else
            {
                result = "It is not a triangle";
            }

            return result;
        }


        
    }
}
