using System;
// Check if a number is Harshad Number or not
// A Harshad number : an integer which is divisible by the sum of its digits.
class HarshadNumber
{
	static void Main()
	{
		Console.WriteLine("Give a number : ");					// Input a number from the user
		int num = int.Parse(Console.ReadLine());
		int sum = 0;
		int loop = num;								// Initiate a loop to find sum of digits
		while(loop > 0)
		{
			int mod = loop % 10;
			sum += mod;
			loop = loop / 10;
		}
		if(num % sum == 0)							// Check if the number is divisible by the sum
		{
			Console.WriteLine("The number "+num+" is a Harshad Number");
		}
		else
		{
			Console.WriteLine("The number "+num+" is not a Harshad Number");
		}
	}
}