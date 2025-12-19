using System;
// Compute course fee of a student based on university discount
class UniversityFee
{
	static void Main()
	{
		int discount_Percentage = 10;
		int course_Fee = 125000;
		int discount = (discount_Percentage*125000)/100; 			// Calculate discount on the student fee
		int discounted_Fee = course_Fee-discount;				// Calculate amount of fees to be paid to the university
		Console.WriteLine("The discount amount is INR "+discount+" and the discounted fee is INR "+discounted_Fee);
	}
}	