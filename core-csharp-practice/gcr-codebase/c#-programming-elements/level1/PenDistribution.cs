using System;
// Computing number of pens being distributed among students
class PenDistribution
{
	static void Main()
	{
		int total_Pens = 14;
		int total_Students = 3;
		int distributed_Pens = total_Pens/total_Students;  			// Calculating the amount of distributed pens
		int non_Distributed_Pens = total_Pens%total_Students;			// Calculating the amount of non-distributed pens
		Console.WriteLine("The Pen per Student is "+distributed_Pens+" and the remaining pens not distributed is "+non_Distributed_Pens);
	}
}