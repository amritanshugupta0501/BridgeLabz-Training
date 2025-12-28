using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.strings.level1
{
    internal class IndexOutOfRange
    {
        static void Main()
        {
            string str = "Hello";
            try
            {
                Console.WriteLine("Character at 20the position : " + str[19]);
            }
            catch (IndexOutOfRangeException ex)
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
