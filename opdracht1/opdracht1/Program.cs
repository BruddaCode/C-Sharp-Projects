// See https://aka.ms/new-console-template for more information <-- dit is voor .net 6.0

using System;

namespace opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef uw inloggegevens op");
            string? inlognaam = "";
            string? wachtwoord = "";
            int pogingen = 8;
            int gefaaldePogingen = 0;
            while (pogingen != 0)
            {
                Console.Write("wat is uw inlognaam: ");
                inlognaam = Console.ReadLine();
                Console.Write("wat is uw wachtwoord: ");
                wachtwoord = Console.ReadLine();
                Console.WriteLine("");
                pogingen--; gefaaldePogingen++;
                
                if (pogingen == 0){
                    Console.WriteLine($"\nTOEGANG GEWEIGERD! \nU heeft {gefaaldePogingen} keer de verkeerde gegevens ingevoerd");
                    return;
                }

                if (!inlognaam.Equals("Fabio") || !wachtwoord.Equals("9014474")){
                    Console.WriteLine($"U heeft nog {pogingen} pogingen over");
                    continue;
                }

                break;
            }
            Console.WriteLine($"Welkom: {inlognaam}");
        }
    }
}