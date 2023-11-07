using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieClicker
{
    public static class Upgrades
    {
        public static void UpgradeAlert()
        {
            if (Variables.cookie > 15)
            {
                Console.WriteLine("druk op 'z' om een CLICKER te kopen (kost: 15)");
                Variables.buy_click = true;
            }
            else
            {
                Variables.buy_click = false;
            }

            if (Variables.cookie > 100)
            {
                Console.WriteLine("druk op 'x' om een OMA te kopen (kost: 100)");
                Variables.buy_oma = true;
            }
            else
            {
                Variables.buy_oma = false;
            }

            if (Variables.cookie > 1100)
            {
                Console.WriteLine("druk op 'c' om een BOERDERIJ te kopen (kost: 1100)");
                Variables.buy_boerderij = true;
            }
            else
            {
                Variables.buy_boerderij = false;
            }

            if (Variables.cookie > 12000)
            {
                Console.WriteLine("druk op 'v' om een MIJN te kopen (kost: 12000)");
                Variables.buy_mijn = true;
            }
            else
            {
                Variables.buy_mijn = false;
            }

            if (Variables.cookie > 130000)
            {
                Console.WriteLine("druk op 'b' om een FABRIEK te kopen (kost: 130000)");
                Variables.buy_fabriek = true;
            }
            else
            {
                Variables.buy_fabriek = false;
            }
            
            if (Variables.cookie > 1400000)
            {
                Console.WriteLine("druk op 'n' om een BANK te kopen (kost: 1400000)");
                Variables.buy_bank = true;
            }
            else
            {
                Variables.buy_bank = false;
            }

            if (Variables.cookie > 20000000)
            {
                Console.WriteLine("druk op 'm' om een TEMPEL te kopen (kost: 20000000)");
                Variables.buy_tempel = true;
            }
            else
            {
                Variables.buy_tempel = false;
            }
        }

        public static void CPS()
        {
            Variables.cps = (Variables.clicker * 1) +
                            (Variables.oma * 2) +
                            (Variables.boerderij * 3) +
                            (Variables.mijn * 4) +
                            (Variables.fabriek * 5) +
                            (Variables.bank * 6) +
                            (Variables.tempel * 7) + 1;
        }

        public static void SpacePress()
        {
            Variables.cookie = Variables.cookie + 1;
            Variables.cookie = Variables.cookie + (1 * Variables.clicker);
            Variables.cookie = Variables.cookie + (2 * Variables.oma);
            Variables.cookie = Variables.cookie + (3 * Variables.boerderij);
            Variables.cookie = Variables.cookie + (4 * Variables.mijn);
            Variables.cookie = Variables.cookie + (5 * Variables.fabriek);
            Variables.cookie = Variables.cookie + (6 * Variables.bank);
            Variables.cookie = Variables.cookie + (7 * Variables.tempel);
        }

        public static void Clicker()
        {
            if (Variables.buy_click == true)
            {
                Variables.cookie = Variables.cookie - 15;
                Variables.clicker++;
            }
        }

        public static void Oma()
        {
            if (Variables.buy_oma == true)
            {
                Variables.cookie = Variables.cookie - 100;
                Variables.oma++;
            }
        }

        public static void Boerderij()
        {
            if (Variables.buy_boerderij == true)
            {
                Variables.cookie = Variables.cookie - 1100;
                Variables.boerderij++;
            }
        }

        public static void Mijn()
        {
            if (Variables.buy_mijn == true)
            {
                Variables.cookie = Variables.cookie - 12000;
                Variables.mijn++;
            }
        }

        public static void Fabriek()
        {
            if (Variables.buy_fabriek == true)
            {
                Variables.cookie = Variables.cookie - 130000;
                Variables.fabriek++;
            }
        }

        public static void Bank()
        {
            if (Variables.buy_bank == true)
            {
                Variables.cookie = Variables.cookie - 1400000;
                Variables.bank++;
            }
        }

        public static void Tempel()
        {
            if (Variables.buy_tempel == true)
            {
                Variables.cookie = Variables.cookie - 20000000;
                Variables.tempel++;
            }
        }
    }
}
