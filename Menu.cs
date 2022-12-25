using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Menu
    {
        public string what_URL;
        public string what_URL1;
        public void MainMenu()
        {
            Console.Clear();
            Console.Write("\n  Domian is: ");
            what_URL = "https://" + Console.ReadLine();
        }
        public void PrintMainMenu()
        {
            Status s = new Status();
            Ping p = new Ping();
            IP i = new IP();
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("  Main:\n  -------------------------");
            Console.WriteLine("  URL: " + what_URL);
            i.ipHostPrint(ref what_URL);
            Console.WriteLine("  -------------------------");
            Console.WriteLine();
            Console.WriteLine("  Info:\n  -------------------------");
            s.statusHostPrint(ref what_URL);
            p.pingHostPrint(ref what_URL);
            Console.WriteLine("  -------------------------");
            Console.WriteLine("\n  Options:\n  -------------------------");
            Console.WriteLine("  [1] - update\n  [2] - edit domian");
            Console.WriteLine("  -------------------------");
            Console.Write("  Enter: ");
            what_URL1 = Console.ReadLine();
            if (what_URL1 == "1")
            {
                PrintMainMenu();
            }
            else if (what_URL1 == "2")
            {
                MainMenu();
                PrintMainMenu();
            }
        }

    }
}
