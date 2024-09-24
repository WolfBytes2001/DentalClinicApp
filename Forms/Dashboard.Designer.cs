namespace DentalClinicApp.Forms
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            menuStrip1 = new MenuStrip();
            managePatientToolStripMenuItem = new ToolStripMenuItem();
            viewPatienToolStripMenuItem = new ToolStripMenuItem();
            addARecordToolStripMenuItem = new ToolStripMenuItem();
            appointmentAndSchedulesToolStripMenuItem = new ToolStripMenuItem();
            schedulesToolStripMenuItem1 = new ToolStripMenuItem();
            newAppointmentToolStripMenuItem = new ToolStripMenuItem();
            billingsAndTransactionsToolStripMenuItem = new ToolStripMenuItem();
            userManagementToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            dashboardPanel = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightSteelBlue;
            menuStrip1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.ImageScalingSize = new Size(50, 50);
            menuStrip1.Items.AddRange(new ToolStripItem[] { managePatientToolStripMenuItem, appointmentAndSchedulesToolStripMenuItem, billingsAndTransactionsToolStripMenuItem, userManagementToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(1072, 46);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // managePatientToolStripMenuItem
            // 
            managePatientToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch;
            managePatientToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewPatienToolStripMenuItem, addARecordToolStripMenuItem });
            managePatientToolStripMenuItem.Name = "managePatientToolStripMenuItem";
            managePatientToolStripMenuItem.Size = new Size(224, 42);
            managePatientToolStripMenuItem.Text = "Manage Patient";
            managePatientToolStripMenuItem.TextDirection = ToolStripTextDirection.Horizontal;
            // 
            // viewPatienToolStripMenuItem
            // 
            viewPatienToolStripMenuItem.Name = "viewPatienToolStripMenuItem";
            viewPatienToolStripMenuItem.Size = new Size(366, 42);
            viewPatienToolStripMenuItem.Text = "View Patient Records";
            viewPatienToolStripMenuItem.Click += viewPatienToolStripMenuItem_Click;
            // 
            // addARecordToolStripMenuItem
            // 
            addARecordToolStripMenuItem.Name = "addARecordToolStripMenuItem";
            addARecordToolStripMenuItem.Size = new Size(366, 42);
            addARecordToolStripMenuItem.Text = "Add Patient";
            addARecordToolStripMenuItem.Click += addARecordToolStripMenuItem_Click;
            // 
            // appointmentAndSchedulesToolStripMenuItem
            // 
            appointmentAndSchedulesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { schedulesToolStripMenuItem1, newAppointmentToolStripMenuItem });
            appointmentAndSchedulesToolStripMenuItem.Name = "appointmentAndSchedulesToolStripMenuItem";
            appointmentAndSchedulesToolStripMenuItem.Size = new Size(380, 42);
            appointmentAndSchedulesToolStripMenuItem.Text = "Appointment and Schedules";
            // 
            // schedulesToolStripMenuItem1
            // 
            schedulesToolStripMenuItem1.Name = "schedulesToolStripMenuItem1";
            schedulesToolStripMenuItem1.Size = new Size(393, 42);
            schedulesToolStripMenuItem1.Text = "View Patient Schedules";
            schedulesToolStripMenuItem1.Click += schedulesToolStripMenuItem1_Click;
            // 
            // newAppointmentToolStripMenuItem
            // 
            newAppointmentToolStripMenuItem.Name = "newAppointmentToolStripMenuItem";
            newAppointmentToolStripMenuItem.Size = new Size(393, 42);
            newAppointmentToolStripMenuItem.Text = "Add Appointment";
            newAppointmentToolStripMenuItem.Click += newAppointmentToolStripMenuItem_Click_1;
            // 
            // billingsAndTransactionsToolStripMenuItem
            // 
            billingsAndTransactionsToolStripMenuItem.Name = "billingsAndTransactionsToolStripMenuItem";
            billingsAndTransactionsToolStripMenuItem.Size = new Size(333, 42);
            billingsAndTransactionsToolStripMenuItem.Text = "Billings and Transactions";
            // 
            // userManagementToolStripMenuItem
            // 
            userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            userManagementToolStripMenuItem.Size = new Size(259, 42);
            userManagementToolStripMenuItem.Text = "User Management";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(14, 42);
            // 
            // dashboardPanel
            // 
            dashboardPanel.BackColor = SystemColors.Control;
            dashboardPanel.BackgroundImageLayout = ImageLayout.Stretch;
            dashboardPanel.Dock = DockStyle.Fill;
            dashboardPanel.Location = new Point(0, 46);
            dashboardPanel.Name = "dashboardPanel";
            dashboardPanel.Size = new Size(1072, 479);
            dashboardPanel.TabIndex = 1;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 525);
            Controls.Add(dashboardPanel);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ADMINISTRATOR DASHBOARD";
            WindowState = FormWindowState.Maximized;
            FormClosed += Dashboard_FormClosed;
            Load += Dashboard_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem managePatientToolStripMenuItem;
        private ToolStripMenuItem addARecordToolStripMenuItem;
        private ToolStripMenuItem viewPatienToolStripMenuItem;
        private ToolStripMenuItem userManagementToolStripMenuItem;
        private Panel dashboardPanel;
        private ToolStripMenuItem appointmentAndSchedulesToolStripMenuItem;
        private ToolStripMenuItem billingsAndTransactionsToolStripMenuItem;
        private ToolStripMenuItem schedulesToolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem newAppointmentToolStripMenuItem;
    }
}