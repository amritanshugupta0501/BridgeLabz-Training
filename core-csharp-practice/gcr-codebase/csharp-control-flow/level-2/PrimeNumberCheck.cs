using System;
// Check whether a given number is prime number or not
class PrimeNumberCheck
{
	static void Main()
	{
		Console.WriteLine("Give a number to check if it is prime or not : ");			// Input a number from the user
		int num = int.Parse(Console.ReadLine());
		int checkCount = 0;
		for(int loop =  2 ; loop < num ; loop++)
		{
			if(num % loop == 0)
			{
				checkCount++;
				break;
			}
		}
		if(checkCount == 0)
		{
			Console.WriteLine("The number "+num+" is a Prime number");
		}
		else
		{
			Console.WriteLine("The number "+num+" is not a Prime number");
		}
	}
}