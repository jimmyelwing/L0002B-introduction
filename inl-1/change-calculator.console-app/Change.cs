namespace changecalculator.consoleapp
{
    public class Change
    {
        public int FiveHundred { get; set; }

        public int OneHundred { get; set; }

        public int Fifty { get; set; }

        public int Twenty { get; set; }

        public int Ten { get; set; }

        public int Five { get; set; }

        public int One { get; set; }

        public Change CalculateChange(int amount)
        {
            var change = new Change();

            change.FiveHundred = amount / 500;
            amount %= 500;
            change.OneHundred = amount / 100;
            amount %= 100;
            change.Fifty = amount / 50;
            amount %= 50;
            change.Twenty = amount / 20;
            amount %= 20;
            change.Ten = amount / 10;
            amount %= 10;
            change.Five = amount / 5;
            amount %= 5;
            change.One = amount / 1;

            return change;
        }
    }
}
