using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pascal_triangle
{
    class Program
    {
        public static float Factorial(int n)
            {
                float i, x = 1;
                for (i = 1; i <= n; i++)
                {
                    x *= i;
                }
                return x;
            }
        static void Main()
        {
            int i, n, c;
            Console.WriteLine("Enter the count strings of triangle:");
            string s = Console.ReadLine();
            n = Convert.ToInt32(s);

            for (i = 0; i < n; i++)
            {
                for (c = 0; c <= (n - i); c++) // create after all string n-i alter from left space of console, where string is lower, < alter 
                {
                    Console.Write(" ");
                }
                for (c = 0; c <= i; c++)
                {
                    Console.Write(" "); // create space after all elements 
                    Console.Write(Factorial(i) / (Factorial(c) * Factorial(i - c))); //formule of triangle 
                }
                Console.WriteLine();
                Console.WriteLine(); // after all strings with number - space 2 strings 
            }
            Console.ReadLine();
            
        }
    }
}
