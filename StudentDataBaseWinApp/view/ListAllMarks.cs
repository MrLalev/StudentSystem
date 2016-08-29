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
    public partial class ListAllMarks : Form
    {
        public ListAllMarks()
        {
            InitializeComponent();
        }

        private void ListAllMarks_Load(object sender, EventArgs e)
        {
            MarkRepo repo = new MarkRepo();
            List<Mark> marks = repo.GetAll();

            comboBoxSearch.Items.Add("Име на студента");
            comboBoxSearch.Items.Add("Факултетен номер");
            comboBoxSearch.Items.Add("Дисциплина");

            Print(marks);
          
        }

        private void Print(List<Mark> ordered)
        {
            StudentRepo studentRepo = new StudentRepo();
            List<Student> students = studentRepo.GetAll();

            Panel panel = new Panel();
            panel.AutoScroll = true;
            panel.Left = 0;
            panel.Width = 600;
            panel.Height = 243;
            this.Controls.Add(panel);
            panel.BringToFront();

            for (int i = 0; i < ordered.Count; i++)
            {
                Label label = new Label();
                label.Text = String.Format(ordered[i].Id.ToString());
                label.Left = 10;
                label.Width = 41;
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.Top = (i + 1) * 22;
                label.BorderStyle = BorderStyle.FixedSingle;
                panel.Controls.Add(label);
                //this.Controls.Add(label);
                label.BringToFront();

                Label label1 = new Label();
                foreach (Student student in students)
                {
                    if (ordered[i].fNumber == student.fNumber)
                    {
                        label1.Text = String.Format(student.FullName);
                    }
                }
                label1.Left = 50;
                label1.Width = 199;
                label1.TextAlign = ContentAlignment.MiddleLeft;
                label1.Top = (i + 1) * 22;
                label1.BorderStyle = BorderStyle.FixedSingle;
                panel.Controls.Add(label1);
                //this.Controls.Add(label1);
                label1.BringToFront();

                Label label2 = new Label();
                label2.Text = String.Format(ordered[i].fNumber);
                label2.Left = 248;
                label2.Width = 106;
                label2.TextAlign = ContentAlignment.MiddleRight;
                label2.Top = (i + 1) * 22;
                label2.BorderStyle = BorderStyle.FixedSingle;
                panel.Controls.Add(label2);
                //this.Controls.Add(label2);
                label2.BringToFront();

                Label label3 = new Label();
                label3.Text = String.Format(ordered[i].subject);
                label3.Left = 352;
                label3.Width = 180;
                label3.TextAlign = ContentAlignment.MiddleLeft;
                label3.Top = (i + 1) * 22;
                label3.BorderStyle = BorderStyle.FixedSingle;
                panel.Controls.Add(label3);
                //this.Controls.Add(label3);
                label3.BringToFront();

                Label label4 = new Label();
                label4.Text = String.Format(ordered[i].mark.ToString());
                label4.Left = 531;
                label4.Width = 47;
                label4.TextAlign = ContentAlignment.MiddleRight;
                label4.Top = (i + 1) * 22;
                label4.BorderStyle = BorderStyle.FixedSingle;
                panel.Controls.Add(label4);
                //this.Controls.Add(label4);
                label4.BringToFront();
            }
            panel1.BringToFront();
            labelId.BringToFront();
            labelName.BringToFront();
            labelFnumber.BringToFront();
            labelDiscipline.BringToFront();
            labelMark.BringToFront();
        }

        private void buttonAlphaSort_Click(object sender, EventArgs e)
        {
            MarkRepo repo = new MarkRepo();
            List<Mark> marks = repo.GetAll();

            List<Mark> orderedSubject = marks.OrderBy(mark => mark.subject).ToList();

            Print(orderedSubject);
        }

        private void buttonFnumberSort_Click(object sender, EventArgs e)
        {
            MarkRepo repo = new MarkRepo();

            List<Mark> marks = repo.GetAll();

            List<Mark> orderedFNumber = marks.OrderBy(mark => mark.fNumber).ToList();

            Print(orderedFNumber);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MarkRepo repo = new MarkRepo();

            List<Mark> marks = repo.GetAll();

            List<Mark> orderedId = marks.OrderBy(mark => mark.Id).ToList();

            Print(orderedId);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
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

                            MarkRepo repo = new MarkRepo();
                            StudentRepo studentRepo = new StudentRepo();

                            List<Mark> marks = repo.GetAll();
                            List<Student> students = studentRepo.GetAll();

                            List<Mark> searched = new List<Mark>();

                            foreach (Student item in students)
                            {
                                if (item.FullName.ToLower().Contains(search.ToLower()))
                                {
                                    foreach (Mark itemMark in marks)
                                    {
                                        if (item.fNumber == itemMark.fNumber)
                                        {
                                            Mark surchedMark = itemMark;
                                            searched.Add(itemMark);
                                        }
                                    }
                                    
                                }
                            }

                            Print(searched);

                            break;
                        }
                    case 1:
                        {
                            MarkRepo repo = new MarkRepo();

                            List<Mark> marks = repo.GetAll();

                            List<Mark> searched = new List<Mark>();

                            foreach (Mark item in marks)
                            {
                                if (item.fNumber.Contains(search))
                                {
                                    Mark searchedMark = item;
                                    searched.Add(searchedMark);
                                }
                            }
                            Print(searched);

                            break;
                        }
                    case 2:
                        {
                            MarkRepo repo = new MarkRepo();

                            List<Mark> marks = repo.GetAll();

                            List<Mark> searched = new List<Mark>();

                            foreach (Mark item in marks)
                            {
                                if (item.subject.ToLower().Contains(search.ToLower()))
                                {
                                    Mark searchedMark = item;
                                    searched.Add(searchedMark);
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
