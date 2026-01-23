using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.exceptions
{
    // Class defined to depict propagation between method and handling exception simultaneously
    internal class ExceptionMethodPropagation
    {
        void Method1()
        {
            Console.WriteLine("Method 1 called");
            int a = 10, b = 0;
            int result = a / b;
            Console.WriteLine("Result of division : " + result);
        }
        void Method2()
        {
            Console.WriteLine("Method 2 Initiated");
            Method1();
        }
        static void Main(string[] args)
        {
            ExceptionMethodPropagation methodPropagation = new ExceptionMethodPropagation();
            try
            {
                Console.WriteLine("Main Method");
                methodPropagation.Method2();
            }
            catch (ArithmeticException exception)
            {
                Console.WriteLine("Handled exception in Main.");
            }
        }
    }
}
