using System;
using sales_system.Domain;

namespace sales_system
{
    public class SalesSystemApplication
    {
        public void Run()
        {
            Console.WriteLine("Hej. Hur många säljare vill du registrera?");
            
            var numberOfSaleAgents = GetNumberOfSalesAgents();

            Console.WriteLine($"Du har angett att du vill registrera {numberOfSaleAgents} säljare.");

            for (int i = 0; i < numberOfSaleAgents; i++)
            {
                Console.WriteLine($"\nSäljare nr. {i+1}");
                
                var salesAgent = new SalesAgent();
                Console.Write("Namn: ");
                salesAgent.Name = Console.ReadLine();
                Console.Write("Personnummer: ");
                salesAgent.IdentityNumber = Console.ReadLine();
                Console.Write("Distrikt: ");
                salesAgent.District = Console.ReadLine();
                Console.Write("Antal sålda artiklar: ");
                salesAgent.NumberOfSales = GetNumberOfSales();
            }

        }

        private int GetNumberOfSales()
        {
            var numberOfSales = Console.ReadLine();

            while (!int.TryParse(numberOfSales, out _))
            {
                Console.WriteLine("Du har inte angett en siffra. Vänligen ange en siffra. ");
                numberOfSales = Console.ReadLine();
            }

            return Convert.ToInt32(numberOfSales);
        }

        private int GetNumberOfSalesAgents()
        {
            var numberOfSaleAgents = Console.ReadLine();

            while (!int.TryParse(numberOfSaleAgents, out _))
            {
                Console.WriteLine("Du har inte angett en siffra. Vänligen ange en siffra. ");
                numberOfSaleAgents = Console.ReadLine();
            }

            return Convert.ToInt32(numberOfSaleAgents);
        }
    }
}
