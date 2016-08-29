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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool fNum = false;
            bool egn = false;

            StudentRepo repo = new StudentRepo();
            List<Student> students = repo.GetAll();

            Student student = new Student();

            student.FullName = txtName.Text;
            student.fNumber = txtFnumber.Text;
            student.spec = txtSpec.Text;
            student.Egn = textBoxEgn.Text;
            student.Email = textBoxEmail.Text;
            student.AverageMark = Convert.ToDouble(textBoxAverageMark.Text);

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

            foreach (Student item in students)
            {
                if (item.Egn != student.Egn)
                {
                    egn = false;
                }
                else
                {
                    egn = true;
                    break;
                }
            }

            string patern = "^\\d{10}$";

            if (comboBoxCourse.Text != "" )
            {
                student.course = Convert.ToInt32(comboBoxCourse.Text);
            }

            if (comboBoxGender.Text != "")
            {
                student.Gender = comboBoxGender.Text;
            }

            Match match = Regex.Match(student.fNumber, patern);

            if (!match.Success)
            {
                MessageBox.Show("Факултетния номер е с 10 цифри!");
                txtFnumber.Text = null;
                student.fNumber = null;
            }
            else if (fNum == true)
            {
                MessageBox.Show("Вече има студент с такъв факултетен номер!");
                txtFnumber.Text = null;
                student.fNumber = null;
            }

            Match match1 = Regex.Match(student.Egn,patern);

            if (!match1.Success)
            {
                MessageBox.Show("ЕГН е с 10 цифри!");
                textBoxEgn.Text = null;
                student.Egn = null;
            }
            else if (egn == true)
            {
                MessageBox.Show("Вече има студент с такова ЕГН!");
                textBoxEgn.Text = null;
                student.Egn = null;
            }

            string pictureFlie = Application.StartupPath + @"\Students\" + student.fNumber + ".jpg";
            student.Photo = pictureFlie;

            if (txtName.Text != "" && txtFnumber.Text != "" && txtSpec.Text != "" && comboBoxCourse.Text != "" && textBoxEgn.Text != "" && textBoxEmail.Text != "" && comboBoxGender.Text != "")
            {
                if (textBoxPicturePath.Text != "")
                {
                    File.Copy(@textBoxPicturePath.Text, pictureFlie);
                }
                else
                {
                    File.Copy(Application.StartupPath + @"\Students\default.jpeg", pictureFlie);
                }

                repo.Insert(student);

                DialogResult result = MessageBox.Show("Данните бяха записани, желаете ли да добавите друг студент?", "Form Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    txtName.Text = null;
                    txtSpec.Text = null;
                    txtFnumber.Text = null;
                    comboBoxCourse.Text = "";
                    comboBoxGender.Text = "";
                    textBoxEmail.Text = null;
                    textBoxPicturePath.Text = "";
                    textBoxEgn.Text = "";
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            comboBoxCourse.Items.Add("1");
            comboBoxCourse.Items.Add("2");
            comboBoxCourse.Items.Add("3");
            comboBoxCourse.Items.Add("4");
            textBoxAverageMark.Text = "0";
            comboBoxGender.Items.Add("жена");
            comboBoxGender.Items.Add("мъж");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxPicturePath.Text = fileDialog.FileName;
                pictureBoxPhoto.Image = new Bitmap(textBoxPicturePath.Text);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtFnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
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
