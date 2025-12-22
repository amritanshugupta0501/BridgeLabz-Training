using System;
// Count down for a rocket launch 
class CountDownForRocketLaunch
{
	static void Main()
	{
		Console.WriteLine("Give any number to start count down : ");			// Input a number from the user
		int countdown = int.Parse(Console.ReadLine());
		while(countdown > 0)								// While loop to start the launch for a rocket
		{
			Console.WriteLine("Time remaining to launch the rocket : "+countdown);
			countdown-=1;
		}
	}
}