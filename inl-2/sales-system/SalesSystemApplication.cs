using System;

namespace sales_system
{
    public class SalesSystemApplication
    {
        public void Run()
        {
            Console.WriteLine("Hej. Hur många säljare vill du registrera?");
            
            var numberOfSaleAgents = GetNumberOfSalesAgents();

            Console.WriteLine($"Du har angett att du vill registrera {numberOfSaleAgents} säljare.");



        }

        private int GetNumberOfSalesAgents()
        {
            var numberOfSaleAgents = Console.ReadLine();

            while (!int.TryParse(numberOfSaleAgents, out int result))
            {
                Console.WriteLine("Du har inte angett en siffra. Vänligen ange en siffra. ");
                numberOfSaleAgents = Console.ReadLine();
            }

            return Convert.ToInt32(numberOfSaleAgents);
        }
    }
}
