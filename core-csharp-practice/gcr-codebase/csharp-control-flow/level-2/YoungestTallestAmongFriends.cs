using System;
// Find the youngest and the tallest among three friends
class YoungestTallestAmongFriends
{
	static void Main()
	{
		Console.WriteLine("Give the age and height of Amar : ");				// Input age and height of Amar
		int ageOfAmar = int.Parse(Console.ReadLine());
		double heightOfAmar = double.Parse(Console.ReadLine());					
		Console.WriteLine("Give the age and height of Akbar : ");				// Input age and height of Akbar
		int ageOfAkbar = int.Parse(Console.ReadLine());
		double heightOfAkbar = double.Parse(Console.ReadLine());
		Console.WriteLine("Give the age and height of Anthony : ");				// Input age and height of Anthony
		int ageOfAnthony = int.Parse(Console.ReadLine());
		double heightOfAnthony = double.Parse(Console.ReadLine());
		String youngest = (ageOfAmar < ageOfAkbar) ? ((ageOfAmar < ageOfAnthony) ? "Amar" : "Anthony") : (ageOfAkbar < ageOfAnthony) ? "Akbar" : "Anthony";												// Condition to find the youngest friend
		String tallest = (heightOfAmar > heightOfAkbar) ? ((heightOfAmar > heightOfAnthony) ? "Amar" : "Anthony") : (heightOfAkbar > heightOfAnthony) ? "Akbar" : "Anthony";									// Condition to find the tallest friend
		Console.WriteLine("The youngest friend among Amar, Akbar, Anthony : "+youngest);
		Console.WriteLine("The tallest friend among Amar, Akbar, Anthony : "+tallest);
	}
}