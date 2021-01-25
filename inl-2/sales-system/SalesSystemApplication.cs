using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using sales_system.Domain;

namespace sales_system
{
    public class SalesSystemApplication : Writer
    {
        public void Run()
        {
            Console.WriteLine("Hej. Hur många säljare vill du registrera?");

            var numberOfSaleAgents = GetNumberOfSalesAgents();

            Console.WriteLine($"Du har angett att du vill registrera {numberOfSaleAgents} säljare.");

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

            var sortedAgents = SortSalesAgentsBasedOnNumberOfSales(agents);

            PrintNumberOfSales(sortedAgents);

            CloseStream();
        }

        private void PrintNumberOfSales(List<SalesAgent> sortedAgents)
        {
            Print(sortedAgents.Where(x => x.NumberOfSales < 50));
            Print(sortedAgents.Where(x=>x.NumberOfSales >= 50  && x.NumberOfSales <= 99));
            Print(sortedAgents.Where(x => x.NumberOfSales >= 100 && x.NumberOfSales <= 199));
            Print(sortedAgents.Where(x => x.NumberOfSales > 199));
        }

        private void Print(IEnumerable<SalesAgent> agents)
        {
            if (agents.ToList().Count == 0)
                return;

            Console.WriteLine();
            foreach (var salesAgent in agents)
            {
                Console.WriteLine("{0,20}{1,20}{2,20}{3,20}", "Name", "Persnr","Distrikt","Antal");
                Console.WriteLine($"{salesAgent.Name,20}{salesAgent.IdentityNumber,20}{salesAgent.District,20}{salesAgent.NumberOfSales,20}");
            }

            Console.WriteLine($"{agents.ToList().Count} har nått nivå {GetSalesLevel(agents)}");
        }

        private string GetSalesLevel(IEnumerable<SalesAgent> agents)
        {
            if (agents.FirstOrDefault().NumberOfSales < 50) 
                return "1: under 50 artiklar.";
            if (agents.FirstOrDefault().NumberOfSales >= 50 && agents.FirstOrDefault().NumberOfSales <= 99) 
                return "2: 50-99 artiklar.";
            if (agents.FirstOrDefault().NumberOfSales >= 100 && agents.FirstOrDefault().NumberOfSales <= 199) 
                return "3: 100-199 artiklar.";
            if (agents.FirstOrDefault().NumberOfSales > 199) 
                return "4: över 199 artiklar.";
            
            return null; //default 
        }

        private List<SalesAgent> SortSalesAgentsBasedOnNumberOfSales(List<SalesAgent> agents)
        {
            return agents
                .OrderBy(x => x.NumberOfSales)
                .ToList();
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
