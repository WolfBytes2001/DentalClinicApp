using DentalClinicApp.Forms.Patient;
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
    public partial class patientRecord : UserControl
    {
        public patientRecord()
        {
            InitializeComponent();
        }

        public void patientRecord_Load(object sender, EventArgs e)
        {
            loadTable();
        }
        public void loadTable()
        {
            Database.loadDataGridView(patientRecordTable, "CALL patientRecord_readAll()");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
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
                        string query = $"SELECT patient_record.patientID, patient_record.fullname, patient_record.age, patient_record.gender,patient_record.address, patient_record.contact FROM patient_record WHERE fullname like '%{keyword}%' OR address like '%{keyword}%' OR age like '%{keyword}%' OR patientID like '%{keyword}%' ";
                        Database.loadDataGridView(patientRecordTable, query);

                    }
                }
                else
                {
                    Database.loadDataGridView(patientRecordTable, "CALL patientRecord_readAll()");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updatePatient();
        }

        void updatePatient()
        {
            patientUpdate patientUpdate = new patientUpdate();

            if (patientRecordTable.Rows.Count > 0)
            {
                int selectedRowIndex = patientRecordTable.CurrentRow.Index;
                string? patientID = patientRecordTable.Rows[selectedRowIndex].Cells[0].Value.ToString();

                try
                {
                    if (Database.Connect())
                    {
                        string query = $"SELECT * FROM patient_record WHERE patientID = {patientID}";
                        using (MySqlCommand cmd = new MySqlCommand(query, Database.conn))
                        {

                            MySqlDataReader reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                patientUpdate.patientIDBox.Text = reader["patientID"].ToString();
                                patientUpdate.fullnameBox.Text = reader["fullname"].ToString();
                                patientUpdate.ageBox.Text = reader["age"].ToString();
                                patientUpdate.genderBox.Text = reader["gender"].ToString();
                                patientUpdate.addressBox.Text = reader["address"].ToString();
                                patientUpdate.contactInfoBox.Text = reader["contact"].ToString();
                            }
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
                    patientUpdate.Show();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (patientRecordTable.Rows.Count > 0)
            {
                int selectedRowIndex = patientRecordTable.CurrentRow.Index;
                string? patientID = patientRecordTable.Rows[selectedRowIndex].Cells[0].Value.ToString();
                DialogResult resultDialog =  MessageBox.Show($"Are you sure you want to delete this patient record:{patientID}?", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                
                if(resultDialog == DialogResult.OK)
                {
                    try
                    {
                        if(Database.Connect())
                        {
                            string query = $"DELETE FROM patient_record WHERE patientID = {patientID}";
                            using(MySqlCommand cmd = new MySqlCommand(query,Database.conn))
                            {
                                cmd.ExecuteNonQuery();
                            }
                            MessageBox.Show($"Patient:{patientID} Deleted Sucessfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            Database.loadDataGridView(patientRecordTable, "CALL patientRecord_readAll()");
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
        }
    }
}
