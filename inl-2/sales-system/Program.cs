using System;
using System.Threading.Tasks;

namespace sale_system
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej. Hur många säljare vill du registrera?");

            var continuation = true; 
            while (continuation)
            {
                var numberOfSaleAgents = Console.ReadLine();

                if (!int.TryParse(numberOfSaleAgents, out int result))
                {
                    Console.WriteLine("Du har inte angett en siffra. Vänligen ange en siffra. ");
                    continue;
                }

                continuation = false;
            }
            
        }
    }
}
