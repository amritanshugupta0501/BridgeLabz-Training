using System;
// To initiate the countdown for a Rocket launch
class RocketLaunchCountDown
{
	static void Main()
	{
		Console.WriteLine("Give a number to start the countdown : ");			// Input a number from the user
		int countdown = int.Parse(Console.ReadLine());
		for(int loop = countdown ; countdown > 0 ; countdown--)				// For loop to initiate the countdown for rocket launch
		{
			Console.WriteLine("Time remaining to launch the rocket : "+countdown);	
		}
	}
}