using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.builtinfunction.level2
{
    internal class BasicCalculator
    {
        static void Main()
        {
            Console.WriteLine("Give two numbers to perform operation : ");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give the operator to perform the type of operation u want on operands : ");
            char operation = Console.ReadLine()[0];
            switch(operation)
            {
                case '+':
                    Console.WriteLine("Addition of "+number1+" and "+number2+" : "+Addition(number1,number2));
                    break;
                case '-':
                    Console.WriteLine("Subtraction of " + number1 + " and " + number2+" : " + Subtraction(number1, number2));
                    break;
                case '*':
                    Console.WriteLine("Multiplication of " + number1 + " and " + number2+" : " + Multiplication(number1, number2));
                    break;
                case '/':
                    Console.WriteLine("Division of " + number1 + " and " + number2+" : " + Division(number1, number2));
                    break;
                default:
                    Console.WriteLine("Invalid Operator.");
                    break;
            }
        }
        static int Addition(int number1, int number2)
        { 
            return number1 + number2;
        }
        static int Subtraction(int number1, int number2)
        {
            return number1 - number2;
        }
        static int Multiplication(int number1, int number2) 
        {
            return number1 * number2;
        }
        static double Division(double number1, double number2)
        {
            return (number1 / number2);
        }
    }
}
