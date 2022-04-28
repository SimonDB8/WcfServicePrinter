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

        private void AddAmountByUserIdButton_Click(object sender, EventArgs e)
        {
        var result = client.AddAmountByUserId(int.Parse(UserIdBox.Text), int.Parse(AmountBox.Text));
        NewAmountBox.Text = result.userAmount.ToString();
        }
    }
}
