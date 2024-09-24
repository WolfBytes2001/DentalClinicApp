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

namespace DentalClinicApp.Forms.Patient
{
    public partial class patientUpdate : Form
    {
        public patientUpdate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(patientIDBox.Text);
            string fullname = fullnameBox.Text;
            string age = ageBox.Text;
            string gender = genderBox.Text;
            string address = addressBox.Text;
            string contact = contactInfoBox.Text;

            try
            {
                if (Database.Connect())
                {
                    string query = $"UPDATE patient_record SET fullname='{fullname}' , age = '{age}', gender = '{gender}', address = '{address}', contact = '{contact}' WHERE patientID = {id}";
                    using (MySqlCommand cmd = new MySqlCommand(query, Database.conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Patient Record Updated Successfully");
                    Dashboard.patient.loadTable();
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

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
