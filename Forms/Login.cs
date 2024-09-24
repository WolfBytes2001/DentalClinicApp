using DentalClinicApp.Forms;

namespace DentalClinicApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

   

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(textBox1.Text == "1" && textBox2.Text == "1")
            {

                Dashboard dashboard = new Dashboard();
                Program.login1.Hide();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Access Denied!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
