using System;
// Compute profit percentage of a pre-defined selling price and cost price
class ProfitPercentage
{
	static void Main()
	{
		int cost_Price = 129;
		int selling_Price = 191;
		int profit = selling_Price-cost_Price;					// Profit = S.P. - C.P.
		int profit_Percentage = (profit/cost_Price)*100;			// Profit% = (Profit/C.P.)*100
		Console.WriteLine("The Cost Price is INR "+cost_Price+" and Selling Price is INR "+selling_Price+"\nThe Profit is INR "+profit+" and the Profit percentage is "+profit_Percentage);
	}
}
		