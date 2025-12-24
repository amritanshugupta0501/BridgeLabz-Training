using System;
// Find the largest and second largest digits in a number
class MaximumDigits
{
	static void Main()
	{
		Console.WriteLine("Give a number : ");						// Input a number from the user
		long number = long.Parse(Console.ReadLine());
		int maxDigits = 10;
		long[] digits = new long[maxDigits];
		int position = 0;
		long duplicate = number;
		while(duplicate > 0)								// Initiate a loop to extract digits from the number
		{
			if(position == maxDigits)						// Check if the maximum digits have increased or not
			{
				maxDigits += 10;
				long[] temp = new long[maxDigits];
				for(int loop = 0; loop < digits.Length; loop++)			// Initiate a loop to check maximum digits		
				{
					temp[loop] = digits[loop];
				}
				digits = temp;
				Console.WriteLine("Array resized to "+maxDigits);
			}
			digits[position] = duplicate % 10;
			position++;
			duplicate /= 10; 
		}
		long largest = -1;
		long secondLargest = -1;
		for(int loop = 0 ; loop < position ; loop++)					// Initiate a loop to find the largest and second largest digits
		{

			if(largest < digits[loop])
			{
				secondLargest = largest;
				largest = digits[loop];
			}
		}
		Console.WriteLine("Largest digit of the number "+number+" : "+largest);
		Console.WriteLine("Second Largest digit of the number "+number+" : "+secondLargest);
	}
}