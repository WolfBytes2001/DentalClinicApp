using DentalClinicApp.Forms.Billing;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class schedule : UserControl
    {
        public static bool changeStatPromp = false;
        public schedule()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeStatus();

        }

        void ChangeStatus()
        {
            if (scheduleTable.Rows.Count > 0)
            {
                int selectedRowIndex = scheduleTable.CurrentRow.Index;
                string? appointmentID = scheduleTable.Rows[selectedRowIndex].Cells[0].Value.ToString();

                try
                {
                    if (Database.Connect())
                    {
                        if (changeStatPromp == false)
                        {
                            scheduleStatusChanger changeStat = new scheduleStatusChanger();
                            changeStat.Show();
                            changeStatPromp = true;
                            changeStat.appointmentID.Text = appointmentID;
                        }
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    Database.conn.Close();
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void schedule_Load(object sender, EventArgs e)
        {
            loadTable();
        }
        public void loadTable()
        {
            string query = "CALL allAppointments()";
            Database.loadDataGridView(scheduleTable, query);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (Database.Connect())
                {
                    string query = $"CALL schedule_specificDate('{dateTimePicker1.Text}')";
                    MySqlCommand cmd = new MySqlCommand(query, Database.conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    scheduleTable.DataSource = table;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Database.conn.Close();
            }
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            Search(searchBar.Text);
        }
        void Search(string keyword)
        {


            try
            {
                if (!string.IsNullOrEmpty(keyword))
                {
                    if (Database.Connect())
                    {
                        string query = $"SELECT appointment.appointmentID, patient_record.fullname, appointment.availedService, appointment.`schedule`,patient_record.contact, patient_record.address,appointment.`status` FROM appointment INNER JOIN patient_record ON  appointment.patientID = patient_record.patientID WHERE appointment.appointmentID like '%{keyword}%' OR patient_record.fullname like '%{keyword}%' ";
                        Database.loadDataGridView(scheduleTable, query);

                    }
                }
                else
                {
                    Database.loadDataGridView(scheduleTable, "CALL allAppointments()");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            billingAndTransactions billing = new billingAndTransactions();

            if (scheduleTable.Rows.Count > 0)
            {
                int selectedRowIndex = scheduleTable.CurrentRow.Index;
                string? appointmentID = scheduleTable.Rows[selectedRowIndex].Cells[0].Value.ToString();
                billing.appointmentIDBox.Text = appointmentID;

            }


                billing.Show();
        }
    }
}
