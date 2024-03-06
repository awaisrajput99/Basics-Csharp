using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Basic input and Output
            Console.WriteLine("Hellow World");
            Console.WriteLine("My First C# Program");
            Console.ReadLine();

            // Data Types in C#
            int a = 10;     // Integer-->4bytes
            long b = 54;    // Long--> 8bytes
            float c = 35;   // floating points number-->4bytes
            double d = 24.32; //  Double--8bytes
            char E = 'a';    // For Characters-->2bytes
            String f = "Hope for the best"; //For String Values-->2bytes per chracter
            bool isGreat = true;   //For Boolean values true or false

            Console.WriteLine("It was a Great Learning");
            Console.ReadLine();

        }
    }
}
