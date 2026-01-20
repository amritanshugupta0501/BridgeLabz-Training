using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.PasswordCrackSimulation
{
    internal class PasswordCrackerSystem
    {
        static char[] charSet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        static long attemptCounter = 0;
        public static void Main()
        {
            PasswordCrackerSystem passwordCrackerSystem = new PasswordCrackerSystem();
            Console.WriteLine("Password Vault Simulator");
            Console.Write("Enter desired password length to simulate: ");
            int length = int.Parse(Console.ReadLine());
            string secretPassword = passwordCrackerSystem.GenerateRandomPassword(length);
            Console.WriteLine($" Password length: {length}");
            Console.WriteLine($" Password is: {secretPassword}");
            bool success = passwordCrackerSystem.CrackPassword(new char[length], 0, length, secretPassword);
            if (success)
            {
                Console.WriteLine($"[SUCCESS] Password Cracked!");
                Console.WriteLine($"Password Found: {secretPassword}");
                Console.WriteLine($"Total Attempts: {attemptCounter:N0}");
            }
        }
        string GenerateRandomPassword(int length)
        {
            Random rnd = new Random();
            char[] password = new char[length];
            for (int i = 0; i < length; i++)
            {
                int randomIndex = rnd.Next(charSet.Length);
                password[i] = charSet[randomIndex];
            }
            return new string(password);
        }
        bool CrackPassword(char[] currentGuess, int index, int length, string target)
        {
            if (index == length)
            {
                attemptCounter++;
                string guessString = new string(currentGuess);
                if (guessString == target)
                {
                    return true;
                }
                return false;
            }
            for (int i = 0; i < charSet.Length; i++)
            {
                currentGuess[index] = charSet[i];
                if (CrackPassword(currentGuess, index + 1, length, target))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
