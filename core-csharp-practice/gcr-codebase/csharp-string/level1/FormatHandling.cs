using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.strings.level1
{
    internal class FormatHandling
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Give a text : ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("The string is " + num);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
