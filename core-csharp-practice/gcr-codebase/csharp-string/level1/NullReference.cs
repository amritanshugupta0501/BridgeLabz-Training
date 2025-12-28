using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.strings.level1
{
    internal class NullReference
    {
        static void Main()
        {
            string str = null;
            try
            {
                int length = str.Length;
                Console.WriteLine("Length of the string : "+length);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.ToString() + " occured");
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.ToString() + " occured");
            }
        }
    }
}
