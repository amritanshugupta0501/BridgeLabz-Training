using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_collections.assignment.regex
{
    internal class SSNValidator
    {
        public static bool Validate(string input)
        {
            return Regex.IsMatch(input, @"^\d{3}-\d{2}-\d{4}$");
        }
    }
}
