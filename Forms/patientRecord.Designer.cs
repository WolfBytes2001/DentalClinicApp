namespace DentalClinicApp.Forms
{
    partial class patientRecord
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            searchBar = new RichTextBox();
            label1 = new Label();
            panel2 = new Panel();
            patientRecordTable = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)patientRecordTable).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(searchBar);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1387, 141);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(1245, 74);
            button2.Name = "button2";
            button2.Size = new Size(119, 50);
            button2.TabIndex = 11;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.DarkOrange;
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(1120, 73);
            button1.Name = "button1";
            button1.Size = new Size(119, 50);
            button1.TabIndex = 10;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(191, 85);
            label2.Name = "label2";
            label2.Size = new Size(104, 38);
            label2.TabIndex = 9;
            label2.Text = "Search";
            // 
            // searchBar
            // 
            searchBar.Anchor = AnchorStyles.Top;
            searchBar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBar.Location = new Point(301, 78);
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(798, 52);
            searchBar.TabIndex = 8;
            searchBar.Text = "";
            searchBar.TextChanged += richTextBox1_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(530, 12);
            label1.Name = "label1";
            label1.Size = new Size(352, 54);
            label1.TabIndex = 7;
            label1.Text = "PATIENT RECORD";
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 603);
            panel2.Name = "panel2";
            panel2.Size = new Size(1387, 35);
            panel2.TabIndex = 1;
            // 
            // patientRecordTable
            // 
            patientRecordTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            patientRecordTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            patientRecordTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            patientRecordTable.DefaultCellStyle = dataGridViewCellStyle1;
            patientRecordTable.Dock = DockStyle.Fill;
            patientRecordTable.Location = new Point(0, 141);
            patientRecordTable.Name = "patientRecordTable";
            patientRecordTable.RowHeadersWidth = 51;
            patientRecordTable.Size = new Size(1387, 462);
            patientRecordTable.TabIndex = 2;
            // 
            // patientRecord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(patientRecordTable);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "patientRecord";
            Size = new Size(1387, 638);
            Load += patientRecord_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)patientRecordTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private DataGridView patientRecordTable;
        private RichTextBox searchBar;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}
