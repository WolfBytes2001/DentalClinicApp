namespace DentalClinicApp
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16.2F);
            textBox1.Location = new Point(52, 85);
            textBox1.Margin = new Padding(6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(480, 43);
            textBox1.TabIndex = 0;
            textBox1.Click += textBox1_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 16.2F);
            textBox2.Location = new Point(52, 187);
            textBox2.Margin = new Padding(6);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(480, 43);
            textBox2.TabIndex = 1;
            textBox2.Click += textBox2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16.2F);
            button1.Location = new Point(201, 242);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(176, 54);
            button1.TabIndex = 2;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 41);
            label1.Name = "label1";
            label1.Size = new Size(142, 38);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 143);
            label2.Name = "label2";
            label2.Size = new Size(132, 38);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(583, 318);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Font = new Font("Segoe UI", 16.2F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            Margin = new Padding(6);
            MaximumSize = new Size(601, 365);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Authentication";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}
