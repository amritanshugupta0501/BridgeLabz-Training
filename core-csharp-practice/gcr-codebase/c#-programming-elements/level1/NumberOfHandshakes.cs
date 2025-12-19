using System;
// Calculate number of handshakes
class NumberOfHandshakes
{
	static void Main()
	{
		Console.WriteLine("Give the number of students : ");	// Read the number of students from user
		int n = int.Parse(Console.ReadLine());
		int maximum_Handshakes = (n*(n-1))/2;			// using formula (n*(n-1)/2)
		Console.WriteLine("The maximum of number of handshakes for "+n+" students is "+maximum_Handshakes);
	}
}