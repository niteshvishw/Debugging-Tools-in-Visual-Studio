using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    class Program
    {
/*
        // Autos Window - Autos window show all variables used in current line and pervious line.
        // Locals Window - Locals window shows all local variables in the current scope.
        void Autolocals()
        {
            int a, b, c, d, e;
            a = 10;
            b = 20;
            c = 30;
            d = 40;
            e = 50;
        }

 */
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
// Step Over - Step Overit do not show the details execution of a function.
// Step Out - If the debugger is wittin a nested scope this action proceeds until the function returns.

// BreakPoint - Breakpoint is a feature provided by the debugger that allows breaking execution of code at runtime when debugging applications.
// breakpoint is a place to purposely pause or suspend debugger execution.

