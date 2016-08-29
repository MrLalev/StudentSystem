using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentDataBaseWinApp.Enteties;
using StudentDataBaseWinApp.Repo;
using StudentDataBaseWinApp.view;
using System.Text.RegularExpressions;
using System.IO;

namespace StudentDataBaseWinApp.view
{
    public partial class EditStudent : Form
    {
        public EditStudent()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool fNum = true;

            StudentRepo repo = new StudentRepo();
            List<Student> students = repo.GetAll();

            Student student = new Student();
            student.FullName = txtName.Text;
            student.fNumber = txtFnumber.Text;
            student.spec = txtSpec.Text;
            student.Egn = textBoxEgn.Text;
            student.Email = textBoxEmail.Text;
           
            foreach (Student item in students)
            {
                if (item.fNumber != student.fNumber)
                    {
                        fNum = false;
                    }
                    else
                    {
                        fNum = true;
                        break;
                    }
            }

            string patern = "^\\d{10}$";

            if (comboBoxId.Text != "")
            {
                student.Id = Convert.ToInt32(comboBoxId.Text);
            }


            if (comboBoxGender.Text != "")
            {
                student.Gender = comboBoxGender.Text;
            }

            if (comboBoxCourse.Text != "")
            {
                student.course = Convert.ToInt32(comboBoxCourse.Text);
            }

            if (textBoxAverageMark.Text !="")
            {
                 student.AverageMark = Convert.ToDouble(textBoxAverageMark.Text);
            }

            Match match1 = Regex.Match(student.Egn, patern);

            if (!match1.Success)
            {
                MessageBox.Show("ЕГН се състои от 10 цифри!");
                textBoxEgn.Text = null;
                student.Egn = null;
            }

            if (comboBoxId.Text != "" && comboBoxCourse.Text != "" && txtName.Text != "" && txtFnumber.Text != "" && txtSpec.Text != "" && textBoxEgn.Text!="" && textBoxEmail.Text != "" && comboBoxGender.Text != "")
            {
                string pictureFlie = Application.StartupPath + @"\Students\" + student.fNumber + ".jpg";
                student.Photo = pictureFlie;
                if (textBoxPicturePath.Text != student.Photo)
                {
                    try
                    {
                        File.Delete(pictureFlie);
                        File.Copy(@textBoxPicturePath.Text, pictureFlie);
                    }
                    catch (Exception)
                    {
                        File.Copy(@textBoxPicturePath.Text, pictureFlie);
                    }
                }
                

                repo.Edit(student);

                DialogResult result = MessageBox.Show("Данните бяха редактирани, желаете ли да редактирате друг студент?", "Form Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    comboBoxId.Text = ""; 
                    txtName.Text = null;
                    txtSpec.Text = null;
                    txtFnumber.Text = null;
                    comboBoxCourse.Text = "";
                    textBoxEgn.Text = "";
                    string defaultPhoto = Application.StartupPath + @"\Students\default.jpeg";
                    using (FileStream fs = new FileStream(defaultPhoto, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        byte[] buffer1 = new byte[fs.Length];
                        fs.Read(buffer1, 0, (int)fs.Length);
                        using (MemoryStream ms = new MemoryStream(buffer1))
                        this.pictureBoxPhoto.Image = Image.FromStream(ms);
                    }
                    textBoxAverageMark.Text = "";
                    textBoxEmail.Text = "";
                    textBoxPicturePath.Text = "";
                    comboBoxGender.Text = "";
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void EditStudent_Load(object sender, EventArgs e)
        {
            StudentRepo repo = new StudentRepo();
            List<Student> students = repo.GetAll();

            foreach (Student item in students)
            {
                comboBoxId.Items.Add(item.Id);
            }

            comboBoxId.DropDownHeight = 55;
            comboBoxCourse.Items.Add("1");
            comboBoxCourse.Items.Add("2");
            comboBoxCourse.Items.Add("3");
            comboBoxCourse.Items.Add("4");
            comboBoxGender.Items.Add("жена");
            comboBoxGender.Items.Add("мъж");
        }

        private void comboBoxId_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudentRepo repo = new StudentRepo();
            List<Student> students = repo.GetAll();
            MarkRepo MarkRepo = new MarkRepo();
            List<Mark> marks = MarkRepo.GetAll();

            double Allmarks = 0;
            double count = 0;

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

            double average = 0;

            if (count != 0)
            {
                average = Math.Round(Allmarks / count, 2);
            }
            

            txtFnumber.Text = student.fNumber;
            txtName.Text = student.FullName;
            txtSpec.Text = student.spec;
            comboBoxCourse.Text = student.course.ToString();
            textBoxEgn.Text = student.Egn;
            textBoxPicturePath.Text = student.Photo;
            textBoxAverageMark.Text = average.ToString();
            textBoxEmail.Text = student.Email;
            comboBoxGender.Text = student.Gender;

            using (FileStream fs = new FileStream(student.Photo, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer, 0, (int)fs.Length);
                using (MemoryStream ms = new MemoryStream(buffer))
                this.pictureBoxPhoto.Image = Image.FromStream(ms);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxPicturePath.Text = fileDialog.FileName;
                pictureBoxPhoto.Image = new Bitmap(fileDialog.FileName);
            }
        }

        private void textBoxEgn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
