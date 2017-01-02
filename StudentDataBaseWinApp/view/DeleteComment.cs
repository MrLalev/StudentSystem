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
    public partial class DeleteComment : Form
    {
        User user;
        public DeleteComment()
        {
            InitializeComponent();
        }

        internal void Validation(User loggeduser)
        {
            user = loggeduser;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            CommentRepo repo = new CommentRepo();
            List<Comment> comments = repo.GetAll();
            Comment DeleteComment = new Comment();

            foreach (Comment comment in comments)
            {
                if (comment.Id == Convert.ToInt32(comboBoxID.SelectedItem))
                {
                    DeleteComment = comment;
                }
            }

            textBoxFNumber.Text = DeleteComment.fNumber;
            textBoxTittle.Text = DeleteComment.Title;
            textBoxComment.Text = DeleteComment.Content.Replace("\\n", Environment.NewLine);
        }

        private void DeleteComment_Load(object sender, EventArgs e)
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            CommentRepo repo = new CommentRepo();

            if (comboBoxID.Text != "")
            {
                repo.Delete(Convert.ToInt32(comboBoxID.SelectedItem));

                DialogResult result = MessageBox.Show("Коментара беше изтрит, желаете ли да изтриете друг коментар?", "Form Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    comboBoxID.Items.Remove(comboBoxID.SelectedItem);
                    textBoxFNumber.Text = "";
                    textBoxTittle.Text = "";
                    textBoxComment.Text = "";
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
    }
}
