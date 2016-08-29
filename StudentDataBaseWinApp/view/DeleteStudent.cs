using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentDataBaseWinApp.Repo;
using StudentDataBaseWinApp.Enteties;
using System.IO;

namespace StudentDataBaseWinApp.view
{
    public partial class DeleteStudent : Form
    {
        public DeleteStudent()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id;

            StudentRepo StudentRepo = new StudentRepo();
            MarkRepo MarkRepo = new MarkRepo();

            List<Student> students = StudentRepo.GetAll();
            List<Mark> marks = MarkRepo.GetAll();

            Student student = new Student();

            if (comboBoxId.Text != "")
            {
                    id = Convert.ToInt32(comboBoxId.Text);
                    foreach (Student item in students)
                    {
                        if (item.Id == id)
                        {
                            student = item;
                            File.Delete(item.Photo);
                        } 
                    }
                    StudentRepo.Delete(id);
                    
                    foreach (Mark mark in marks)
	                {
                        if (student.fNumber == mark.fNumber)
                        {
                            MarkRepo.Delete(mark.Id);
                        }
	                }

                    DialogResult result = MessageBox.Show("Данните бяха изтрити, желаете ли да изтриете друг студент?", "Form Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        comboBoxId.Items.Remove(id);
                        comboBoxId.Text = "";
                        txtName.Text = "";
                        txtFnumber.Text = "";
                        txtSpec.Text = "";
                        comboBoxCourse.Text = "";
                        textBoxEmail.Text = "";
                        textBoxEgn.Text = "";
                        comboBoxGender.Text = "";
                        textBoxAverageMark.Text = "";
                        string defaultPhoto = Application.StartupPath + @"\Students\default.jpeg";
                        using (FileStream fs = new FileStream(defaultPhoto, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                        {
                            byte[] buffer = new byte[fs.Length];
                            fs.Read(buffer, 0, (int)fs.Length);
                            using (MemoryStream ms = new MemoryStream(buffer))
                                this.pictureBoxPhoto.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        this.Close();
                    } 
            }
            else
            {
                MessageBox.Show("Не може да оставяте празни полета!");
            }
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteStudent_Load(object sender, EventArgs e)
        {
            StudentRepo StudentRepo = new StudentRepo();
            List<Student> students = StudentRepo.GetAll();

            foreach (Student item in students)
            {
                comboBoxId.Items.Add(item.Id);
            }

            comboBoxId.DropDownHeight = 55;
        }

        private void comboBoxId_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudentRepo StudentRepo = new StudentRepo();
            MarkRepo MarkRepo = new MarkRepo();

            List<Student> students = StudentRepo.GetAll();
            List<Mark> marks = MarkRepo.GetAll();

            double Allmarks = 0;
            double count = 0;
            double average = 0;

            Student student = new Student();

            foreach (Student item in students)
            {
                if (Convert.ToInt32(comboBoxId.Text) == item.Id)
                {
                    student = item;
                }
            }

            foreach (Mark mark in marks)
            {
                if (mark.fNumber == student.fNumber)
                {
                    Allmarks += mark.mark;
                    count++;
                }
            }

            if (count != 0)
            {
                average = Math.Round(Allmarks / count,2);
            }


            txtName.Text = student.FullName;
            txtFnumber.Text = student.fNumber;
            txtSpec.Text = student.spec;
            comboBoxCourse.Text = student.course.ToString();
            textBoxEmail.Text = student.Email;
            textBoxEgn.Text = student.Egn;
            comboBoxGender.Text = student.Gender;
            textBoxAverageMark.Text = average.ToString();

            using (FileStream fs = new FileStream(student.Photo, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer, 0, (int)fs.Length);
                using (MemoryStream ms = new MemoryStream(buffer))
                    this.pictureBoxPhoto.Image = Image.FromStream(ms);
            }

        }

    }
}
