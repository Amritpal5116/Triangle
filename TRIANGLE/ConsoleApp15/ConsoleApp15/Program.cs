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

            while(checkvalid==false)
            {
                Console.WriteLine("Enter value of one side");
                string sidevalue = Console.ReadLine();
                


            }
        }
        public static void Menu()
        {
            string inputValue = null;
            bool Menu = false;
            while (Menu == false)
            {
                    Console.WriteLine("1.Enter Value:");
                    Console.WriteLine("2.Exit\n");
                    inputValue = Console.ReadLine();

                    if (inputValue != "1" &&
                       inputValue != "2")
                    {
                        Console.WriteLine($"Please enter the valid value");
                    }
                    else if (int.Parse(inputValue) == 1)
                    {
                        Menu = true;
                        //Console.WriteLine("Enter value of one side");
                        int a;
                        //Console.WriteLine("Enter value of second side");
                        int b;
                        //Console.WriteLine("Enter value of third side");
                        int c;
                        a = ValidateTriangle("one side");
                        b = ValidateTriangle("second side");
                        c = ValidateTriangle("third side");
                        Console.WriteLine(TriangleSolver.Analyze(a, b, c));
                    }
                } 
            Console.WriteLine();
             int.Parse(inputValue);      
        }
        public static int AnalyzeInputValue(string side)
        {
            int value = 1;
            bool isValid = false;
            while(isValid==false)
            {
                Console.WriteLine($" please enter the {side} of the triangle:");
                string inputValue = Console.ReadLine();
                Console.WriteLine();
                
                bool result = int.TryParse(inputValue, out value);
                if (result == false)
                {
                    Console.WriteLine("That is not a valid input, please try again:\n");
                }
                else if (value < 0)
                {
                    Console.WriteLine("Number should not be less than zero, please try again:\n");
                }
                else
                {
                    isValid = true;
                    Console.WriteLine($"The {side} of your triangle is now:{value}\n");
                }
            }
            return value;
        }
        public static void Main (string[] args)

        {
            Menu();
           

        }
    }
 }
      
    

