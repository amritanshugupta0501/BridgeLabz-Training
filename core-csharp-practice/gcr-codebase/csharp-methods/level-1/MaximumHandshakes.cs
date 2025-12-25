using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level1
{
    internal class MaximumHandshakes
    {
        int NumberOfHandshakes(int students)
        {
            int handshakes = (students * (students - 1)) / 2;
            return handshakes;
        }
        static void Main()
        {
            Console.WriteLine("Give the number of students : ");
            int numberOfStudents = int.Parse(Console.ReadLine());
            MaximumHandshakes obj = new MaximumHandshakes();
            int handshakes = obj.NumberOfHandshakes(numberOfStudents);
            Console.WriteLine("Maximum number of handshakes of "+numberOfStudents+" students is "+handshakes);
        }
    }
}
