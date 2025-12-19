using System;
// Computing distance of a journey through cities
class DistanceOfJourney
{
	static void Main()
	{
		Console.WriteLine("Give the name of the person : ");			   // Input the name of the person who is on the journey from the user
		String name = Console.ReadLine();
		Console.WriteLine("Give the name of the cities throughout the journey : ");// Input the name of the cities from the user
		String city_From = Console.ReadLine();
		String via_City = Console.ReadLine();
		String to_City = Console.ReadLine();
		Console.WriteLine("Give the distances in between the cities : ");	   // Input the distances in between the cities
		double city_From_To_Via = double.Parse(Console.ReadLine());
		double city_Via_To_Final = double.Parse(Console.ReadLine());
		Console.WriteLine("Give the time taken throughout the journey (in hrs): ");// Input the time taken throughout the journey from city to city
		double time_From_To_Via = double.Parse(Console.ReadLine());
		double time_Via_To_Final = double.Parse(Console.ReadLine());
		
		double total_Distance_Taken = city_From_To_Via + city_Via_To_Final;	    // Compute total distance of the journey
		double total_Time_Taken = time_From_To_Via + time_Via_To_Final;		    // Compute total time of the journey

		Console.WriteLine("The total distance travelled  by "+name+" from "+city_From+" to "+to_City+" via "+via_City+" is "+total_Distance_Taken+"km and the Total Time taken is "+total_Time_Taken+" hrs");
	}
}