using System;
// Compute total bill of a person
class TotalPriceOfItem
{
	static void Main()
	{
		Console.WriteLine("Give the price of one item and no. of items bought : ");	// Read unit price and total items bought from user
		double price_Of_Item = double.Parse(Console.ReadLine());
		double no_Of_Items = double.Parse(Console.ReadLine());
		double total_Bill = price_Of_Item * no_Of_Items;				// Calculate total bill using the information
		Console.WriteLine("The total purchase price is INR "+total_Bill+" if the quantity is "+no_Of_Items+" and unit price is INR "+price_Of_Item);
	}
}