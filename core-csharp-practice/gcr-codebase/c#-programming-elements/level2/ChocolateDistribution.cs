using System;
// Calculate the distribution of chocolates among children
class ChocolateDistribution
{
	static void Main()
	{
		Console.WriteLine("Give the number of chocolates and children : ");		// Input number of chocolates and children from user
		int no_Of_Chocolates = int.Parse(Console.ReadLine());
		int no_Of_Children = int.Parse(Console.ReadLine());
		int distributed_Chocolates = no_Of_Chocolates / no_Of_Children;			// Number of chocolates each children gets
		int non_Distributed_Chocolates = no_Of_Chocolates % no_Of_Children;		// Number of chocolates remaining after distribution
		Console.WriteLine("The number of chocolates each child gets is "+distributed_Chocolates+" and the number of remaining chocolates is "+non_Distributed_Chocolates); 
	}
}