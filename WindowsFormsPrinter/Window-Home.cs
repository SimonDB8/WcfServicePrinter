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
    public partial class homeUser : Form
    {

        private ServiceReferencePrinter.PrinterClient client;

        public homeUser()
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

        private void userPage_Click(object sender, EventArgs e)
        {
            user user = new user();
            user.ShowDialog();
        }

        private void adminPage_Click(object sender, EventArgs e)
        {
            administration administration = new administration();
            administration.ShowDialog();
        }

        private void payOnlinePage_Click(object sender, EventArgs e)
        {
            payOnline payOnline = new payOnline();
            payOnline.ShowDialog();
        }

        private void homeUser_Load(object sender, EventArgs e)
        {

        }
    }
}
