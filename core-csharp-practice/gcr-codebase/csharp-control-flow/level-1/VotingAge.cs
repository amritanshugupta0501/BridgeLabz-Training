using System;
// Check whether a person can vote or not depending on their age
class VotingAge
{
	static void Main()
	{
		Console.WriteLine("Give the person's age : ");				// Input person's age from the user
		int ageOfPerson = int.Parse(Console.ReadLine());
		if(ageOfPerson >= 18)							// Check if the person is greater than or equal to 18
		{
			Console.WriteLine("The person's age is "+ageOfPerson+" and can vote.");
		}
		else
		{
			Console.WriteLine("The person's age is "+ageOfPerson+" and cannot vote.");
		}
	}
}