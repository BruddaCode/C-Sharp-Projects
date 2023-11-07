using System;

namespace ConsoleAppIfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Peter", "Ana" , "Felipe"};

            names.Add("Joe");
            names.Add("Johnathan");
            names.Add("Ordis");
            
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
        }
    }
}