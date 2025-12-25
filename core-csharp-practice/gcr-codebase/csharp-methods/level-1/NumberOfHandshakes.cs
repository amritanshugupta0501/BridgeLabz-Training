using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level1
{
    internal class NumberOfHandshakes
    {
        int HandshakesCombinations(int numStudents)
        {
            return (numStudents * (numStudents - 1))/2;
        }
        static void Main()
        {
            Console.WriteLine("Give any number of students : ");
            int studentNumber = int.Parse(Console.ReadLine());
            int handshakesCombination = new NumberOfHandshakes().HandshakesCombinations(studentNumber);
            Console.WriteLine("Maximum combinations of handshakes of " + studentNumber+ " students is " + handshakesCombination);
        }
    }
}
