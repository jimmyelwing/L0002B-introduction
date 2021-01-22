using System;
using System.Threading;

namespace changecalculator.consoleapp
{
    public class ChangeCalculatorApp
    {
        public void Run()
        {
            var quitProgram = false;
            int price;
            int amount;

            while (true)
            {
                price = GetPrice();
                amount = GetAmountPaid();

                if (price > amount)
                {
                    var amountMissing = price - amount;
                    
                    Console.WriteLine($"Du har betalat för lite. Det saknas {amountMissing} SEK. Kan du betala {amountMissing}? (JA eller NEJ)");
                    var input = Console.ReadLine();

                    if (input?.ToLower() == "ja")
                    {
                        amount += amountMissing;
                        break;
                    }
                    if (input?.ToLower() == "nej")
                    {
                        Console.WriteLine("Ok. Tack ändå!");
                        quitProgram = true;
                        break;
                    }

                    Console.WriteLine("Nu förstod jag inte. Vi börjar om.");
                    Thread.Sleep(2500);
                    Console.Clear();
                }

                break;
            }

            if (!quitProgram)
            {
                var amountDifference = amount - price;

                var change = new Change();
                var changeInReturn = change.CalculateChange(amountDifference);

                PrintChangeInReturn(changeInReturn);
            }

            Console.ReadKey();
        }

        private static int GetPrice()
        {
            while (true)
            {
                Console.Write("Ange pris: ");
                var input = Console.ReadLine();

                if (VerifyInput(input, out var price)) continue;

                return price;
            }
        }

        private static int GetAmountPaid()
        {
            while (true)
            {
                Console.Write("Betalt: ");
                var input = Console.ReadLine();

                if (VerifyInput(input, out var price)) continue;

                return price;
            }
        }
        private static bool VerifyInput(string input, out int number)
        {
            if (!int.TryParse(input, out number))
            {
                Console.WriteLine("Vänligen ange en siffra.");
                return true;
            }

            return false;
        }

        public static void PrintChangeInReturn(Change changeInReturn)
        {
            var change = "";

            if (changeInReturn.FiveHundred == 1)
                change += ($"{changeInReturn.FiveHundred} femhundralapp \n");
            if (changeInReturn.FiveHundred > 1)
                change += ($"{changeInReturn.FiveHundred} femhundralappar \n");
            if (changeInReturn.OneHundred == 1)
                change += ($"{changeInReturn.OneHundred} hundralapp \n");
            if (changeInReturn.OneHundred > 1)
                change += ($"{changeInReturn.OneHundred} hundralappar \n");
            if (changeInReturn.Fifty == 1)
                change += ($"{changeInReturn.Fifty} femtiolapp \n");
            if (changeInReturn.Fifty > 1)
                change += ($"{changeInReturn.Fifty} femtiolappar \n");
            if (changeInReturn.Twenty == 1)
                change += ($"{changeInReturn.Twenty} tjugolapp \n");
            if (changeInReturn.Twenty > 1)
                change += ($"{changeInReturn.Twenty} tjugolappar \n");
            if (changeInReturn.Ten == 1)
                change += ($"{changeInReturn.Ten} tiokrona \n");
            if (changeInReturn.Ten > 1)
                change += ($"{changeInReturn.Ten} tiokronor \n");
            if (changeInReturn.Five == 1)
                change += ($"{changeInReturn.Five} femkrona \n");
            if (changeInReturn.Five > 1)
                change += ($"{changeInReturn.Five} femkronor \n");
            if (changeInReturn.One == 1)
                change += ($"{changeInReturn.One} enkrona \n");
            if (changeInReturn.One > 1)
                change += ($"{changeInReturn.One} enkronor \n");

            if (string.IsNullOrWhiteSpace(change))
            {
                Console.WriteLine("Du får ingen växel tillbaka.");
                return;
            }

            Console.WriteLine($"Du får följande växel tillbaka: \n{change}");
        }
    }
}
