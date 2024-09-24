namespace DentalClinicApp.Forms
{
    partial class scheduleStatusChanger
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            optionBox = new ComboBox();
            label2 = new Label();
            appointmentID = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 16.2F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(48, 125);
            button1.Name = "button1";
            button1.Size = new Size(131, 46);
            button1.TabIndex = 2;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 16.2F);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(273, 125);
            button2.Name = "button2";
            button2.Size = new Size(126, 46);
            button2.TabIndex = 3;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 60);
            label1.Name = "label1";
            label1.Size = new Size(120, 38);
            label1.TabIndex = 1;
            label1.Text = "Mark as:";
            // 
            // optionBox
            // 
            optionBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            optionBox.FormattingEnabled = true;
            optionBox.Items.AddRange(new object[] { "Done", "Cancelled" });
            optionBox.Location = new Point(183, 61);
            optionBox.Name = "optionBox";
            optionBox.Size = new Size(206, 45);
            optionBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(220, 38);
            label2.TabIndex = 5;
            label2.Text = "Appointment ID:";
            // 
            // appointmentID
            // 
            appointmentID.AutoSize = true;
            appointmentID.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appointmentID.Location = new Point(232, 9);
            appointmentID.Name = "appointmentID";
            appointmentID.Size = new Size(44, 38);
            appointmentID.TabIndex = 6;
            appointmentID.Text = "ID";
            // 
            // scheduleStatusChanger
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 183);
            ControlBox = false;
            Controls.Add(appointmentID);
            Controls.Add(label2);
            Controls.Add(optionBox);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "scheduleStatusChanger";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "scheduleStatusChanger";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Label label1;
        private ComboBox optionBox;
        private Label label2;
        public Label appointmentID;
    }
}