using System;
// Determing the BMI and health status of a person
class BMIOfAPerson
{
	static void Main()
	{
		Console.WriteLine("Give the weight(in kg) and height(in cm) of a person : ");			// Input weight and height from the user
		double weight = double.Parse(Console.ReadLine());
		double height = double.Parse(Console.ReadLine());
		height = height/100;										// Convert height in cm to m : "1m = 100cm"
		double bmiOfPerson = weight / (height*height);							// BMI = weight / (height * height)
		if(bmiOfPerson <= 18.4)										// Displaying the health status of the person
		{
			Console.WriteLine("BMI of the person : "+bmiOfPerson+"\nHealth Status : Underweight");
		}
		else if(bmiOfPerson >= 18.5 || bmiOfPerson <= 24.9)
		{
			Console.WriteLine("BMI of the person : "+bmiOfPerson+"\nHealth Status : Normal");
		}
		else if(bmiOfPerson >= 25.0 || bmiOfPerson <= 39.9)
		{
			Console.WriteLine("BMI of the person : "+bmiOfPerson+"\nHealth Status : Overweight");
		}
		else
		{
			Console.WriteLine("BMI of the person : "+bmiOfPerson+"\nHealth Status : Obese");
		}
	}
}