using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.TextEditorSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextEditorApplication editor = new TextEditorApplication();
            while (true)
            {
                Console.WriteLine("Undo/Redo Editor");
                Console.WriteLine("1. Type/Add State");
                Console.WriteLine("2. Undo");
                Console.WriteLine("3. Redo");
                Console.WriteLine("4. Display Current");
                Console.WriteLine("0. Back");
                Console.Write("Choice: ");
                string choice = Console.ReadLine();
                if (choice == "0")
                {
                    break;
                }
                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Content: ");
                        editor.AddState(Console.ReadLine());
                        break;
                    case "2":
                        editor.Undo();
                        Console.WriteLine("Undid.");
                        break;
                    case "3":
                        editor.Redo();
                        Console.WriteLine("Redid.");
                        break;
                    case "4":
                        editor.DisplayCurrent();
                        break;
                }
            }
        }
    }
}
