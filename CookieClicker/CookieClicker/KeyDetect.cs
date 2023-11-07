using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieClicker
{
    public static class KeyDetect
    {
        public static void KeyPress()
        {
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.Spacebar:
                    Upgrades.SpacePress();
                    break;
                case ConsoleKey.Z:
                    Upgrades.Clicker();
                    break;
                case ConsoleKey.X:
                    Upgrades.Oma();
                    break;
                case ConsoleKey.C:
                    Upgrades.Boerderij();
                    break;
                case ConsoleKey.V:
                    Upgrades.Mijn();
                    break;
                case ConsoleKey.B:
                    Upgrades.Fabriek();
                    break;
                case ConsoleKey.N:
                    Upgrades.Bank();
                    break;
                case ConsoleKey.M:
                    Upgrades.Tempel();
                    break;
                default:
                    return;
            }
        }
    }
}
