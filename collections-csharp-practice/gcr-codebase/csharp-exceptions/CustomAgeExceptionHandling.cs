using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.exceptions
{
    // Class Defined to make a custom exception 
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message):base(message) { }
    }
    // Class defined to handle a custom exception i.e. Age should be 18 or above
    internal class CustomAgeExceptionHandling
    {
        void ValidateAge(int age)
        {
            if(age < 18)
            {
                throw new InvalidAgeException("Access : Denied. Age must be 18 or above.");
            }
            else
            {
                Console.WriteLine("Access : Granted");
            }
        }
        static void Main(string[] args)
        {
            CustomAgeExceptionHandling customAgeException = new CustomAgeExceptionHandling();
            try
            {
                Console.WriteLine("Give the age of the person : ");
                int age = int.Parse(Console.ReadLine());
                customAgeException.ValidateAge(age);
            }
            catch(InvalidAgeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch(FormatException)
            {
                Console.WriteLine("Input age is invalid.");
            }
        }
    }
}
