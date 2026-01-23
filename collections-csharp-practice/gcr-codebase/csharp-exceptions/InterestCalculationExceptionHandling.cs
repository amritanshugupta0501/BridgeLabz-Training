using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.exceptions
{
    // Class defined to handle any exception during calculation of simple interest
    internal class InterestCalculationExceptionHandling
    {
        double CalculateInterest(double amount, double rate, int years)
        {
            if(amount < 0 || rate < 0)
            {
                throw new ArgumentException("The values must be positive");
            }
            return (amount * rate*years)/100;
        }
        static void Main(string[] args)
        {
            InterestCalculationExceptionHandling interestExceptionHandling= new InterestCalculationExceptionHandling();
            try
            {
                Console.WriteLine("Give Principal Amount , Rate of Interest, Time of interest : ");
                double amount = double.Parse(Console.ReadLine());
                double rateOfInterest = double.Parse(Console.ReadLine());
                int years = int.Parse(Console.ReadLine());
                double interest = interestExceptionHandling.CalculateInterest(amount, rateOfInterest, years);
                Console.WriteLine("Simple Interest : " + interest);
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
