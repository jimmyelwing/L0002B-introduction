using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace sale_system
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej. Hur många säljare vill du registrera?");
            var numberOfSaleAgents = Console.ReadLine();

            while (!int.TryParse(numberOfSaleAgents, out int result))
            {
                Console.WriteLine("Du har inte angett en siffra. Vänligen ange en siffra. ");
                numberOfSaleAgents = Console.ReadLine();
            }

            Console.WriteLine($"Du har angett att du vill registrera {numberOfSaleAgents} säljare.");
        }
    }
}
