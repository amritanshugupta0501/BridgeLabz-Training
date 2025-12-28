using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.strings.level1
{
    internal class IndexOutOfBounds
    {
        static void Main()
        {
            int[] arr = new int[] {1,2,3,4,5};
            try
            {
                Console.WriteLine("Element at 10th Position : " + arr[10]);
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
