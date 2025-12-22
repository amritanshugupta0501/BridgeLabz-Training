using System;
// Check if a number is Armstrong Number or not
// Armstrong Number : A number whose Sum of cubes of each digit results in the original number
class ArmstrongNumber
{
	static void Main()
	{
		Console.WriteLine("Give a number to check if its Armstrong or not : ");		// Input a number from the user
		int num = int.Parse(Console.ReadLine());				
		int loop = num;									
		int sum = 0;
		while(loop > 0)									// Initiate a loop to extract digits
		{
			int mod = loop % 10;							// Extraction of digits from the number
			sum = sum+(mod*mod*mod);						// Cubing the digits and adding the result
			loop = loop / 10; 
		}
		if(sum == num)									// Checking if the sum and number are equal
		{
			Console.WriteLine("The number "+num+" is an Armstrong number.");
		}
		else
		{
			Console.WriteLine("The number "+num+" is not an Armstrong number.");
		}
	}
}