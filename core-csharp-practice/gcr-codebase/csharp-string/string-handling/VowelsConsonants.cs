using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.strings.extraproblems
{
    internal class VowelsConsonants
    {
        static void Main()
        {
            Console.WriteLine("Give a text : ");
            string text = Console.ReadLine();
            int vowels = 0, consonants = 0; ;
            text = text.ToLower();
            for (int loop = 0; loop < text.Length; loop++) 
            {
                if (text[loop] >= 'a' && text[loop] <= 'z')
                {
                    switch (text[loop])
                    {
                        case 'a':
                            {
                                vowels++;
                                break;
                            }
                        case 'e':
                            {
                                vowels++;
                                break;
                            }
                        case 'i':
                            {
                                vowels++;
                                break;
                            }
                        case 'o':
                            {
                                vowels++;
                                break;
                            }
                        case 'u':
                            {
                                vowels++;
                                break;
                            }
                        default:
                            {
                                consonants++;
                                break;
                            }

                    }
                }
            }
            Console.WriteLine("Number of vowels in the text : "+vowels);
            Console.WriteLine("Number of consonants in the text : "+consonants);
        }
    }
}
