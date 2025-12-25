using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level1
{
    internal class SimpleInterestCalculation
    {
        double SimpleInterest(double amount, double time, double interestRate)
        {
            double simpleInterest = (amount * time * interestRate)/100;
            return simpleInterest;
        }
        static void Main()
        {
            Console.WriteLine("Give principal amount, time, rate of interest : ");
            double principalAmount = double.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());
            double rateOfInterest = double.Parse(Console.ReadLine());
            SimpleInterestCalculation obj = new SimpleInterestCalculation();
            double simpleInterest = obj.SimpleInterest(principalAmount, time, rateOfInterest);
            Console.WriteLine("The Simple Interest is "+simpleInterest+" for Principal "+principalAmount+", Rate of Interest "+rateOfInterest+" and Time "+time);
        }
    }
}
