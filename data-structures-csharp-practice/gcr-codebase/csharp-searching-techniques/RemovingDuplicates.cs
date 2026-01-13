using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.SearchingTechniques
{
    // Removing duplicates from a text using string builder
    internal class RemovingDuplicates
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give a text : ");
            string text = Console.ReadLine();
            StringBuilder duplicate = new StringBuilder(text);
            for (int innerLoop = 0; innerLoop < text.Length; innerLoop++)
            {
                bool isDuplicate = false;
                for (int outerLoop = 0; outerLoop < duplicate.Length; outerLoop++)
                {
                    if (duplicate[outerLoop] == text[innerLoop])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                {
                    duplicate.Append(text[innerLoop]);
                }
            }
            Console.WriteLine("Removing Duplicates : "+duplicate.ToString());
        }
    }
}
