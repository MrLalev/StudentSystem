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

namespace StudentDataBaseWinApp.view
{
    public partial class DeleteMark : Form
    {
        public DeleteMark()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MarkRepo repo = new MarkRepo();
            int id;

            if (comboBoxId.Text != "")
            {
                    id = Convert.ToInt32(comboBoxId.Text);

                    repo.Delete(id);

                    DialogResult result = MessageBox.Show("Данните бяха изтрити, желаете ли да изтриете друга оценка?", "Form Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        comboBoxId.Items.Remove(id);
                        comboBoxId.Text = "";
                        labelFnum.Text = "";
                        labelMark.Text = "";
                        labelDisc.Text = "";
                        labelStudentName.Text = "";
                    }
                    else
                    {
                        this.Close();
                    }
            }
            else
            {
                MessageBox.Show("Не може да оставяте празни полета !");
            }
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteMark_Load(object sender, EventArgs e)
        {
            MarkRepo repo = new MarkRepo();
            List<Mark> marks = repo.GetAll();

            foreach (Mark item in marks)
            {
                comboBoxId.Items.Add(item.Id);
            }

            comboBoxId.DropDownHeight = 55;
        }

        private void comboBoxId_SelectedIndexChanged(object sender, EventArgs e)
        {

            MarkRepo repo = new MarkRepo();
            List<Mark> marks = repo.GetAll();

            StudentRepo studentRepo  = new StudentRepo();
            List<Student> students = studentRepo.GetAll();

            Mark mark = new Mark();

            foreach (Mark item in marks)
            {
                if (Convert.ToInt32(comboBoxId.Text) == item.Id)
                {
                    mark = item;
                }
            }

            labelDisc.Text = mark.subject;
            labelMark.Text = mark.mark.ToString();
            labelFnum.Text = mark.fNumber;

            foreach (Student item in students)
            {
                if (mark.fNumber == item.fNumber)
                {
                    labelStudentName.Width = 200;
                    labelStudentName.Text = item.FullName;
                }
            }
        }

     
    }
}
