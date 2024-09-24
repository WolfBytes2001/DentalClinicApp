namespace DentalClinicApp.Forms
{
    partial class schedule
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            panel1 = new Panel();
            button1 = new Button();
            label2 = new Label();
            searchBar = new RichTextBox();
            label1 = new Label();
            panel2 = new Panel();
            scheduleTable = new DataGridView();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scheduleTable).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.Font = new Font("Segoe UI", 16.2F);
            dateTimePicker1.Location = new Point(500, 15);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(428, 43);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.DarkOrange;
            button2.Font = new Font("Segoe UI", 16.2F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1141, 9);
            button2.Name = "button2";
            button2.Size = new Size(205, 50);
            button2.TabIndex = 4;
            button2.Text = "Change Status";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(searchBar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1364, 128);
            panel1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.RoyalBlue;
            button1.Font = new Font("Segoe UI", 16.2F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1141, 65);
            button1.Name = "button1";
            button1.Size = new Size(205, 50);
            button1.TabIndex = 12;
            button1.Text = "Payment";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(211, 67);
            label2.Name = "label2";
            label2.Size = new Size(104, 38);
            label2.TabIndex = 11;
            label2.Text = "Search";
            // 
            // searchBar
            // 
            searchBar.Anchor = AnchorStyles.Top;
            searchBar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBar.Location = new Point(321, 60);
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(789, 52);
            searchBar.TabIndex = 10;
            searchBar.Text = "";
            searchBar.TextChanged += searchBar_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(513, 3);
            label1.Name = "label1";
            label1.Size = new Size(415, 54);
            label1.TabIndex = 5;
            label1.Text = "PATIENT SCHEDULES";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(scheduleTable);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 128);
            panel2.Name = "panel2";
            panel2.Size = new Size(1364, 548);
            panel2.TabIndex = 6;
            // 
            // scheduleTable
            // 
            scheduleTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            scheduleTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            scheduleTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            scheduleTable.DefaultCellStyle = dataGridViewCellStyle2;
            scheduleTable.Dock = DockStyle.Fill;
            scheduleTable.Location = new Point(0, 0);
            scheduleTable.Name = "scheduleTable";
            scheduleTable.RowHeadersWidth = 51;
            scheduleTable.Size = new Size(1364, 548);
            scheduleTable.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(dateTimePicker1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 676);
            panel3.Name = "panel3";
            panel3.Size = new Size(1364, 71);
            panel3.TabIndex = 7;
            // 
            // schedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "schedule";
            Size = new Size(1364, 747);
            Load += schedule_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scheduleTable).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button button2;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private DataGridView scheduleTable;
        private Panel panel3;
        private Label label2;
        private RichTextBox searchBar;
        private Button button1;
    }
}
