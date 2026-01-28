using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_collections.assignment.regex
{
    internal class CapitalizedWordExtractor
    {
        public static void Extract(string text)
        {
            var matches = Regex.Matches(text, @"\b[A-Z][a-z]*\b");
            foreach (Match m in matches)
                Console.WriteLine(m.Value);
        }
    }
}
