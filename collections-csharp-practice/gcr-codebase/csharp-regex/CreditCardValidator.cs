using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_collections.assignment.regex
{
    internal class CreditCardValidator
    {
        public static bool Validate(string input)
        {
            return Regex.IsMatch(input, @"^(4\d{15}|5\d{15})$");
        }
    }
}
