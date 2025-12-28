using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.strings.level1
{
    internal class ArgumentOutOfRange
    {
        static void Main()
        {
            string str = "Hello";
            try
            {
                string newStr = str.Substring(0,10);
                Console.WriteLine("The substring is "+newStr);
            }
            catch (ArgumentOutOfRangeException ex)
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
