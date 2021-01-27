using System;
using System.Collections.Generic;
using System.Linq;
using sales_system.Domain;

namespace sales_system.Handler
{
    public static class SalesAgentHandler
    {
        public static int GetNumberOfSalesAgents()
        {
            var numberOfSaleAgents = Console.ReadLine();

            while (!int.TryParse(numberOfSaleAgents, out _))
            {
                Console.WriteLine("Du har inte angett en siffra. Vänligen ange en siffra. ");
                numberOfSaleAgents = Console.ReadLine();
            }

            return Convert.ToInt32(numberOfSaleAgents);
        }

        public static List<SalesAgent> GetAgentsInformation(int numberOfSaleAgents)
        {
            var agents = new List<SalesAgent>();

            for (int i = 0; i < numberOfSaleAgents; i++)
            {
                Console.WriteLine($"\nSäljare nr. {i + 1}");

                var salesAgent = new SalesAgent();
                Console.Write("Namn: ");
                salesAgent.Name = Console.ReadLine();
                Console.Write("Personnummer: ");
                salesAgent.IdentityNumber = Console.ReadLine();
                Console.Write("Distrikt: ");
                salesAgent.District = Console.ReadLine();
                Console.Write("Antal sålda artiklar: ");
                salesAgent.NumberOfSales = GetNumberOfSales();

                agents.Add(salesAgent);
            }

            return agents;
        }

        public static List<SalesAgent> SortSalesAgentsBasedOnNumberOfSales(List<SalesAgent> agents)
        {
            return agents
                .OrderBy(x => x.NumberOfSales)
                .ToList();
        }

        private static int GetNumberOfSales()
        {
            var numberOfSales = Console.ReadLine();

            while (!int.TryParse(numberOfSales, out _))
            {
                Console.WriteLine("Du har inte angett en siffra. Vänligen ange en siffra. ");
                numberOfSales = Console.ReadLine();
            }

            return Convert.ToInt32(numberOfSales);
        }
    }
}
