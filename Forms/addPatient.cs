using CrystalDecisions.ReportAppServer.DataDefModel;
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
    public partial class addPatient : Form
    {
        Random random = new Random();
        public addPatient()
        {
            InitializeComponent();
        }

        private void addPatient_Load(object sender, EventArgs e)
        {

            int id = random.Next(1, 99999);
            patientIDBox.Text = id.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = patientIDBox.Text;
            string name = fullnameBox.Text;
            string age = ageBox.Text;
            string address = addressBox.Text;
            string gender = genderBox.Text;
            string contact = contactInfoBox.Text;

            try
            {
                if (Database.Connect() && !string.IsNullOrEmpty(id) && !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(age) && !string.IsNullOrEmpty(address) && !string.IsNullOrEmpty(gender) && !string.IsNullOrEmpty(contact))
                {
                    string query = $"INSERT INTO patient_record(fullname, age,gender, address, contact) VALUES('{name}', {age}, '{gender}', '{address}', '{contact}')";
                    using (MySqlCommand command = new MySqlCommand(query, Database.conn))
                    {
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Patient Added Successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    int Pid = random.Next(1, 99999);
                    patientIDBox.Text = Pid.ToString();
                    fullnameBox.Clear();
                    ageBox.ResetText();
                    addressBox.Clear();
                    genderBox.ResetText();
                    contactInfoBox.ResetText();
                    Dashboard.patient.loadTable();
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






        }

        private void addPatient_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dashboard.addPatientCreated = false;
        }
    }
}
