using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_collections.assignment.regex
{
    internal class BadWordCensor
    {
        public static string Censor(string text, string[] badWords)
        {
            foreach (string word in badWords)
            {
                text = Regex.Replace(text, $@"\b{word}\b", "****", RegexOptions.IgnoreCase);
            }
            return text;
        }
    }
}
