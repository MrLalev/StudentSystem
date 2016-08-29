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
using System.Text.RegularExpressions;

namespace StudentDataBaseWinApp.view
{
    public partial class EditMark : Form
    {
        public EditMark()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool fNum = true;

            Mark mark = new Mark();
            mark.fNumber = txtFnumber.Text;
            mark.subject = txtSubject.Text;

            MarkRepo repo = new MarkRepo();
            List<Mark> marks = repo.GetAll();


            foreach (Mark item in marks)
            {
                if (item.fNumber != mark.fNumber)
                {
                    fNum = false;
                }
                else
                {
                    fNum = true;
                }
            }

            string patern = "^\\d{10}$";

            if (comboBoxMark.Text != "")
            {
                mark.mark = Convert.ToInt32(comboBoxMark.Text);
            }

            if (comboBoxId.Text != "")
            {
                mark.Id = Convert.ToInt32(comboBoxId.Text);
            }

            Match match = Regex.Match(mark.fNumber, patern);

            if (!match.Success)
            {
                MessageBox.Show("Факултетния номер е от 10 цифри!");
                txtFnumber.Text = null;
                mark.fNumber = null;
            }
            else if (fNum == false)
            {
                MessageBox.Show("Няма студент с такъв факултетен номер!");
                txtFnumber.Text = null;
                mark.fNumber = null;
            }

            if (comboBoxId.Text != "" && txtSubject.Text != "" && txtFnumber.Text != "" && comboBoxMark.Text != "")
            {
                repo.Edit(mark);

                DialogResult result = MessageBox.Show("Данните бяха редактирани, желаете ли да редактирате друга оценка?", "Form Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    comboBoxMark.Text = "";
                    comboBoxId.Text = "";
                    txtFnumber.Text = null;
                    txtSubject.Text = null;
                    labelStudentName.Text = "";
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

        private void EditMark_Load(object sender, EventArgs e)
        {
            MarkRepo repo = new MarkRepo();
            List<Mark> marks = repo.GetAll();

            foreach (Mark item in marks)
            {
                comboBoxId.Items.Add(item.Id);
            }
            comboBoxId.DropDownHeight = 55;
            comboBoxMark.DropDownHeight = 55;
            comboBoxMark.Items.Add("2");
            comboBoxMark.Items.Add("3");
            comboBoxMark.Items.Add("4");
            comboBoxMark.Items.Add("5");
            comboBoxMark.Items.Add("6");
        }

        private void comboBoxId_SelectedIndexChanged(object sender, EventArgs e)
        {

            MarkRepo repo = new MarkRepo();
            List<Mark> marks = repo.GetAll();

            StudentRepo studentRepo = new StudentRepo();
            List<Student> students = studentRepo.GetAll();

            Mark mark = new Mark();

            foreach (Mark item in marks)
	        {
                if (Convert.ToInt32(comboBoxId.Text) == item.Id)
                {
                    mark = item;
                }
	        }

            txtSubject.Text = mark.subject;
            txtFnumber.Text = mark.fNumber;
            comboBoxMark.Text = mark.mark.ToString();

            foreach (Student item in students)
            {
                if (mark.fNumber == item.fNumber)
                {
                    labelStudentName.Width = 200;
                    labelStudentName.Text = item.FullName;
                }
            }
        }

        private void txtFnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
