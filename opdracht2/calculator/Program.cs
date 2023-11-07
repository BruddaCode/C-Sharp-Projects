using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dit programma berekent 2 getallen");
            Console.WriteLine("u kunt kiezen uit bewerkingen 5");
            int keuze = kiesBewerking();

            while (keuze > 0 && keuze <= 5)
            {

                double number = getNumber("Getal 1: ");
                double number2 = getNumber("Getal 2: ");
                switch (keuze)
                {
                    case 1:
                        Console.WriteLine(add(number, number2));
                        break;
                    case 2:
                        Console.WriteLine(subtract(number, number2));
                        break;
                    case 3:
                        Console.WriteLine(multiply(number, number2));
                        break;
                    case 4:
                        Console.WriteLine(divide(number, number2));
                        break;
                    case 5:
                        Console.WriteLine(power(number, number2));
                        break;
                    default:
                        Console.WriteLine("u heeft geen geldige keuze gemaakt");
                        break;
                }
                keuze = kiesBewerking();
            }
            
        }

        static int kiesBewerking()
        {
            int keuze = 0;
            Console.WriteLine("");
            Console.WriteLine("kies een bewerking");
            Console.WriteLine("1. + | 2. - | 3. * | 4. / | 5. ^");
            Console.WriteLine("wat is uw keuze?");
            string sKeuze = Console.ReadLine();
            try
            {
                keuze = Int32.Parse(sKeuze);
            }
            catch (Exception e)
            {
                Console.WriteLine("u heeft geen geldige keuze gemaakt");
            }
            Console.WriteLine("");
            return keuze;
        }

        static double getNumber(string tekst)
        {
            Console.Write(tekst);
            try
            {
                return double.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("u heeft geen geldig getal ingevoerd");
                return 0;
            }
        }

        static double add(double number, double number2)
        {
            double result = number + number2;
            return result;
        }

        static double subtract(double number, double number2)
        {
            double result = number - number2;
            return result;
        }

        static double multiply(double number, double number2)
        {
            double result = number * number2;
            return result;
        }

        static double divide(double number, double number2)
        {
            double result = number / number2;
            return result;
        }

        static double power(double number, double number2)
        {
            double result = Math.Pow(number, number2);
            return result;
        }
    }
}












