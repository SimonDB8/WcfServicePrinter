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
           
            if (userIdBox.TextLength <= 0)
            {
                var res = client.GetAmountByUsername(getAmountByUsernameBox.Text);
                resultAmount.Text = res.ToString();
                var res2 = client.ConversionByUsername(getAmountByUsernameBox.Text);
                nombreImperssionBox.Text = res2.ToString();
                if (int.Parse(resultAmount.Text) == -1)
                {
                    ExceptionHome exceptionHome = new ExceptionHome();
                    exceptionHome.ShowDialog();
                    resultAmount.Text = " ";
                    nombreImperssionBox.Text = " ";
                }
                
            }
            else
            {
              
                var res = client.GetAmountByUserId(int.Parse(userIdBox.Text));
                resultAmount.Text = res.ToString();
                var res2 = client.Conversion(int.Parse(userIdBox.Text));
                nombreImperssionBox.Text = res2.ToString();
                if (int.Parse(resultAmount.Text) == -1)
                {
                    ExceptionHome exceptionHome = new ExceptionHome();
                    exceptionHome.ShowDialog();
                    resultAmount.Text = " ";
                    nombreImperssionBox.Text = " ";
                }
               
            }

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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void nombreImperssionBox_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
