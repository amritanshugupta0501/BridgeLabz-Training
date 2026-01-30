using System;
using System.Collections.Generic;
using System.Text;
namespace lexical_twist
{
    class LexicalTwist
    {
        static void Main(string[] args)
        {
            LexicalTwist game = new LexicalTwist();
            Console.Write("Enter text 1 : ");
            string text1 = Console.ReadLine();
            Console.Write("Enter text 2 : ");
            string text2 = Console.ReadLine();
            if (game.CheckReverse(text1, text2))
            {
                text1 = game.ReverseText(text1);
                text1 = text1.ToLower();
                game.Scenario1(text1);
            }
            else
            {
                game.Scenario2(text1, text2);
            }
        }
        bool CheckReverse(string text1, string text2)
        {
            StringBuilder text = new StringBuilder(text1);
            int left = 0;
            int right = text.Length - 1;
            while (left < right)
            {
                char change = text[left];
                text[left] = text[right];
                text[right] = change;
                left++;
                right--;
            }
            return text.ToString().Equals(text2);
        }
        string ReverseText(string text1)
        {
            StringBuilder text = new StringBuilder(text1);
            int left = 0;
            int right = text.Length - 1;
            while (left < right)
            {
                char change = text[left];
                text[left] = text[right];
                text[right] = change;
                left++;
                right--;
            }
            return text.ToString();
        }
        void Scenario1(string text)
        {
            StringBuilder textBuilder = new StringBuilder(text);
            for (int loop = 0; loop < text.Length; loop++)
            {
                char alphabet = text[loop];
                if (alphabet == 'a' || alphabet == 'e' || alphabet == 'o' || alphabet == 'i' || alphabet == 'u')
                {
                    textBuilder[loop] = '@';
                }
            }
            Console.WriteLine(textBuilder.ToString());
        }
        void Scenario2(string text1, string text2)
        {
            text1 = text1.ToUpper();
            text2 = text2.ToUpper();
            StringBuilder text = new StringBuilder(text1);
            text.Append(text2);
            int vowels = 0;
            int consonants = 0;
            foreach (char alphabet in text.ToString())
            {
                if (alphabet == 'A' || alphabet == 'E' || alphabet == 'O' || alphabet == 'I' || alphabet == 'U')
                {
                    vowels++;
                }
                else
                {
                    consonants++;
                }
            }
            if (vowels > consonants)
            {
                char alpha = ' ';
                int count = 0;
                foreach (char alphabet in text.ToString())
                {
                    if (alphabet == 'A' || alphabet == 'E' || alphabet == 'O' || alphabet == 'I' || alphabet == 'U' && alpha != alphabet)
                    {
                        alpha = alphabet;
                        count++;
                        Console.Write(alpha);
                        if(count==2)
                        {
                            return;
                        }
                    }
                }
                Console.WriteLine();
            }
            else if (vowels < consonants)
            {
                int count = 0;
                char alpha = ' ';
                foreach (char alphabet in text.ToString())
                {
                    if (!(alphabet == 'A' || alphabet == 'E' || alphabet == 'O' || alphabet == 'I' || alphabet == 'U') && alpha != alphabet)
                    {
                        alpha = alphabet;
                        count++;
                        Console.Write(alpha);
                        if (count == 2)
                        {
                            return;
                        }
                    }
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Vowels and Consonants are equal.");  
            }
        }
    }
}