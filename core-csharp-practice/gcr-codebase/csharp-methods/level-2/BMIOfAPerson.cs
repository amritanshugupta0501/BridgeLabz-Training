using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level2
{
    internal class BMIOfAPerson
    {
        double CalculateBMI(double height, double weight)
        {
            double BMI = weight / (height * height);
            return BMI;
        }
        void DisplayHealthStatus(double bmiOfPerson)
        {
            if (bmiOfPerson <= 18.4)                                        // Displaying the health status of the person
            {
                Console.WriteLine("BMI of the person : " + bmiOfPerson + "\tHealth Status : Underweight");
            }
            else if (bmiOfPerson >= 18.5 || bmiOfPerson <= 24.9)
            {
                Console.WriteLine("BMI of the person : " + bmiOfPerson + "\tHealth Status : Normal");
            }
            else if (bmiOfPerson >= 25.0 || bmiOfPerson <= 39.9)
            {
                Console.WriteLine("BMI of the person : " + bmiOfPerson + "\tHealth Status : Overweight");
            }
            else
            {
                Console.WriteLine("BMI of the person : " + bmiOfPerson + "\tHealth Status : Obese");
            }
        }
        static void Main()
        {
            BMIOfAPerson bMI = new BMIOfAPerson();
            double[,] healthStatus = new double[10, 3];
            for(int loop = 0; loop < 10; loop++)
            {
                Console.WriteLine("Give height(in cm) and weight(in kg) of person "+loop+" :");
                healthStatus[loop,0] = double.Parse(Console.ReadLine());
                healthStatus[loop,1] = double.Parse(Console.ReadLine());
                healthStatus[loop, 0] = healthStatus[loop, 0] / 100;
                healthStatus[loop,2] = bMI.CalculateBMI(healthStatus[loop,0],healthStatus[loop,1]);
            }
            for(int loop = 0;loop < 10; loop++)
            {
                bMI.DisplayHealthStatus(healthStatus[loop, 2]);
            }
        }
    }
}
