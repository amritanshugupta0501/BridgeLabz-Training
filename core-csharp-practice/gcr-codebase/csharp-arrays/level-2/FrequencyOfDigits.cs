using System;
// Counting the frequency of every digit in the number
class FrequencyOfDigits
{
	static void Main()
	{
		Console.WriteLine("Give a Number : ");						// Input a number from the user
		int number = int.Parse(Console.ReadLine());
		int count = 0;
		int loop = number;								// Initiate a loop to count digits of the number
		while(loop > 0)
		{
			count++;
			loop /= 10;
		}
		int[] digits = new int[count];
		int position = 0;
		loop = number;									// Initiate a loop to extract digits from the number
		while(loop > 0)
		{
			digits[position] = loop % 10;
			loop /= 10;
			position++;
		}
		for(loop = 0; loop < 10; loop++)						// Initialize a loop to count the frequency of the digits
		{
			int counter = 0;
			for(int pos = 0; pos < digits.Length; pos++)
			{
				if(loop == digits[pos])
				{
					counter++;
				}
			}
			if(counter != 0)
			{
				Console.WriteLine("The count of the digit "+loop+" in the number "+number+" is : "+counter);
			}
		}
	}
}