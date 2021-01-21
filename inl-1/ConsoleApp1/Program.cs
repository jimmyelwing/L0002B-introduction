using System;
using System.Reflection.Metadata.Ecma335;
using changecalculator.consoleapp;

namespace ConsoleApp1
{
    class Program
    {
        private static InputVerifier _inputVerifier;

        static void Main(string[] args)
        {
            _inputVerifier = new InputVerifier();

            //Ange pris på vad det kostar
            Console.Write("Ange pris: ");
            var price = Console.ReadLine();

            //Ange vad kunden har betalat
            Console.Write("Betalt: ");
            var amount = Console.ReadLine();

            //Visa växel tillbaka, i valörer (500, 100, 20, 10, 5, 1)

        }
    }
}
