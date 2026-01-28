using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_collections.assignment.regex
{
    internal class MainRegex
    {
        static void Main(string[] args)
        {
            // 1. Validate Username
            // Must start with a letter, contain letters/numbers/underscore, length 5–15
            Console.WriteLine(UsernameValidator.Validate("user_123"));   // Valid
            Console.WriteLine(UsernameValidator.Validate("123user"));    // Invalid
            Console.WriteLine(UsernameValidator.Validate("us"));         // Invalid

            // 2. Validate License Plate Number
            // Format: Two uppercase letters followed by four digits
            Console.WriteLine(LicensePlateValidator.Validate("AB1234")); // Valid

            // 3. Validate Hex Color Code
            // Format: # followed by 6 hexadecimal characters
            Console.WriteLine(HexColorValidator.Validate("#FFA500"));    // Valid

            // 4. Extract Email Addresses from text
            // Finds all valid email patterns in a given string
            EmailExtractor.Extract(
                "Contact us at support@example.com and info@company.org"
            );

            // 5. Extract Capitalized Words
            // Words starting with uppercase letters
            CapitalizedWordExtractor.Extract(
                "The Eiffel Tower is in Paris and the Statue of Liberty is in New York."
            );

            // 6. Extract Dates in dd/mm/yyyy format
            DateExtractor.Extract(
                "The events are scheduled for 12/05/2023, 15/08/2024."
            );

            // 7. Extract Web Links (HTTP / HTTPS)
            LinkExtractor.Extract(
                "Visit https://www.google.com and http://example.org for more info."
            );

            // 8. Replace multiple spaces with a single space
            Console.WriteLine(
                SpaceNormalizer.Normalize("This   is   an   example")
            );

            // 9. Censor bad words using regex
            Console.WriteLine(
                BadWordCensor.Censor(
                    "This is a damn stupid example",
                    new string[] { "damn", "stupid" }
                )
            );

            // 10. Validate IPv4 Address
            Console.WriteLine(IPValidator.Validate("192.168.1.1"));      // Valid
            Console.WriteLine(IPValidator.Validate("999.1.1.1"));        // Invalid

            // 11. Validate Credit Card Number
            // Visa starts with 4, MasterCard starts with 5 (16 digits)
            Console.WriteLine(
                CreditCardValidator.Validate("4123456789012345")
            );

            // 12. Extract Programming Language Names
            LanguageExtractor.Extract(
                "I love Java, Python, JavaScript, and Go"
            );

            // 13. Extract Currency Values
            CurrencyExtractor.Extract(
                "The price is $45.99 and the discount is $ 10.50"
            );

            // 14. Find Repeating Words in a sentence
            RepeatingWordFinder.Find(
                "This is is a repeated repeated word test."
            );

            // 15. Validate Social Security Number (SSN)
            Console.WriteLine(
                SSNValidator.Validate("123-45-6789")
            ); // Valid
        }
    }
}
