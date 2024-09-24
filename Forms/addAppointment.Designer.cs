namespace DentalClinicApp.Forms
{
    partial class addAppointment
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
            scheduleBox = new DateTimePicker();
            label8 = new Label();
            button1 = new Button();
            serviceBox = new ComboBox();
            label7 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            patientID = new Label();
            pIDBox = new ComboBox();
            label4 = new Label();
            pNameBox = new ComboBox();
            SuspendLayout();
            // 
            // scheduleBox
            // 
            scheduleBox.CalendarFont = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scheduleBox.DropDownAlign = LeftRightAlignment.Right;
            scheduleBox.Font = new Font("Microsoft Sans Serif", 16.2F);
            scheduleBox.Location = new Point(275, 316);
            scheduleBox.Name = "scheduleBox";
            scheduleBox.Size = new Size(641, 38);
            scheduleBox.TabIndex = 47;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(128, 318);
            label8.Name = "label8";
            label8.Size = new Size(130, 38);
            label8.TabIndex = 46;
            label8.Text = "Schedule";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Green;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 16.2F);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(810, 101);
            button1.Name = "button1";
            button1.Size = new Size(101, 46);
            button1.TabIndex = 45;
            button1.Text = "SAVE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // serviceBox
            // 
            serviceBox.Anchor = AnchorStyles.None;
            serviceBox.DropDownStyle = ComboBoxStyle.DropDownList;
            serviceBox.Font = new Font("Microsoft Sans Serif", 16.2F);
            serviceBox.FormattingEnabled = true;
            serviceBox.Items.AddRange(new object[] { "Regular Check-Ups and Cleanings", "Fluoride Treatments", "Dental Sealants", "Fillings", "Crowns", "Bridges", "Dentures", "Root Canals", "Extractions", "Implants" });
            serviceBox.Location = new Point(275, 265);
            serviceBox.Name = "serviceBox";
            serviceBox.Size = new Size(641, 39);
            serviceBox.TabIndex = 44;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 16.2F);
            label7.Location = new Point(52, 268);
            label7.Name = "label7";
            label7.Size = new Size(211, 32);
            label7.TabIndex = 43;
            label7.Text = "Availed Service";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(326, 23);
            label3.Name = "label3";
            label3.Size = new Size(428, 46);
            label3.TabIndex = 35;
            label3.Text = "NEW APPOINTMENT";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16.2F);
            label2.Location = new Point(159, 210);
            label2.Name = "label2";
            label2.Size = new Size(89, 32);
            label2.TabIndex = 34;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F);
            label1.Location = new Point(187, 108);
            label1.Name = "label1";
            label1.Size = new Size(77, 32);
            label1.TabIndex = 33;
            label1.Text = "A-ID:";
            // 
            // patientID
            // 
            patientID.Anchor = AnchorStyles.None;
            patientID.AutoSize = true;
            patientID.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            patientID.ForeColor = Color.ForestGreen;
            patientID.Location = new Point(270, 109);
            patientID.Name = "patientID";
            patientID.Size = new Size(98, 32);
            patientID.TabIndex = 32;
            patientID.Text = "label1";
            // 
            // pIDBox
            // 
            pIDBox.Anchor = AnchorStyles.None;
            pIDBox.Font = new Font("Microsoft Sans Serif", 16.2F);
            pIDBox.FormattingEnabled = true;
            pIDBox.Location = new Point(275, 153);
            pIDBox.MaxDropDownItems = 2;
            pIDBox.Name = "pIDBox";
            pIDBox.Size = new Size(641, 39);
            pIDBox.TabIndex = 50;
            pIDBox.SelectedIndexChanged += pID_SelectedIndexChanged;
            pIDBox.Click += comboBox1_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 16.2F);
            label4.Location = new Point(131, 153);
            label4.Name = "label4";
            label4.Size = new Size(138, 32);
            label4.TabIndex = 49;
            label4.Text = "Patient ID";
            // 
            // pNameBox
            // 
            pNameBox.Anchor = AnchorStyles.None;
            pNameBox.DropDownHeight = 206;
            pNameBox.Font = new Font("Microsoft Sans Serif", 16.2F);
            pNameBox.FormattingEnabled = true;
            pNameBox.IntegralHeight = false;
            pNameBox.Location = new Point(275, 207);
            pNameBox.MaxDropDownItems = 1;
            pNameBox.Name = "pNameBox";
            pNameBox.Size = new Size(641, 39);
            pNameBox.Sorted = true;
            pNameBox.TabIndex = 51;
            pNameBox.SelectedIndexChanged += pNameBox_SelectedIndexChanged;
            // 
            // addAppointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 397);
            Controls.Add(pNameBox);
            Controls.Add(pIDBox);
            Controls.Add(label4);
            Controls.Add(scheduleBox);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(serviceBox);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(patientID);
            MinimumSize = new Size(1002, 327);
            Name = "addAppointment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addAppointment";
            FormClosed += addAppointment_FormClosed;
            Load += addAppointment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker scheduleBox;
        private Label label8;
        private Button button1;
        private ComboBox serviceBox;
        private Label label7;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label patientID;
        private ComboBox pIDBox;
        private Label label4;
        private ComboBox pNameBox;
    }
}