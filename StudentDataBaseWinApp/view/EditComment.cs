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
    public partial class EditComment : Form
    {
        User user;
        public EditComment()
        {
            InitializeComponent();
        }


        private void buttonEdit_Click(object sender, EventArgs e)
        {
            bool check = false;

            Comment editComment = new Comment();
            StudentRepo repo = new StudentRepo();
            CommentRepo commentRepo = new CommentRepo();

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
                editComment.Id = Convert.ToInt32(comboBoxID.SelectedItem);
                editComment.fNumber = textBoxFNumber.Text;
                editComment.Title = textBoxTittle.Text;
                editComment.Content = textBoxComment.Text.Replace(Environment.NewLine, @"\n");
                editComment.Date = DateTime.Now.ToString();

                commentRepo.Edit(editComment);

                DialogResult result = MessageBox.Show("Данните бяха редактирани, желаете ли да редактирате друг коментар?", "Form Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    comboBoxID.Text = null;
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


        internal void Validation(User loggeduser)
        {
            user = loggeduser;
        }

        private void EditComment_Load(object sender, EventArgs e)
        {
            CommentRepo repo = new CommentRepo();
            List<Comment> comments = repo.GetAll();

            foreach (Comment comment in comments)
            {
                if (user.FullName == comment.User)
                {
                    comboBoxID.Items.Add(comment.Id);
                }
            }
        }

        private void comboBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Comment editComment = new Comment();

            CommentRepo repo = new CommentRepo();
            List<Comment> comments = repo.GetAll();

            foreach (Comment comment in comments)
            {
                if (Convert.ToInt32(comboBoxID.SelectedItem) == comment.Id)
                {
                    editComment = comment;
                }
            }
            if (comboBoxID.Text != "")
            {
                textBoxFNumber.Text = editComment.fNumber;
                textBoxTittle.Text = editComment.Title;
                textBoxComment.Text = editComment.Content.Replace("\\n", Environment.NewLine);
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
