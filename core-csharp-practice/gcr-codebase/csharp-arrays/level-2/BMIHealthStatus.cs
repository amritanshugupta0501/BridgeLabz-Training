using System;
// Calculate BMI of A person and display their health status
class BMIHealthStatus
{
	static void Main()
	{
		Console.WriteLine("Give the number of persons : ");						// Input number of persons from the user
		int persons = int.Parse(Console.ReadLine());
		for(int loop = 1; loop <= persons ; loop++)							// Initiate a loop to get details of every person
		{
			Console.WriteLine("Give the height(in cm) and weight(in kg) of every person : ");	// Input weight and height of the person from the user
			double[] healthDetails = new double[3];
			healthDetails[0] = double.Parse(Console.ReadLine());
			healthDetails[1] = double.Parse(Console.ReadLine());
			healthDetails[0] = healthDetails[0]/100;
			healthDetails[2] = healthDetails[1]/(healthDetails[0]*healthDetails[0]);		// BMI of person = weight/(height^2)
			if(healthDetails[2] <= 18.4)								// Displaying the health status of the person
			{
				Console.WriteLine("BMI of the person : "+healthDetails[2]+"\nHealth Status : Underweight");
			}
			else if(healthDetails[2] >= 18.5 || healthDetails[2] <= 24.9)
			{
				Console.WriteLine("BMI of the person : "+healthDetails[2]+"\nHealth Status : Normal");
			}
			else if(healthDetails[2] >= 25.0 || healthDetails[2] <= 39.9)
			{
				Console.WriteLine("BMI of the person : "+healthDetails[2]+"\nHealth Status : Overweight");
			}
			else
			{
				Console.WriteLine("BMI of the person : "+healthDetails[2]+"\nHealth Status : Obese");
			}
		}
	}
}