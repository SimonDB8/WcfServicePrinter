using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPrinter
{
    public partial class user : Form
    {

        private ServiceReferencePrinter.PrinterClient client;
        public user()
        {
            InitializeComponent();
            client = new ServiceReferencePrinter.PrinterClient();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddAmountByUserIdButton_Click(object sender, EventArgs e)
        {
            client.AddAmountByUserId(int.Parse(UserIdBox.Text), int.Parse(AmountBox.Text));
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
