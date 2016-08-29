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

namespace StudentDataBaseWinApp.view
{
    public partial class AddComment : Form
    {
        User user;
        public AddComment()
        {
            InitializeComponent();
        }


        internal void Validation(User loggedUser)
        {
            user = loggedUser;
        }
        private void buttonComment_Click(object sender, EventArgs e)
        {
            bool check = false;
            Comment comment = new Comment();
            StudentRepo repo = new StudentRepo();
            CommentRepo CommentRepo = new CommentRepo();

            List<Student> students = repo.GetAll();

            if (textBoxFNumber.Text.Length < 10)
            {
                MessageBox.Show("Факултетния номер е 10 цифри!");
                textBoxFNumber.Text = null;
            }
            foreach (Student student in students)
            {
                if (student.fNumber == textBoxFNumber.Text)
                {
                    check = true;
                    break;
                }
            }
            if (check == false)
            {
                MessageBox.Show("Няма такъв студент!");
                textBoxFNumber.Text = null;
            }

            if (textBoxComment.Text != "" && textBoxFNumber.Text != "" && textBoxTittle.Text != "")
            {
                comment.Title = textBoxTittle.Text;
                comment.Content = textBoxComment.Text.Replace(Environment.NewLine, @"\n");
                comment.fNumber = textBoxFNumber.Text;
                comment.Date = DateTime.Now.ToString("d");
                comment.User = user.FullName;

                CommentRepo.Insert(comment);

                DialogResult result = MessageBox.Show("Данните бяха записани, желаете ли да добавите друг коментар?", "Form Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    textBoxComment.Text = null;
                    textBoxFNumber.Text = null;
                    textBoxTittle.Text = null;
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Всички полета трябва да са попълнени!");
            }
        }

        private void textBoxFNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
