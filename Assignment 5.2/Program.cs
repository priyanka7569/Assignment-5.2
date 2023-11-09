using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 3: Fibonacci sequence
            Console.WriteLine("\nPart 3: Fibonacci Sequence");

            int n = 10;
            int a = 0, b = 1;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a + " ");
                int temp = a;
                a = b;
                b = temp + b;
            }
            Console.ReadKey();
        }
    }
}
