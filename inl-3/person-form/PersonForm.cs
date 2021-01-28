using System;
using System.Windows.Forms;
using person_form.Domain;
using person_form.Helpers;

namespace person_form
{
    public partial class PersonForm : Form
    {
        public PersonForm()
        {
            InitializeComponent();
        }

        private void PersonForm_Load(object sender, EventArgs e)
        {

        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            var identityNumber = Formatter.FormatIdentityNumber(identityNumberBox.Text);

            if (!Validator.IdentityNumberIsValid(identityNumber))
            {
                resultBox.Text = "Det du angett är inte ett giltigt personnummer. Vänligen fyll i ett giltigt personnummer.";
                return;
            }

            var person = new Person(firstNameBox.Text, lastNameBox.Text, identityNumber);
            
            resultBox.Text = $"Namn: {person.FirstName} {person.LastName}" + Environment.NewLine +
                             $"Personnummer: {person.IdentityNumber}" + Environment.NewLine +
                             $"Kön: " + Translator.TranslateGender(person.Gender);
        }

        private void firstNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                lastNameBox.Focus();
        }
        private void lastNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                identityNumberBox.Focus();
        }
        private void identityNumberBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sendButton_Click(sender, new EventArgs());
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            firstNameBox.Clear();
            lastNameBox.Clear();
            identityNumberBox.Clear();
            resultBox.Clear();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
