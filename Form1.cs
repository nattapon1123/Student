using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagement; 


namespace StudentManagement
{
    public partial class Form1 : Form
    {
        private List<Advisor> advisors = new List<Advisor>();

        public Form1()
        {
            InitializeComponent();

            dgvStudents.Columns.Add("studentId", "Student ID");
            dgvStudents.Columns.Add("fullName", "Full Name");
            dgvStudents.Columns.Add("major", "Major");
            dgvStudents.Columns.Add("advisorName", "Advisor Name");
            dgvStudents.Columns.Add("gpa", "GPA");

            advisors = new List<Advisor>();

            Advisor advisor1 = new Advisor("Dr. Smith", "Computer Science");
            Advisor advisor2 = new Advisor("Prof. Johnson", "Mathematics");
            Advisor advisor3 = new Advisor("Dr. Lee", "Biology");
            Advisor advisor4 = new Advisor("Prof. Davis", "Chemistry");
            Advisor advisor5 = new Advisor("Dr. Williams", "Physics");

            advisors.Add(advisor1);
            advisors.Add(advisor2);
            advisors.Add(advisor3);
            advisors.Add(advisor4);
            advisors.Add(advisor5);

            cboAdvisor.Items.Add(advisor1);
            cboAdvisor.Items.Add(advisor2);
            cboAdvisor.Items.Add(advisor3);
            cboAdvisor.Items.Add(advisor4);
            cboAdvisor.Items.Add(advisor5);

            advisor1.AddStudent(new Student("000000000.0", "John Doe", "CS", advisor1, 2.11));
            advisor1.AddStudent(new Student("000000000.0", "Jane Doe", "CS", advisor1, 3.5));
            advisor2.AddStudent(new Student("000000000.0", "Jim Bean", "DS", advisor2, 3.75));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string studentId = txtStudentID.Text;
            string studentName = txtStudentName.Text;
            string studentMajor = txtStudentMajor.Text;
            double studentGPA = 0;

            if (!double.TryParse(txtStudentGPA.Text, out studentGPA))
            {
                MessageBox.Show("กรุณากรอก GPA ที่ถูกต้อง", "ข้อมูลไม่ถูกต้อง", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboAdvisor.SelectedItem != null && cboAdvisor.SelectedItem is Advisor selectedAdvisor)
            {
                Student newStudent = new Student(studentId, studentName, studentMajor, selectedAdvisor, studentGPA);

                selectedAdvisor.AddStudent(newStudent);

                MessageBox.Show("เพิ่มนักศึกษาสำเร็จ", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtStudentID.Clear();
                txtStudentName.Clear();
                txtStudentMajor.Clear();
                txtStudentGPA.Clear();
            }
            else
            {
                MessageBox.Show("กรุณาเลือกอาจารย์ที่ปรึกษา", "ข้อมูลไม่ถูกต้อง", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnShowStudents_Click(object sender, EventArgs e)
        {
            dgvStudents.Rows.Clear();

            foreach (var advisor in advisors)
            {
                foreach (var student in advisor.AdviseeList)
                {
                    dgvStudents.Rows.Add(student.StudentID, student.FullName, student.Major, advisor.Name, student.GPA);
                }

            }
        }

        private void btnShowTopStudent_Click(object sender, EventArgs e)
        {
            Student? topStudent = null;
            double maxGPA = 0;

            foreach (var advisor in advisors)
            {
                foreach (var student in advisor.AdviseeList)
                {
                    if (student.GPA > maxGPA)
                    {
                        maxGPA = student.GPA;
                        topStudent = student;
                    }
                }
            }

            if (topStudent != null)
            {
                MessageBox.Show($"นักศึกษาที่ได้เกรดสูงสุดคือ {topStudent.FullName} (GPA: {topStudent.GPA})", "Top Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ยังไม่มีข้อมูลนักศึกษา", "ข้อมูลไม่พบ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cboAdvisor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddAdvisor_Click(object sender, EventArgs e)
        {
            string newAdvisorName = txtNewAdvisorName.Text;

            if (!string.IsNullOrWhiteSpace(newAdvisorName))
            {
                Advisor newAdvisor = new Advisor(newAdvisorName, "Unknown Major");

                advisors.Add(newAdvisor);
                cboAdvisor.Items.Add(newAdvisor);

                txtNewAdvisorName.Clear();

                MessageBox.Show($"อาจารย์ {newAdvisorName} ได้ถูกเพิ่มเรียบร้อยแล้ว", "เพิ่มอาจารย์", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("กรุณากรอกชื่ออาจารย์", "ข้อมูลไม่ครบถ้วน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
