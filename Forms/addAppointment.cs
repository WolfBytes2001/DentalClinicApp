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

namespace DentalClinicApp.Forms
{
    public partial class addAppointment : Form
    {
        public addAppointment()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int patientID = Convert.ToInt32(pIDBox.Text);
            string service = serviceBox.Text;
            string sched = scheduleBox.Text;


            try
            {
                if (Database.Connect() && !string.IsNullOrEmpty(patientID.ToString()) && !string.IsNullOrEmpty(service) && !string.IsNullOrEmpty(sched.ToString()))
                {
                    string query = $"INSERT INTO appointment(patientID, availedService, schedule) VALUES({patientID}, '{service}', '{sched}')";
                    using (MySqlCommand command = new MySqlCommand(query, Database.conn))
                    {
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Successfully added a patient appointment!", "Success!");
                    Dashboard.schedule.loadTable();
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

        private void patientIDBox_Click(object sender, EventArgs e)
        {
            //Database.LoadComboBox(patientIDBox, "patientID", "patient_record");
        }

        private void listView1_Click(object sender, EventArgs e)
        {

        }

        private void addAppointment_Load(object sender, EventArgs e)
        {
            Database.LoadComboBox(pNameBox, "fullname", "patient_record");
        }

        private void patientIDBox_Click_1(object sender, EventArgs e)
        {
            //Database.LoadComboBox(patientName, "fullname", "patient_record");
        }

        private void patientIDBox_Click_2(object sender, EventArgs e)
        {

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            Database.LoadComboBox(pIDBox, "patientID", "patient_record");

            //try
            //{
            //    if(Database.Connect())
            //    {

            //        string patientID = pID.Text;
            //        string query = $"SELECT fullname FROM patient_record WHERE patientID = {Convert.ToInt16(patientID)}";
            //        MySqlCommand cmd = new MySqlCommand(query, Database.conn);
            //        MySqlDataReader reader = cmd.ExecuteReader();

            //        while (reader.Read())
            //        {
            //            //ComboBox cb = new ComboBox(reader["patientID"].ToString());
            //            //item.SubItems.Add(reader["fullname"].ToString());
            //            //lv.Items.Add(item);


            //        }

            //        reader.Close();

            //    }
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }

        private void addAppointment_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dashboard.addAppointmentCreated = false;
        }

        private void pID_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPatientName();
        }

        void loadPatientName()
        {
            try
            {
                if (Database.Connect())
                {

                    string patientID = pIDBox.Text;
                    string query = $"SELECT fullname FROM patient_record WHERE patientID = {Convert.ToInt16(patientID)}";
                    MySqlCommand cmd = new MySqlCommand(query, Database.conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {

                        pNameBox.Text = reader["fullname"].ToString();

                    }

                    reader.Close();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        void loadPatientID()
        {
            try
            {
                if (Database.Connect())
                {

                    string patientName = pNameBox.Text;
                    string query = $"SELECT patientID FROM patient_record WHERE fullname = '{patientName}'";
                    MySqlCommand cmd = new MySqlCommand(query, Database.conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {

                        pIDBox.Text = reader["patientID"].ToString();

                    }

                    reader.Close();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void pNameBox_Click(object sender, EventArgs e)
        {

        }

        private void pNameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPatientID();
        }
    }
}
