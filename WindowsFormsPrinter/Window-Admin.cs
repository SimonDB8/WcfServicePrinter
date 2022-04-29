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
    public partial class administration : Form
    {
        private ServiceReferencePrinter.PrinterClient client;
        public administration()
        {
            InitializeComponent();
            client = new ServiceReferencePrinter.PrinterClient();
        }

        private void AddAmountByUsernameButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(usernameAdminBox.Text) || String.IsNullOrEmpty(AdminAmountBox.Text))
            {
                ExceptionAjouterMontant exceptionAjouterMontant = new ExceptionAjouterMontant();
                exceptionAjouterMontant.ShowDialog();
            }
            else
            {
                var result = client.AddAmountByUsername(usernameAdminBox.Text, int.Parse(AdminAmountBox.Text));
                AdminNewAmount.Text = result.userAmount.ToString();
            }







            
        }
    }
}
