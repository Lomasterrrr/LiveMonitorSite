using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main()
        {
            Console.SetWindowSize(30,20);
            Menu main = new Menu();
            main.MainMenu();
            main.PrintMainMenu();
        }

        }
    }

