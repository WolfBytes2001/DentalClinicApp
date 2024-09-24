using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinicApp.Forms.Billing
{
    public partial class billingAndTransactions : Form
    {
        public billingAndTransactions()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string appID = appointmentIDBox.Text;
            string paymentOption = paymentBox.Text;
            string amount = amountBox.Text;
            string serviceFee = serviceFeeBox.Text;
            string balance = balanceBox.Text;

            try
            {
                if (Database.Connect())
                {
                    string query = $"INSERT INTO billing(service_fee, total_amount, balance, appointmentID) VALUES('{serviceFee}', '{amount}', '{balance}', '{appID}')";
                    using (MySqlCommand cmd = new MySqlCommand(query, Database.conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Payment Saved!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void amountBox_TextChanged(object sender, EventArgs e)
        {
            calculateBalance();
        }

        private void serviceFeeBox_TextChanged(object sender, EventArgs e)
        {
            calculateBalance();
        }

        void calculateBalance()
        {
            double fee = Convert.ToDouble(serviceFeeBox.Text);
            double amount = Convert.ToDouble(amountBox.Text);
            double balance = fee - amount;

            balanceBox.Text = balance.ToString();
        }
    }
}
