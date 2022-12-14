using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    class Program
    {
        private static int a;

        static void Main(string[] args)
        {
            Console.Write("Enter The First Number: ");
            int a = Convert.ToInt32(Console.ReadLine());   
            Console.Write("Enter The Second Number: ");
            int b = Convert .ToInt32(Console.ReadLine());
            int Add = a + b;
            Console.WriteLine("Total Number Of After Adding: "+Add);
            int Subtract = a - b;
            Console.WriteLine("Total Number Of After Subtract: "+Subtract);
            int c = Mupliply(a, b);
            Console.ReadLine();
        
        }

        private static int Mupliply(int a, int b)

        {
            return (a * b);
        }
    }
}

// Step Into - Debugger executes the program statement by statement, The debugger will execute the function body if the statement is a function call.
// Step Over - 