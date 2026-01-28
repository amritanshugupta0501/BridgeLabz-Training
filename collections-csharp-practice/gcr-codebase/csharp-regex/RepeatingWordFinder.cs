using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_collections.assignment.regex
{
    internal class RepeatingWordFinder
    {
        public static void Find(string text)
        {
            var matches = Regex.Matches(text, @"\b(\w+)\s+\1\b", RegexOptions.IgnoreCase);
            foreach (Match m in matches)
                Console.WriteLine(m.Groups[1].Value);
        }
    }
}
