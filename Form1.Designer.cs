namespace StudentManagement
{
    partial class Form1
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
            btnAddStudent = new Button();
            btnShowStudents = new Button();
            btnShowTopStudent = new Button();
            txtStudentID = new TextBox();
            txtStudentName = new TextBox();
            txtStudentMajor = new TextBox();
            txtStudentGPA = new TextBox();
            cboAdvisor = new ComboBox();
            dgvStudents = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNewAdvisorName = new TextBox();
            btnAddAdvisor = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(3, -1);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(147, 61);
            btnAddStudent.TabIndex = 0;
            btnAddStudent.Text = "บันทึกข้อมูล";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += button1_Click;
            // 
            // btnShowStudents
            // 
            btnShowStudents.Location = new Point(390, 65);
            btnShowStudents.Name = "btnShowStudents";
            btnShowStudents.Size = new Size(166, 81);
            btnShowStudents.TabIndex = 1;
            btnShowStudents.Text = "แสดงข้อมูลนักศึกษา";
            btnShowStudents.UseVisualStyleBackColor = true;
            btnShowStudents.Click += btnShowStudents_Click;
            // 
            // btnShowTopStudent
            // 
            btnShowTopStudent.Location = new Point(562, 65);
            btnShowTopStudent.Name = "btnShowTopStudent";
            btnShowTopStudent.Size = new Size(153, 81);
            btnShowTopStudent.TabIndex = 2;
            btnShowTopStudent.Text = "แสดงคนที่ได้เกรดสูงสุด";
            btnShowTopStudent.UseVisualStyleBackColor = true;
            btnShowTopStudent.Click += btnShowTopStudent_Click;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(12, 66);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(125, 27);
            txtStudentID.TabIndex = 3;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(12, 99);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(125, 27);
            txtStudentName.TabIndex = 4;
            // 
            // txtStudentMajor
            // 
            txtStudentMajor.Location = new Point(12, 132);
            txtStudentMajor.Name = "txtStudentMajor";
            txtStudentMajor.Size = new Size(125, 27);
            txtStudentMajor.TabIndex = 5;
            // 
            // txtStudentGPA
            // 
            txtStudentGPA.Location = new Point(12, 165);
            txtStudentGPA.Name = "txtStudentGPA";
            txtStudentGPA.Size = new Size(125, 27);
            txtStudentGPA.TabIndex = 6;
            // 
            // cboAdvisor
            // 
            cboAdvisor.FormattingEnabled = true;
            cboAdvisor.Location = new Point(9, 274);
            cboAdvisor.Name = "cboAdvisor";
            cboAdvisor.Size = new Size(151, 28);
            cboAdvisor.TabIndex = 7;
            cboAdvisor.SelectedIndexChanged += cboAdvisor_SelectedIndexChanged;
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(304, 168);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.Size = new Size(484, 270);
            dgvStudents.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(161, 70);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 9;
            label1.Text = "ใส่รหัสนักศึกษา";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(161, 102);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 10;
            label2.Text = "ใส่ชื่อนักศึกษา";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(161, 135);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 11;
            label3.Text = "ใส่สาขา";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(161, 172);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 12;
            label4.Text = "ใส่เกรดเฉลี่ย";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 251);
            label5.Name = "label5";
            label5.Size = new Size(132, 20);
            label5.TabIndex = 13;
            label5.Text = "เลือกอาจารย์ที่ปรึกษา";
            // 
            // txtNewAdvisorName
            // 
            txtNewAdvisorName.Location = new Point(12, 213);
            txtNewAdvisorName.Name = "txtNewAdvisorName";
            txtNewAdvisorName.Size = new Size(125, 27);
            txtNewAdvisorName.TabIndex = 14;
            // 
            // btnAddAdvisor
            // 
            btnAddAdvisor.Location = new Point(143, 213);
            btnAddAdvisor.Name = "btnAddAdvisor";
            btnAddAdvisor.Size = new Size(98, 32);
            btnAddAdvisor.TabIndex = 15;
            btnAddAdvisor.Text = "ใส่ชื่ออาจารย์";
            btnAddAdvisor.UseVisualStyleBackColor = true;
            btnAddAdvisor.Click += btnAddAdvisor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddAdvisor);
            Controls.Add(txtNewAdvisorName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvStudents);
            Controls.Add(cboAdvisor);
            Controls.Add(txtStudentGPA);
            Controls.Add(txtStudentMajor);
            Controls.Add(txtStudentName);
            Controls.Add(txtStudentID);
            Controls.Add(btnShowTopStudent);
            Controls.Add(btnShowStudents);
            Controls.Add(btnAddStudent);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddStudent;
        private Button btnShowStudents;
        private Button btnShowTopStudent;
        private TextBox txtStudentID;
        private TextBox txtStudentName;
        private TextBox txtStudentMajor;
        private TextBox txtStudentGPA;
        private ComboBox cboAdvisor;
        private DataGridView dgvStudents;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNewAdvisorName;
        private Button btnAddAdvisor;
    }
}