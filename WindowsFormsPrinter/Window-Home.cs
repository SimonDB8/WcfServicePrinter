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
    public partial class Form4 : Form
    {

        private ServiceReferencePrinter.PrinterClient client;

        public Form4()
        {
            InitializeComponent();
            client = new ServiceReferencePrinter.PrinterClient();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var result = client.GetAmountByUserId(int.Parse(userIdBox.Text));
            resultAmount.Text = result.ToString();
        }
    }
}
