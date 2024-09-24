using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinicApp.Forms
{
    public partial class scheduleStatusChanger : Form
    {
        public scheduleStatusChanger()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            schedule.changeStatPromp = false;
            Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Database.Connect() && optionBox.Text == "Done")
                {
                    string query = $"UPDATE appointment SET status = 'Done' WHERE appointmentID = {appointmentID.Text}";
                    using (MySqlCommand command = new MySqlCommand(query, Database.conn))
                    {
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Patient status changed Successfully", "Success!");
                    Dashboard.schedule.loadTable();
                    schedule.changeStatPromp = false;
                    Close();
                }
                else if (Database.Connect() && optionBox.Text == "Cancelled")
                {
                    string query = $"UPDATE appointment SET status = 'Cancelled' WHERE appointmentID = {appointmentID.Text}";
                    using (MySqlCommand command = new MySqlCommand(query, Database.conn))
                    {
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Patient status changed Successfully", "Success!");
                    Dashboard.schedule.loadTable();
                    schedule.changeStatPromp = false;
                    Close();
                }
                else
                {
                    MessageBox.Show("Some fields are empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                Database.conn.Close();
            }
        }


    }
}
