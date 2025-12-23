using System;
// Compute BMI of a person based on their height and weight
class HealthStatus
{
	static void Main()
	{
		Console.WriteLine("Give the number of students : ");									// Input number of students from the user
		int patients = int.Parse(Console.ReadLine());
		double[,] healthInformation = new double[patients,3];
		string[] status = new string[patients];
		for(int loop = 0; loop < patients; loop++)
		{
			Console.WriteLine("Give the height(in cm) and weight(in kg) of the person "+loop+" :");				// Input weight and height from the user
			healthInformation[loop,0] = double.Parse(Console.ReadLine());
			healthInformation[loop,1] = double.Parse(Console.ReadLine());
			healthInformation[loop,0] = healthInformation[loop,0]/100;							// 1 metre = 100 centimetre
			healthInformation[loop,2] = healthInformation[loop,1]/(healthInformation[loop,0]*healthInformation[loop,0]);	// BMI of person=weight/height^2
			if(healthInformation[loop,2] <= 18.4)										// Checking the health status of a person
			{
				status[loop] = "Underweight";
			}
			else if(healthInformation[loop,2] >= 18.5 || healthInformation[loop,2] <= 24.9)							
			{
				status[loop] = "Normal";
			}
			else if(healthInformation[loop,2] >= 18.5 || healthInformation[loop,2] <= 24.9)							
			{
				status[loop] = "Normal";
			}
			else if(healthInformation[loop,2] >= 25.0 || healthInformation[loop,2] <= 39.9)							
			{
				status[loop] = "Overweight";
			}
			else
			{
				status[loop] = "Obese";
			}
		}
		for(int loop = 0; loop < patients ; loop++)
		{
			Console.WriteLine("BMI of the person : "+healthInformation[loop,2]+"\nHealth Status : "+status[loop]);
		}
	}
}