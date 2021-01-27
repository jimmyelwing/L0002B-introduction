using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace person_form
{
    public partial class PersonForm : Form
    {
        public PersonForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sendButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            firstNameBox.Clear();
            lastNameBox.Clear();
            identityNumberBox.Clear();
            resultBox.Clear();
        }
    }
}
