using System;
using System.Collections.Generic;
using System.Linq;
using sales_system.Domain;
using sales_system.Handler;

namespace sales_system
{
    public class SalesSystemApplication : Writer
    {
        public void Run()
        {
            Console.WriteLine("Hej. Hur många säljare vill du registrera?");
            var numberOfSaleAgents = SalesAgentHandler.GetNumberOfSalesAgents();

            Console.WriteLine($"Du har angett att du vill registrera {numberOfSaleAgents} säljare.");

            var agents = SalesAgentHandler.GetAgentsInformation(numberOfSaleAgents);

            var sortedAgents = SalesAgentHandler.SortSalesAgentsBasedOnNumberOfSales(agents);

            PrintNumberOfSales(sortedAgents);

            CloseStream();
        }


        private void PrintNumberOfSales(List<SalesAgent> sortedAgents)
        {
            Console.Clear();
            WriteToConsoleAndFile("Resultat");
            WriteToConsoleAndFile("-------------------------------------------------------");

            Print(sortedAgents.Where(x => x.NumberOfSales < 50));
            Print(sortedAgents.Where(x=>x.NumberOfSales >= 50  && x.NumberOfSales <= 99));
            Print(sortedAgents.Where(x => x.NumberOfSales >= 100 && x.NumberOfSales <= 199));
            Print(sortedAgents.Where(x => x.NumberOfSales > 199));
        }

        private void Print(IEnumerable<SalesAgent> agents)
        {
            if (agents.ToList().Count == 0)
                return;

            foreach (var salesAgent in agents)
            {
                WriteToConsoleAndFile($"Namn: {salesAgent.Name}\nPersnr: {salesAgent.IdentityNumber}\nDistrikt: {salesAgent.District}\nAntal: {salesAgent.NumberOfSales}\n");
            }

            WriteToConsoleAndFile($"{agents.ToList().Count} har nått nivå {GetSalesLevel(agents)}\n");
            WriteToConsoleAndFile("-------------------------------------------------------");
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
    }
}
