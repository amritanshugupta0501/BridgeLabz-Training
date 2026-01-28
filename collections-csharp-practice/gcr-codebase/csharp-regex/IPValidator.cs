using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_collections.assignment.regex
{
    internal interface IPValidator
    {
        public static bool Validate(string input)
        {
            string pattern =
                @"^(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)"
              + @"(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}$";

            return Regex.IsMatch(input, pattern);
        }
    }
}
