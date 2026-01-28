using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_collections.assignment.regex
{
    internal class SpaceNormalizer
    {
        public static string Normalize(string input)
        {
            return Regex.Replace(input, @"\s+", " ");
        }
    }
}
