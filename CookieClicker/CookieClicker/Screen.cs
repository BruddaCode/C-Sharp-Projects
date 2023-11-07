using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieClicker
{
    internal class Game
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Upgrades.CPS();
                Console.WriteLine($"je verdient {Variables.cps} koekjes per klik");
                Console.WriteLine($"je hebt {Variables.cookie} cookies");
                Console.WriteLine("");
                Console.WriteLine($"je hebt {Variables.clicker} clickers");
                Console.WriteLine($"je hebt {Variables.oma} oma's");
                Console.WriteLine($"je hebt {Variables.boerderij} boerderijen");
                Console.WriteLine($"je hebt {Variables.mijn} mijnen");
                Console.WriteLine($"je hebt {Variables.fabriek} fabrieken");
                Console.WriteLine($"je hebt {Variables.bank} banken");
                Console.WriteLine($"je hebt {Variables.tempel} tempels");
                Console.WriteLine("");
                Upgrades.UpgradeAlert();
                KeyDetect.KeyPress();
                //Thread.Sleep(8);
            }
        }
    }
}