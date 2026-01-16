using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.libraryorganizer
{
    // Entry point of the library organizer system application
    internal class LibraryOrganizerMain
    {
        static void Main(string[] args)
        {
            LibraryOrganizerMenu libraryOrganizerMenu = new LibraryOrganizerMenu();
            libraryOrganizerMenu.HomeMenu();
        }
    }
}
