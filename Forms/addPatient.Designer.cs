namespace DentalClinicApp.Forms
{
    partial class addPatient
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
            addressBox = new TextBox();
            label6 = new Label();
            genderBox = new ComboBox();
            label5 = new Label();
            ageBox = new NumericUpDown();
            label4 = new Label();
            fullnameBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            patientIDBox = new Label();
            label9 = new Label();
            contactInfoBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ageBox).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Green;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 16.2F);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(1118, 256);
            button1.Name = "button1";
            button1.Size = new Size(101, 46);
            button1.TabIndex = 27;
            button1.Text = "SAVE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // addressBox
            // 
            addressBox.Anchor = AnchorStyles.None;
            addressBox.Font = new Font("Microsoft Sans Serif", 16.2F);
            addressBox.Location = new Point(229, 201);
            addressBox.Name = "addressBox";
            addressBox.Size = new Size(990, 38);
            addressBox.TabIndex = 24;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 16.2F);
            label6.Location = new Point(87, 204);
            label6.Name = "label6";
            label6.Size = new Size(118, 32);
            label6.TabIndex = 23;
            label6.Text = "Address";
            // 
            // genderBox
            // 
            genderBox.Anchor = AnchorStyles.None;
            genderBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genderBox.Font = new Font("Microsoft Sans Serif", 16.2F);
            genderBox.FormattingEnabled = true;
            genderBox.Items.AddRange(new object[] { "Male", "Female" });
            genderBox.Location = new Point(1074, 141);
            genderBox.Name = "genderBox";
            genderBox.Size = new Size(145, 39);
            genderBox.TabIndex = 22;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 16.2F);
            label5.Location = new Point(966, 147);
            label5.Name = "label5";
            label5.Size = new Size(109, 32);
            label5.TabIndex = 21;
            label5.Text = "Gender";
            // 
            // ageBox
            // 
            ageBox.Anchor = AnchorStyles.None;
            ageBox.Font = new Font("Microsoft Sans Serif", 16.2F);
            ageBox.Location = new Point(897, 145);
            ageBox.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            ageBox.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ageBox.Name = "ageBox";
            ageBox.Size = new Size(54, 38);
            ageBox.TabIndex = 20;
            ageBox.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 16.2F);
            label4.Location = new Point(826, 147);
            label4.Name = "label4";
            label4.Size = new Size(65, 32);
            label4.TabIndex = 19;
            label4.Text = "Age";
            // 
            // fullnameBox
            // 
            fullnameBox.Anchor = AnchorStyles.None;
            fullnameBox.Font = new Font("Microsoft Sans Serif", 16.2F);
            fullnameBox.Location = new Point(229, 144);
            fullnameBox.Name = "fullnameBox";
            fullnameBox.Size = new Size(591, 38);
            fullnameBox.TabIndex = 18;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(516, 18);
            label3.Name = "label3";
            label3.Size = new Size(304, 46);
            label3.TabIndex = 17;
            label3.Text = "NEW PATIENT";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16.2F);
            label2.Location = new Point(83, 147);
            label2.Name = "label2";
            label2.Size = new Size(132, 32);
            label2.TabIndex = 16;
            label2.Text = "Fullname";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F);
            label1.Location = new Point(238, 86);
            label1.Name = "label1";
            label1.Size = new Size(77, 32);
            label1.TabIndex = 15;
            label1.Text = "P-ID:";
            // 
            // patientIDBox
            // 
            patientIDBox.Anchor = AnchorStyles.None;
            patientIDBox.AutoSize = true;
            patientIDBox.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            patientIDBox.ForeColor = Color.ForestGreen;
            patientIDBox.Location = new Point(321, 87);
            patientIDBox.Name = "patientIDBox";
            patientIDBox.Size = new Size(98, 32);
            patientIDBox.TabIndex = 14;
            patientIDBox.Text = "label1";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 16.2F);
            label9.Location = new Point(57, 264);
            label9.Name = "label9";
            label9.Size = new Size(166, 32);
            label9.TabIndex = 30;
            label9.Text = "Contact Info";
            // 
            // contactInfoBox
            // 
            contactInfoBox.Anchor = AnchorStyles.None;
            contactInfoBox.Font = new Font("Microsoft Sans Serif", 16.2F);
            contactInfoBox.Location = new Point(229, 261);
            contactInfoBox.Name = "contactInfoBox";
            contactInfoBox.Size = new Size(846, 38);
            contactInfoBox.TabIndex = 31;
            // 
            // addPatient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1255, 345);
            Controls.Add(contactInfoBox);
            Controls.Add(label9);
            Controls.Add(button1);
            Controls.Add(addressBox);
            Controls.Add(label6);
            Controls.Add(genderBox);
            Controls.Add(label5);
            Controls.Add(ageBox);
            Controls.Add(label4);
            Controls.Add(fullnameBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(patientIDBox);
            MinimumSize = new Size(1031, 386);
            Name = "addPatient";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosed += addPatient_FormClosed;
            Load += addPatient_Load;
            ((System.ComponentModel.ISupportInitialize)ageBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox addressBox;
        private Label label6;
        private ComboBox genderBox;
        private Label label5;
        private NumericUpDown ageBox;
        private Label label4;
        private TextBox fullnameBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label patientIDBox;
        private Label label9;
        private TextBox contactInfoBox;
    }
}