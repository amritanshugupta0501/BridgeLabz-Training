using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.AadharNumbersSorter
{
    internal class AadharSortUtilityImpl : IAadharSortUtility
    {
        AadharInformation Head;
        static int CountUsers;
        static Random AadharNumber = new Random();
        public void AddPersonInSystem()
        {
            CountUsers++;
            AadharInformation aadharInformation = new AadharInformation();
            Console.WriteLine("Give Person's Details : ");
            aadharInformation.AadharNumber1 = AadharNumber.Next(10000000, 100000000);
            Console.Write("Person's Name : ");
            aadharInformation.PersonName1 = Console.ReadLine();
            Console.Write("Person's Address : ");
            aadharInformation.PersonAddress1 = Console.ReadLine();
            if (Head == null)
            {
                Head = aadharInformation;
                return;
            }
            AadharInformation currentAadhar = Head;
            while (currentAadhar.Next != null)
            {
                currentAadhar = currentAadhar.Next;
            }
            currentAadhar.Next = aadharInformation;
        }
        public void DisplayAadharInformation()
        {
            Console.WriteLine("Aadhar Information : ");
            AadharInformation currentAadhar = Head;
            while (currentAadhar != null)
            {
                Console.WriteLine(currentAadhar.ToString());
                Console.WriteLine();
                currentAadhar = currentAadhar.Next;
            }
        }
        public void AadharInformationSorting()
        {
            AadharInformation[] aadharUsers = new AadharInformation[CountUsers];
            int index = 0;
            AadharInformation currentAadhar = Head;
            while (currentAadhar != null)
            {
                aadharUsers[index++] = currentAadhar;
                currentAadhar = currentAadhar.Next;
            }
            long maximum = GetMaximum(aadharUsers);
            for (int loop = 1; maximum / loop > 0; loop *= 10)
            {
                aadharUsers = CountingSortNumber(aadharUsers, loop);
            }
            Head = null;
            for (int loop = 0; loop < CountUsers; loop++)
            {
                if (Head == null)
                {
                    Head = aadharUsers[loop];
                }
                else
                {
                    AadharInformation current = Head;
                    while (current.Next != null)
                    {
                        current = current.Next;
                    }
                    current.Next = aadharUsers[loop];
                    aadharUsers[loop].Next = null;
                }
            }
        }
        AadharInformation[] CountingSortNumber(AadharInformation[] aadharUsers, int exp)
        {
            AadharInformation[] aadharInformation = new AadharInformation[CountUsers];
            AadharInformation[,] aadharNumbers = new AadharInformation[10, CountUsers];
            for (int loop = 0; loop < CountUsers; loop++)
            {
                long digit = (aadharUsers[loop].AadharNumber1 / exp) % 10;
                for (int columnLoop = 0; columnLoop < CountUsers; columnLoop++)
                {
                    if (aadharNumbers[digit, columnLoop] == null)
                    {
                        aadharNumbers[digit, columnLoop] = aadharUsers[loop];
                        break;
                    }
                }
            }
            int index = 0;
            for (int rowsLoop = 0; rowsLoop < 10; rowsLoop++)
            {
                for (int columnLoop = 0; columnLoop < CountUsers; columnLoop++)
                {
                    if (aadharNumbers[rowsLoop, columnLoop] != null)
                    {
                        aadharInformation[index++] = aadharNumbers[rowsLoop, columnLoop];
                    }
                }
            }
            return aadharInformation;
        }
        long GetMaximum(AadharInformation[] aadharUsers)
        {
            long maximum = aadharUsers[0].AadharNumber1;
            for (int loop = 0; loop < CountUsers; loop++)
            {
                if (maximum < aadharUsers[loop].AadharNumber1)
                {
                    maximum = aadharUsers[loop].AadharNumber1;
                }
            }
            return maximum;
        }
        public void SearchUser()
        {
            Console.Write("Give the name you want to search for : ");
            string personName = Console.ReadLine();
            AadharInformationSorting();
            AadharInformation[] aadharUsers = new AadharInformation[CountUsers];
            int index = 0;
            AadharInformation currentAadhar = Head;
            while (currentAadhar != null)
            {
                aadharUsers[index++] = currentAadhar;
                currentAadhar = currentAadhar.Next;
            }
            int start = 0;
            int end = CountUsers - 1;
            while (start < end)
            {
                int mid = (start + end) / 2;
                if (aadharUsers[mid].PersonName1.CompareTo(personName) == 0)
                {
                    Console.WriteLine("User Details : ");
                    Console.WriteLine(aadharUsers[mid].ToString());
                    return;
                }
                else if (aadharUsers[mid].PersonName1.CompareTo(personName) < 0)
                {
                    end = mid - 1;
                }
                else if (aadharUsers[mid].PersonName1.CompareTo(personName) > 0)
                {
                    start = mid + 1;

                }
            }
        }
    }
}
