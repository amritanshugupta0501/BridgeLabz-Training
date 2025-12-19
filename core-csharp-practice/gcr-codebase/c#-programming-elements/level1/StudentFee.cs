using System;
// Calculate the student's university fees based on discount
class StudentFee
{
	static void Main()
	{
		Console.WriteLine("Give Student's Fee and University Discount percentage for the course : ");	// Input student's fee and university discount
		double student_Fee = double.Parse(Console.ReadLine());
		double discount_Percentage = double.Parse(Console.ReadLine());
		double discount = (discount_Percentage*student_Fee)/100;					// discount=discount percentage*studentfee/100
		double discounted_Fee = student_Fee-discount;							// calculating the student's discounted fees
		Console.WriteLine("The discount amount is INR "+discount+" and the final discounted fee is INR "+discounted_Fee);
	}
}