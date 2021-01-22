using System;
using System.Windows.Forms;

namespace change_calculator.win_app
{
    public partial class ChangeCalculator : Form
    {
        public ChangeCalculator()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            var input = priceTxtBox.Text;
            if (!int.TryParse(input, out var price))
            {
                MessageBox.Show("Priset måste vara ett nummer.");
                return;
            }
            input  = amountTxtBox.Text;

            if (!int.TryParse(input, out var amount))
            {
                MessageBox.Show("Betalt måste vara ett nummer.");
                return;
            }


            if (price > amount)
            {
                var amountMissing = price - amount;

                MessageBox.Show($"Du har betalat för lite. Det saknas {amountMissing} SEK");
                return;
            }

            var amountDifference = amount - price;

            var change = new Change();
            var changeInReturn = change.CalculateChange(amountDifference);

            PrintChangeInReturn(changeInReturn);

        }

        private void PrintChangeInReturn(Change changeInReturn)
        {
            textBox1.Text = "";

            if (changeInReturn.FiveHundred == 1)
                textBox1.Text += ($"{changeInReturn.FiveHundred} femhundralapp" + Environment.NewLine);
            if (changeInReturn.FiveHundred > 1)
                textBox1.Text += ($"{changeInReturn.FiveHundred} femhundralappar" + Environment.NewLine);
            if (changeInReturn.OneHundred == 1)
                textBox1.Text += ($"{changeInReturn.OneHundred} hundralapp" + Environment.NewLine);
            if (changeInReturn.OneHundred > 1)
                textBox1.Text += ($"{changeInReturn.OneHundred} hundralappar" + Environment.NewLine);
            if (changeInReturn.Fifty == 1)
                textBox1.Text += ($"{changeInReturn.Fifty} femtiolapp" + Environment.NewLine);
            if (changeInReturn.Fifty > 1)
                textBox1.Text += ($"{changeInReturn.Fifty} femtiolappar" + Environment.NewLine);
            if (changeInReturn.Twenty == 1)
                textBox1.Text += ($"{changeInReturn.Twenty} tjugolapp" + Environment.NewLine);
            if (changeInReturn.Twenty > 1)
                textBox1.Text += ($"{changeInReturn.Twenty} tjugolappar" + Environment.NewLine);
            if (changeInReturn.Ten == 1)
                textBox1.Text += ($"{changeInReturn.Ten} tiokrona" + Environment.NewLine);
            if (changeInReturn.Ten > 1)
                textBox1.Text += ($"{changeInReturn.Ten} tiokronor" + Environment.NewLine);
            if (changeInReturn.Five == 1)
                textBox1.Text += ($"{changeInReturn.Five} femkrona" + Environment.NewLine);
            if (changeInReturn.Five > 1)
                textBox1.Text += ($"{changeInReturn.Five} femkronor" + Environment.NewLine);
            if (changeInReturn.One == 1)
                textBox1.Text += ($"{changeInReturn.One} enkrona" + Environment.NewLine);
            if (changeInReturn.One > 1)
                textBox1.Text += ($"{changeInReturn.One} enkronor" + Environment.NewLine);

            if (string.IsNullOrWhiteSpace(textBox1.Text))
                textBox1.Text = "Ingen växel tillbaka.";
        }

        private void priceTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(sender, new EventArgs());
        }
        private void amountTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(sender, new EventArgs());
        }
    }
}
