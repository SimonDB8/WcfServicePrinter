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
    public partial class payOnline : Form
    {
        private ServiceReferencePrinter.PrinterClient client;
        public payOnline()
        {
            InitializeComponent();
            client = new ServiceReferencePrinter.PrinterClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(PayOnlineUsernameBox.Text) || String.IsNullOrEmpty(PayOnlineAmountBox.Text))
            {
                ExceptionAjouterMontant exceptionAjouterMontant = new ExceptionAjouterMontant();
                exceptionAjouterMontant.ShowDialog();
            }
            else
            {
                var result = client.AddAmountByUsername(PayOnlineUsernameBox.Text, int.Parse(PayOnlineAmountBox.Text));
                PayOnlineNewAmount.Text = result.userAmount.ToString();
            }
        }
    }
}
