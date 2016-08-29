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
    public partial class ListAllStudents : Form
    {
        public ListAllStudents()
        {
            InitializeComponent();
        }

        private void ListAllStudents_Load(object sender, EventArgs e)
        {

            StudentRepo repo = new StudentRepo();
            List<Student> students = repo.GetAll();
            MarkRepo MarkRepo = new MarkRepo();
            List<Mark> Allmarks = MarkRepo.GetAll();
            List<Student> newListStudents = new List<Student>();

            foreach (Student student in students)
            {
                double studentMarks = 0;
                double count = 0;
                double average = 0;

                foreach (Mark mark in Allmarks)
                {
                    if (student.fNumber == mark.fNumber)
                    {
                        studentMarks += mark.mark;
                        count++;
                    }
                }

                if (count != 0)
                {
                    average = Math.Round(studentMarks / count, 2);
                }

                student.AverageMark = average;
                newListStudents.Add(student);
            }

            repo.OverWrite(newListStudents);

            comboBoxSearch.Items.Add("Име на студента");
            comboBoxSearch.Items.Add("Факултетен номер");
            comboBoxSearch.Items.Add("Специалност");

            Print(students);
        }

        private void Print(List<Student> source)
        {
            Panel panel = new Panel();
            panel.AutoScroll = true;
            panel.Left = 0;
            panel.Width = 950;
            panel.Height = 243;
            this.Controls.Add(panel);
            panel.BringToFront();

            for (int i = 0; i < source.Count; i++)
            {
                Label label = new Label();
                label.Text = String.Format(source[i].Id.ToString());
                label.Left = 10;
                label.Width = 41;
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.Top = (i + 1) * 22;
                label.BorderStyle = BorderStyle.FixedSingle;
                panel.Controls.Add(label);
                //this.Controls.Add(label);

                Label label1 = new Label();
                label1.Text = String.Format(source[i].FullName);
                label1.Left = 50;
                label1.Width = 199;
                label1.TextAlign = ContentAlignment.MiddleLeft;
                label1.Top = (i + 1) * 22;
                label1.BorderStyle = BorderStyle.FixedSingle;
                panel.Controls.Add(label1);
                //this.Controls.Add(label1);

                Label label2 = new Label();
                label2.Text = String.Format(source[i].fNumber);
                label2.Left = 247;
                label2.Width = 106;
                label2.TextAlign = ContentAlignment.MiddleRight;
                label2.Top = (i + 1) * 22;
                label2.BorderStyle = BorderStyle.FixedSingle;
                panel.Controls.Add(label2);
                //this.Controls.Add(label2);

                Label label3 = new Label();
                label3.Text = String.Format(source[i].Egn);
                label3.Left = 352;
                label3.Width = 106;
                label3.TextAlign = ContentAlignment.MiddleRight;
                label3.Top = (i + 1) * 22;
                label3.BorderStyle = BorderStyle.FixedSingle;
                panel.Controls.Add(label3);
                //this.Controls.Add(label2);

                Label label4 = new Label();
                label4.Text = String.Format(source[i].Gender);
                label4.Left = 457;
                label4.Width = 38;
                label4.TextAlign = ContentAlignment.MiddleLeft;
                label4.Top = (i + 1) * 22;
                label4.BorderStyle = BorderStyle.FixedSingle;
                panel.Controls.Add(label4);
                //this.Controls.Add(label2);

                Label label5 = new Label();
                label5.Text = String.Format(source[i].Email);
                label5.Left = 494;
                label5.Width = 180;
                label5.TextAlign = ContentAlignment.MiddleLeft;
                label5.Top = (i + 1) * 22;
                label5.BorderStyle = BorderStyle.FixedSingle;
                panel.Controls.Add(label5);
                //this.Controls.Add(label2);

                Label label6 = new Label();
                label6.Text = String.Format(source[i].spec);
                label6.Left = 673;
                label6.Width = 180;
                label6.TextAlign = ContentAlignment.MiddleLeft;
                label6.Top = (i + 1) * 22;
                label6.BorderStyle = BorderStyle.FixedSingle;
                panel.Controls.Add(label6);
                //this.Controls.Add(label3);

                Label label7 = new Label();
                label7.Text = String.Format(source[i].course.ToString());
                label7.Left = 852;
                label7.Width = 33;
                label7.TextAlign = ContentAlignment.MiddleRight;
                label7.Top = (i + 1) * 22;
                label7.BorderStyle = BorderStyle.FixedSingle;
                panel.Controls.Add(label7);
                //this.Controls.Add(label4);

                Label label8 = new Label();
                label8.Text = String.Format(source[i].AverageMark.ToString());
                label8.Left = 884;
                label8.Width = 47;
                label8.TextAlign = ContentAlignment.MiddleRight;
                label8.Top = (i + 1) * 22;
                label8.BorderStyle = BorderStyle.FixedSingle;
                panel.Controls.Add(label8);
                //this.Controls.Add(label4);
            }
            panel1.BringToFront();
            labelId.BringToFront();
            labelName.BringToFront();
            labelFnumber.BringToFront();
            labelSpec.BringToFront();
            labelCourse.BringToFront();
            labelEgn.BringToFront();
            labelEmail.BringToFront();
            labelGender.BringToFront();
            labelMark.BringToFront();
        }

        private void buttonAlphaSort_Click(object sender, EventArgs e)
        {

            StudentRepo repo = new StudentRepo();
            List<Student> students = repo.GetAll();

            List<Student> ordered = students.OrderBy(student => student.FullName).ToList();

            Print(ordered);
        }

        private void buttonFnumberSort_Click(object sender, EventArgs e)
        {
            StudentRepo repo = new StudentRepo();
            List<Student> students = repo.GetAll();

            IEnumerable<Student> orderedFNumber = students.OrderBy(student => student.fNumber);
            List<Student> ordered = orderedFNumber.OrderBy(student => student.course).ToList();

            Print(ordered);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentRepo repo = new StudentRepo();
            List<Student> students = repo.GetAll();

            List<Student> ordered = students.OrderBy(student => student.Id).ToList();

            Print(ordered);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textSearch.Text != "" && comboBoxSearch.Text != "" )
            {
                string search = textSearch.Text;

                switch (comboBoxSearch.SelectedIndex)
                {
                    case 0:
                        {

                            StudentRepo repo = new StudentRepo();
                            List<Student> students = repo.GetAll();

                            List<Student> searched = new List<Student>();

                            foreach (Student item in students)
                            {
                                if (item.FullName.ToLower().Contains(search.ToLower()))
                                {
                                    Student searchedStudent = item;
                                    searched.Add(searchedStudent);
                                }
                            }

                            Print(searched);

                            break;
                        }
                    case 1:
                        {
                            StudentRepo repo = new StudentRepo();
                            List<Student> students = repo.GetAll();

                            List<Student> searched = new List<Student>();

                            foreach (Student item in students)
                            {
                                if (item.fNumber.Contains(search))
                                {
                                    Student searchedStudent = item;
                                    searched.Add(searchedStudent);
                                }
                            }

                            Print(searched);
                            break;
                        }
                    case 2:
                        {

                            StudentRepo repo = new StudentRepo();
                            List<Student> students =  repo.GetAll();

                            List<Student> searched = new List<Student>();

                            foreach (Student item in students)
                            {
                                if (item.spec.ToLower().Contains(search.ToLower()))
                                {
                                    Student searchedStudent = item;
                                    searched.Add(searchedStudent);
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

        private void button2_Click(object sender, EventArgs e)
        {
            StudentRepo repo = new StudentRepo();
            List<Student> students = repo.GetAll();

            List<Student> ordered = students.OrderByDescending(student => student.AverageMark).ToList();

            Print(ordered);
        }
    }
}
