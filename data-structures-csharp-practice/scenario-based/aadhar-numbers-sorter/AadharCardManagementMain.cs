using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.AadharNumbersSorter
{
    internal class AadharCardManagementMain
    {
        static void Main(string[] args)
        {
            AadharCardUserMenu aadharCardUserMenu = new AadharCardUserMenu();
            aadharCardUserMenu.HomeMenu();
        }
    }
}
