using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_collections.assignment.regex
{
    internal class LanguageExtractor
    {
        public static void Extract(string text)
        {
            var matches = Regex.Matches(text, @"\b(JavaScript|Java|Python|Go)\b");
            foreach (Match m in matches)
                Console.WriteLine(m.Value);
        }
    }
}
