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
    public partial class StudentView : Form
    {
        public StudentView()
        {
            InitializeComponent();
        }

        internal void TakeStudent(Enteties.Student loggedStudent)
        {
            StudentRepo repo = new StudentRepo();
            List<Mark> marks = repo.GetStudentMarks(loggedStudent);

            Panel panel = new Panel();
            panel.AutoScroll = true;
            panel.Left = 0;
            panel.Width = 300;
            panel.Height = 155;
            this.Controls.Add(panel);
            if (marks.Count == 0)
            {
                labelName.Text = "Нямате оценки";
            }
            else
            {
                for (int i = 0; i < marks.Count; i++)
                {
                    double studentMarks = 0;

                    foreach (Mark item in marks)
                    {
                        studentMarks += item.mark;
                    }

                    labelMark.Text = Math.Round(studentMarks / marks.Count, 2).ToString();

                    Label label = new Label();
                    label.Text = String.Format(marks[i].subject);
                    label.Left = 10;
                    label.Width = 180;
                    label.TextAlign = ContentAlignment.MiddleLeft;
                    label.Top = (i + 1) *22;
                    label.BorderStyle = BorderStyle.FixedSingle;
                    panel.Controls.Add(label);
                   // this.Controls.Add(label);

                    Label label1 = new Label();
                    switch (marks[i].mark)
                    {
                        case 2:
                            {
                                label1.Text = String.Format("Слаб (" + marks[i].mark + ")");
                                break;
                            }
                        case 3:
                            {
                                label1.Text = String.Format("Среден (" + marks[i].mark + ")");
                                break;
                            }
                        case 4:
                            {
                                label1.Text = String.Format("Добър (" + marks[i].mark + ")");
                                break;
                            }
                        case 5:
                            {
                                label1.Text = String.Format("Много добър (" + marks[i].mark + ")");
                                break;
                            }
                        case 6:
                            {
                                label1.Text = String.Format("Отличен (" + marks[i].mark + ")");
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }
                    label1.Left = 187;
                    label1.Width = 90;
                    label1.Top = (i + 1) * 22;
                    label1.BorderStyle = BorderStyle.FixedSingle;
                    label1.TextAlign = ContentAlignment.MiddleLeft;
                    panel.Controls.Add(label1);
                    //this.Controls.Add(label1);
                }
                panel1.BringToFront();

                labelName.Text = loggedStudent.FullName;
                labelName.BringToFront();

                labelFnumber.Text = loggedStudent.fNumber;
                labelFnumber.BringToFront();

            }

        }

        private void StudentView_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
