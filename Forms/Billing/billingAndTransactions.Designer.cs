namespace DentalClinicApp.Forms.Billing
{
    partial class billingAndTransactions
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
            label1 = new Label();
            paymentBox = new ComboBox();
            label2 = new Label();
            amountBox = new TextBox();
            label3 = new Label();
            serviceFeeBox = new TextBox();
            balanceBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            appointmentIDBox = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 66);
            label1.Name = "label1";
            label1.Size = new Size(217, 38);
            label1.TabIndex = 0;
            label1.Text = "Payment Option";
            // 
            // paymentBox
            // 
            paymentBox.FlatStyle = FlatStyle.Popup;
            paymentBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            paymentBox.FormattingEnabled = true;
            paymentBox.Items.AddRange(new object[] { "Full", "Partial" });
            paymentBox.Location = new Point(259, 63);
            paymentBox.Name = "paymentBox";
            paymentBox.Size = new Size(382, 45);
            paymentBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(124, 191);
            label2.Name = "label2";
            label2.Size = new Size(116, 38);
            label2.TabIndex = 2;
            label2.Text = "Amount";
            // 
            // amountBox
            // 
            amountBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            amountBox.Location = new Point(259, 191);
            amountBox.Name = "amountBox";
            amountBox.Size = new Size(382, 43);
            amountBox.TabIndex = 3;
            amountBox.Text = "00";
            amountBox.TextChanged += amountBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(87, 123);
            label3.Name = "label3";
            label3.Size = new Size(157, 38);
            label3.TabIndex = 4;
            label3.Text = "Service Fee";
            // 
            // serviceFeeBox
            // 
            serviceFeeBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            serviceFeeBox.Location = new Point(259, 123);
            serviceFeeBox.Name = "serviceFeeBox";
            serviceFeeBox.PlaceholderText = "hhhhh";
            serviceFeeBox.Size = new Size(382, 43);
            serviceFeeBox.TabIndex = 5;
            serviceFeeBox.Text = "00";
            serviceFeeBox.TextChanged += serviceFeeBox_TextChanged;
            // 
            // balanceBox
            // 
            balanceBox.BackColor = SystemColors.Window;
            balanceBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            balanceBox.Location = new Point(259, 257);
            balanceBox.Name = "balanceBox";
            balanceBox.ReadOnly = true;
            balanceBox.Size = new Size(382, 43);
            balanceBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(128, 257);
            label4.Name = "label4";
            label4.Size = new Size(112, 38);
            label4.TabIndex = 6;
            label4.Text = "Balance";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(36, 9);
            label5.Name = "label5";
            label5.Size = new Size(220, 38);
            label5.TabIndex = 8;
            label5.Text = "Appointment ID:";
            // 
            // appointmentIDBox
            // 
            appointmentIDBox.AutoSize = true;
            appointmentIDBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appointmentIDBox.Location = new Point(262, 9);
            appointmentIDBox.Name = "appointmentIDBox";
            appointmentIDBox.Size = new Size(220, 38);
            appointmentIDBox.TabIndex = 9;
            appointmentIDBox.Text = "Appointment ID:";
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(296, 319);
            button1.Name = "button1";
            button1.Size = new Size(116, 38);
            button1.TabIndex = 10;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // billingAndTransactions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 369);
            Controls.Add(button1);
            Controls.Add(appointmentIDBox);
            Controls.Add(label5);
            Controls.Add(balanceBox);
            Controls.Add(label4);
            Controls.Add(serviceFeeBox);
            Controls.Add(label3);
            Controls.Add(amountBox);
            Controls.Add(label2);
            Controls.Add(paymentBox);
            Controls.Add(label1);
            Name = "billingAndTransactions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox paymentBox;
        private Label label2;
        private TextBox amountBox;
        private Label label3;
        private TextBox serviceFeeBox;
        private TextBox balanceBox;
        private Label label4;
        private Label label5;
        public Label appointmentIDBox;
        private Button button1;
    }
}