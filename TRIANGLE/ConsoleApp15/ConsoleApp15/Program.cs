using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
    class Program
    {
        public static int ValidateTriangle(string selectside)
        {
            int x = 1;
            bool checkvalid = false;

            while (checkvalid == false)
            {
                Console.WriteLine("Enter value of one side");
                string sidevalue = Console.ReadLine();
                Console.WriteLine();

                bool trifinal = int.TryParse(sidevalue, out x);
                if (trifinal == false)
                {
                    Console.WriteLine("enter a valid input");
                }
                else if (x <= 0)
                {
                    Console.WriteLine("enter a valid side value");
                }
                else
                {
                    checkvalid = true;
                    Console.WriteLine($"{selectside} of the triangle is:{x}.\n");
                }
            }

                return x;
            
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.valside();
            Console.ReadKey();
        }
        public void valside()
        {
            bool validtriselect = false;
            string triselect;

            while (validtriselect == false)
            {
                do
                {
                    Console.WriteLine("1:-Enter the sides");
                    Console.WriteLine("2:-exit.\n");
                    triselect = Console.ReadLine();
                    Console.WriteLine();
                    if (triselect != "1" && triselect != "2")
                    {
                        Console.WriteLine("Invalid selection,select valid option.\n");
                    }
                    else if (int.Parse(triselect) == 1)
                    {
                        validtriselect = true;
                        int a;
                        int b;
                        int c;

                        a = ValidateTriangle("side one");
                        b = ValidateTriangle("side two");
                        c = ValidateTriangle("side three");

                       // Console.WriteLine($" first side is{a} and second side is{b} and third side is {c}.\n");
                        Console.WriteLine(TriangleSolver.Analyze(a, b, c));
                    }
                    else if (int.Parse(triselect) == 2)
                    {
                        Environment.Exit(0);
                    }
                    Console.Write("");
                } while (triselect != "2");
            }
        }
    }
}
       
      
    

