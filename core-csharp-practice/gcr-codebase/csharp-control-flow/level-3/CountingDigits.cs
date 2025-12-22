using System;
// Counting the digits of the given number
class CountingDigits
{
	static void Main()
	{
		Console.WriteLine("Give a number : ");						// Input a number from the user
		int num = int.Parse(Console.ReadLine());
		int counter = 0;								// Initiate counter to count digits
		int loop = num;									// Initiate a loop to count digits
		while(loop > 0)
		{
			counter++;
			loop = loop / 10;
		}
		Console.WriteLine("The number of digits in the number "+num+" : "+counter);
	}
}