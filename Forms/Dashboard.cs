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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        public static bool isLogin = false;
        public static bool addAppointmentCreated = false;
        public static bool addPatientCreated = false;
        public static patientRecord patient = new patientRecord();
        public static addAppointment addAppointment = new addAppointment();
        public static schedule schedule = new schedule();

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.login1.Close();
        }

        private void recordPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void addARecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (addPatientCreated == false)
            {
                addPatient addNewPatient = new addPatient();

                addNewPatient.Show();
                addPatientCreated = true;
            }
        }

        private void schedulesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            schedule.Dock = DockStyle.Fill;
            dashboardPanel.Controls.Clear();
            dashboardPanel.Controls.Add(schedule);

            schedule.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void newAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

            addAppointment.Show();
        }

        private void schedulesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            schedule.Dock = DockStyle.Fill;
            dashboardPanel.Controls.Clear();
            dashboardPanel.Controls.Add(schedule);

            schedule.Show();
        }

        private void newAppointmentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (addAppointmentCreated == false)
            {
                addAppointment appointment = new addAppointment();
                appointment.Show();
                addAppointmentCreated = true;
            }
        }

        private void viewPatienToolStripMenuItem_Click(object sender, EventArgs e)
        {


            patient.Dock = DockStyle.Fill;
            dashboardPanel.Controls.Clear();
            dashboardPanel.Controls.Add(patient);
            patient.Show();


        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
