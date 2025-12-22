using System;
// Design a multiplication table of a number given by the user from 6 to 9
class MultiplicationTable
{
	static void Main()
	{
		Console.WriteLine("Give any number to calculate the multiplication table : ");		// Input any number from the user
		int num = int.Parse(Console.ReadLine());
		for(int loop = 6 ; loop <= 9 ; loop++)							// Initiate a loop to design multiplication table
		{
			Console.WriteLine(num+" * "+loop+" = "+(num*loop));
		}
	}
}