using BridgeLabzTraining.bird_sanctuary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.EmployeeWage
{
    // Entry point of the application
    internal class EmployeeMain
    {       
        static void Main(string[] args)
        {
            EmployeeMenu EmployeeMenu = new EmployeeMenu();
            EmployeeMenu.EmployeeChoices();
        }
    }
}
