using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level3
{
    internal class GenerateOTP
    {
        static void Main(string[] args)
        {
            int[] otpArray = new int[10];

            Console.WriteLine("Generating 10 OTPs...");

            for (int i = 0; i < otpArray.Length; i++)
            {
                otpArray[i] = OTPGeneration();
                Console.WriteLine("OTP "+(i + 1)+" : "+otpArray[i]);
            }

            bool isUnique = CheckUnique(otpArray);

            if (isUnique)
            {
                Console.WriteLine("Validation Success: All OTPs are unique.");
            }
            else
            {
                Console.WriteLine("Validation Failed: Duplicate OTPs found.");
            }

        }

        static int OTPGeneration()
        {
            Random random = new Random();
            return random.Next(100000, 1000000);
        }

        static bool CheckUnique(int[] otps)
        {
            for (int i = 0; i < otps.Length; i++)
            {
                for (int j = i + 1; j < otps.Length; j++)
                {
                    if (otps[i] == otps[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
