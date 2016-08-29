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
    public partial class ListAllComments : Form
    {
        public ListAllComments()
        {
            InitializeComponent();
        }

        private void ListAllComments_Load(object sender, EventArgs e)
        {
            CommentRepo repo = new CommentRepo();
            List<Comment> comments = repo.GetAll();

            comboBoxSearch.Items.Add("Факултетен номер");
            comboBoxSearch.Items.Add("Написан от");
            comboBoxSearch.Items.Add("Заглавие");

            Print(comments);

            Label labelIId = new Label();
            labelIId.Text = String.Format("ID");
            labelIId.Left = 0;
            labelIId.Height = 41;
            labelIId.Width = 42;
            labelIId.TextAlign = ContentAlignment.MiddleCenter;
            labelIId.Top = 0;
            labelIId.BorderStyle = BorderStyle.FixedSingle;
            panelTry.Controls.Add(labelIId);

            Label labelFnum = new Label();
            labelFnum.Text = String.Format("Факултетен номер");
            labelFnum.Left = 40;
            labelFnum.Height = 41;
            labelFnum.Width = 107;
            labelFnum.TextAlign = ContentAlignment.MiddleCenter;
            labelFnum.Top = 0;
            labelFnum.BorderStyle = BorderStyle.FixedSingle;
            panelTry.Controls.Add(labelFnum);

            Label labelFrom = new Label();
            labelFrom.Text = String.Format("Заглавие");
            labelFrom.Left = 145;
            labelFrom.Height = 41;
            labelFrom.Width = 162;
            labelFrom.TextAlign = ContentAlignment.MiddleCenter;
            labelFrom.Top = 0;
            labelFrom.BorderStyle = BorderStyle.FixedSingle;
            panelTry.Controls.Add(labelFrom);

            Label labelComment = new Label();
            labelComment.Text = String.Format("Коментар");
            labelComment.Left = 304;
            labelComment.Height = 41;
            labelComment.Width = 202;
            labelComment.TextAlign = ContentAlignment.MiddleCenter;
            labelComment.Top = 0;
            labelComment.BorderStyle = BorderStyle.FixedSingle;
            panelTry.Controls.Add(labelComment);

            Label labelUser = new Label();
            labelUser.Text = String.Format("Написан от");
            labelUser.Left = 503;
            labelUser.Height = 41;
            labelUser.Width = 153;
            labelUser.TextAlign = ContentAlignment.MiddleCenter;
            labelUser.Top = 0;
            labelUser.BorderStyle = BorderStyle.FixedSingle;
            panelTry.Controls.Add(labelUser);

            Label labelDate = new Label();
            labelDate.Text = String.Format("Дата");
            labelDate.Left = 653;
            labelDate.Height = 41;
            labelDate.Width = 69;
            labelDate.TextAlign = ContentAlignment.MiddleCenter;
            labelDate.Top = 0;
            labelDate.BorderStyle = BorderStyle.FixedSingle;
            panelTry.Controls.Add(labelDate);
        }

        private void Print(List<Comment> source)
        {
            Panel panel2 = new Panel();
            panel2.AutoScroll = true;
            panel2.Left = 0;
            panel2.Width = 753;
            panel2.Height = 271;
            this.Controls.Add(panel2);
            panel2.BringToFront();

            for (int i = 0; i < source.Count; i++)
            {
                RichTextBox rtb = new RichTextBox();
                rtb.Text = String.Format(source[i].Id.ToString());
                rtb.ReadOnly = true;
                rtb.Left = 10;
                rtb.Width = 41;
                rtb.Height = 45;
                //rtb.TextAlign = ContentAlignment.MiddleLeft;
                rtb.Top = (i + 1) * 45;
                rtb.BorderStyle = BorderStyle.FixedSingle;
                panel2.Controls.Add(rtb);
                //this.Controls.Add(label);

                RichTextBox rtb1 = new RichTextBox();
                rtb1.Text = String.Format(source[i].fNumber);
                rtb1.ReadOnly = true;
                rtb1.Left = 50;
                rtb1.Width = 106;
                rtb1.Height = 45;
                //rtb1.TextAlign = ContentAlignment.MiddleLeft;
                rtb1.Top = (i + 1) * 45;
                rtb1.BorderStyle = BorderStyle.FixedSingle;
                panel2.Controls.Add(rtb1);
                //this.Controls.Add(label1);

                RichTextBox rtb2 = new RichTextBox();
                rtb2.Text = String.Format(source[i].Title);
                rtb2.ReadOnly = true;
                rtb2.Left = 155;
                rtb2.Width = 161;
                rtb2.Height = 45;
                //rtb2.TextAlign = ContentAlignment.MiddleLeft;
                rtb2.Top = (i + 1) * 45;
                rtb2.BorderStyle = BorderStyle.FixedSingle;
                panel2.Controls.Add(rtb2);
                //this.Controls.Add(label2);

                RichTextBox rtb3 = new RichTextBox();
                rtb3.Text = String.Format(source[i].Content.Replace("\\n", Environment.NewLine));
                rtb3.ReadOnly = true;
                rtb3.Left = 315;
                rtb3.Width = 200;
                rtb3.Height = 45;
                //rtb3.TextAlign = ContentAlignment.MiddleRight;
                rtb3.Top = (i + 1) * 45;
                rtb3.BorderStyle = BorderStyle.FixedSingle;
                panel2.Controls.Add(rtb3);
                //this.Controls.Add(label3);


                RichTextBox rtb4 = new RichTextBox();
                rtb4.Text = String.Format(source[i].User);
                rtb4.ReadOnly = true;
                rtb4.Left = 514;
                rtb4.Width = 151;
                rtb4.Height = 45;
                //rtb4.TextAlign = ContentAlignment.MiddleRight;
                rtb4.Top = (i + 1) * 45;
                rtb4.BorderStyle = BorderStyle.FixedSingle;
                panel2.Controls.Add(rtb4);
                //this.Controls.Add(label3);


                RichTextBox rtb5 = new RichTextBox();
                rtb5.Text = String.Format(source[i].Date);
                rtb5.ReadOnly = true;
                rtb5.Left = 664;
                rtb5.Width = 69;
                rtb5.Height = 45;
                //rtb5.TextAlign = ContentAlignment.MiddleRight;
                rtb5.Top = (i + 1) * 45;
                rtb5.BorderStyle = BorderStyle.FixedSingle;
                panel2.Controls.Add(rtb5);
                //this.Controls.Add(label3);
            }
            panel1.BringToFront();
            panelTry.BringToFront();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAlphaSort_Click(object sender, EventArgs e)
        {
            CommentRepo repo = new CommentRepo();
            List<Comment> comments = repo.GetAll();

            List<Comment> ordered = comments.OrderByDescending(comment => comment.Date).ToList();

            Print(ordered);
        }

        private void buttonFnumberSort_Click(object sender, EventArgs e)
        {
            CommentRepo repo = new CommentRepo();
            List<Comment> comments = repo.GetAll();

            List<Comment> ordered = comments.OrderBy(comment => comment.fNumber).ToList();

            Print(ordered);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CommentRepo repo = new CommentRepo();
            List<Comment> comments = repo.GetAll();

            List<Comment> ordered = comments.OrderBy(comment => comment.Id).ToList();

            Print(ordered);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textSearch.Text != "" && comboBoxSearch.Text != "")
            {
                string search = textSearch.Text;

                switch (comboBoxSearch.SelectedIndex)
                {
                    case 0:
                        {

                            CommentRepo repo = new CommentRepo();
                            List<Comment> comments = repo.GetAll();

                            List<Comment> searched = new List<Comment>();

                            foreach (Comment item in comments)
                            {
                                if (item.fNumber.Contains(search))
                                {
                                    Comment searchedComment = item;
                                    searched.Add(searchedComment);
                                }
                            }

                            Print(searched);
                            break;
                        }
                    case 1:
                        {
                            CommentRepo repo = new CommentRepo();
                            List<Comment> comments = repo.GetAll();

                            List<Comment> searched = new List<Comment>();

                            foreach (Comment item in comments)
                            {
                                if (item.User.ToLower().Contains(search.ToLower()))
                                {
                                    Comment searchedComment = item;
                                    searched.Add(searchedComment);
                                }
                            }

                            Print(searched);

                            break;
                        }
                    case 2:
                        {

                            CommentRepo repo = new CommentRepo();
                            List<Comment> comments = repo.GetAll();

                            List<Comment> searched = new List<Comment>();

                            foreach (Comment item in comments)
                            {
                                if (item.Title.ToLower().Contains(search.ToLower()))
                                {
                                    Comment searchedComment = item;
                                    searched.Add(searchedComment);
                                }
                            }

                            Print(searched);

                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
            else
            {
                MessageBox.Show("Изберете опция за търсене и критерии в полето за търсене!");
            }
        }
    }
}
