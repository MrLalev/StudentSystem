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
    public partial class AddMark : Form
    {
        public AddMark()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool fNum = true;

            Mark mark = new Mark();

            mark.fNumber = txtFnumber.Text;
            mark.subject = txtSubject.Text;

            StudentRepo repo = new StudentRepo();
            MarkRepo MarkRepo = new MarkRepo();

            List<Student> students = repo.GetAll();
            List<Mark> marks= MarkRepo.GetAll();

            foreach (Student item in students)
            {
                if (item.fNumber != mark.fNumber)
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

            if (comboBoxMark.Text != "")
            {
                 mark.mark = Convert.ToInt32(comboBoxMark.Text);
            }

            Match match = Regex.Match(mark.fNumber, patern);

            if (!match.Success)
            {
                MessageBox.Show("Факултетния номер е с 10 цифри!");
                txtFnumber.Text = null;
                mark.fNumber = null;
            }
            else if (fNum == false)
            {
                MessageBox.Show("Няма студент с такъв факултетен номер!");
                txtFnumber.Text = null;
                mark.fNumber = null;
            }

            if (mark.fNumber != null && txtSubject.Text != "" && comboBoxMark.Text != "")
            {
                MarkRepo.Insert(mark);

                DialogResult result = MessageBox.Show("Данните бяха записани, желаете ли да добавите друга оценка?", "Form Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    txtFnumber.Text = null;
                    txtSubject.Text = null;
                    comboBoxMark.Text = null;
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

        private void AddMark_Load(object sender, EventArgs e)
        {
            comboBoxMark.Items.Add("2");
            comboBoxMark.Items.Add("3");
            comboBoxMark.Items.Add("4");
            comboBoxMark.Items.Add("5");
            comboBoxMark.Items.Add("6");
            comboBoxMark.DropDownHeight = 55;
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
