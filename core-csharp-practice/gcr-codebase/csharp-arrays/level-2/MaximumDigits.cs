using System;
// Find the largest and second largest digits in a number
class MaximumDigits
{
	static void Main()
	{
		Console.WriteLine("Give a number : ");						// Input a number from the user
		int number = int.Parse(Console.ReadLine());
		int maxDigits = 10;
		int[] digits = new int[maxDigits];
		int position = 0;
		int duplicate = number;
		while(duplicate > 0)								// Initiate a loop to extract digits from the number
		{
			if(position == maxDigits)						// Check if the maximum digits have increased or not
			{
				maxDigits += 10;
				int[] temp = new int[maxDigits];
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
		int largest = digits[0];
		int secondLargest = digits[0];
		for(int loop = 1 ; loop < position ; loop++)					// Initiate a loop to find the largest and second largest digits
		{
			if(digits[loop] > largest)
			{
				largest = digits[loop];
				secondLargest = largest;
			}
		}
		Console.WriteLine("Largest digit of the number "+number+" : "+largest);
		Console.WriteLine("Second Largest digit of the number "+number+" : "+secondLargest);
	}
}