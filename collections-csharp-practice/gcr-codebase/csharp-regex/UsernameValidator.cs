using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_collections.assignment.regex
{
    internal class UsernameValidator
    {
        public static bool Validate(string input)
        {
            return Regex.IsMatch(input, @"^[A-Za-z][A-Za-z0-9_]{4,14}$");
        }
    }
}
