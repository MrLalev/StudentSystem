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
using System.IO;

namespace StudentDataBaseWinApp.view
{
    public partial class StudentInfo : Form
    {
        public StudentInfo()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
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

            if (textBoxStudentLoad.Text !="")
            {
                string searched = textBoxStudentLoad.Text;
                int count = 0;
                int countGraduated = 0;
                Student student = new Student();
                GraduateStudent graduatedStudent = new GraduateStudent();
                GraduatedRepo graduatedRepo = new GraduatedRepo();
                List<GraduateStudent> AllGraduateStudents = graduatedRepo.GetAll();

                foreach (Student item in newListStudents)
                {
                    if (item.fNumber == searched)
                    {
                        student = item;
                        count++;
                        break;
                    }
                }

                foreach (GraduateStudent item in AllGraduateStudents)
                {
                    if (item.fNumber == searched)
                    {
                        graduatedStudent = item;
                        countGraduated++;
                        break;
                    }
                }

                if (countGraduated != 0)
                {
                    buttonGraduated.Enabled = false;

                    labelStudentName.Text = graduatedStudent.FullName;
                    labelFnum.Text = graduatedStudent.fNumber;
                    labelEgn.Text = graduatedStudent.Egn;
                    labelGender.Text = graduatedStudent.Gender;
                    labelEmail.Text = graduatedStudent.Email;
                    labelSpec.Text = graduatedStudent.spec;
                    labelCourse.Text = "завършил";
                    labelAverage.Text = graduatedStudent.AverageMark.ToString();

                    using (FileStream fs = new FileStream(graduatedStudent.Photo, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        byte[] buffer1 = new byte[fs.Length];
                        fs.Read(buffer1, 0, (int)fs.Length);
                        using (MemoryStream ms = new MemoryStream(buffer1))
                            this.pictureBoxPhoto.Image = Image.FromStream(ms);
                    }
                    List<String> studentMarks = graduatedStudent.Marks.Split('|').ToList();
                    List<String> studentSubjects = graduatedStudent.Subjects.Split('|').ToList();

                    List<Mark> marks = new List<Mark>();

                    for (int i = 0; i < studentMarks.Count; i++)
                    {
                        if (studentMarks[i] != "")
                        {
                            Mark mark = new Mark();
                            mark.fNumber = graduatedStudent.fNumber;
                            mark.mark = Convert.ToInt32(studentMarks[i]);
                            mark.subject = studentSubjects[i];

                            marks.Add(mark); 
                        }
                    }


                    Panel panel = new Panel();
                    panel.AutoScroll = true;
                    panel.Left = 0;
                    panel.Width = 492;
                    panel.Height = 133;
                    panel.Location = new Point(4, 251);
                    this.Controls.Add(panel);
                    panel.BringToFront();

                    for (int i = 0; i < marks.Count; i++)
                    {
                        Label label = new Label();
                        label.Text = String.Format(marks[i].subject);
                        label.Left = 0;
                        label.Width = 334;
                        label.TextAlign = ContentAlignment.MiddleLeft;
                        label.Top = (i + 1) * 22;
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
                        label1.Left = 332;
                        label1.Width = 139;
                        label1.Top = (i + 1) * 22;
                        label1.BorderStyle = BorderStyle.FixedSingle;
                        label1.TextAlign = ContentAlignment.MiddleLeft;
                        panel.Controls.Add(label1);
                        //this.Controls.Add(label1);
                    }
                    panelMark.BringToFront();
                    labelStudentMark.BringToFront();
                    labelDiscipline.BringToFront();
                    labelMark.BringToFront();

                    List<String> studentTitle= graduatedStudent.Titles.Split('|').ToList();
                    List<String> studentComment = graduatedStudent.Comments.Split('|').ToList();
                    List<String> studentUser = graduatedStudent.Users.Split('|').ToList();
                    List<String> studentDate = graduatedStudent.Date.Split('|').ToList();

                    List<Comment> comments = new List<Comment>();

                    for (int i = 0; i < studentComment.Count; i++)
                    {
                        if (studentComment[i] != "")
                        {
                            Comment comment = new Comment();
                            comment.fNumber = graduatedStudent.fNumber;
                            comment.Title = studentTitle[i];
                            comment.Content = studentComment[i];
                            comment.User = studentUser[i];
                            comment.Date = studentDate[i];

                            comments.Add(comment);
                        }
                    }

                    Panel panel1 = new Panel();
                    panel1.AutoScroll = true;
                    panel1.Left = 0;
                    panel1.Width = 492;
                    panel1.Height = 135;
                    //panel1.BorderStyle = BorderStyle.FixedSingle; // махни тази опция!
                    panel1.Location = new Point(3, 400);
                    this.Controls.Add(panel1);
                    panel1.BringToFront();

                    for (int i = 0; i < comments.Count; i++)
                    {
                        RichTextBox trb = new RichTextBox();
                        trb.ReadOnly = true;
                        trb.Text = String.Format(comments[i].Title);
                        trb.Left = 0;
                        trb.Height = 45;
                        trb.Width = 110;
                        //label.TextAlign = ContentAlignment.MiddleLeft;
                        trb.Top = (i + 1) * 45;
                        trb.BorderStyle = BorderStyle.FixedSingle;
                        panel1.Controls.Add(trb);
                        // this.Controls.Add(label);

                        RichTextBox trb1 = new RichTextBox();
                        trb1.ReadOnly = true;
                        trb1.BorderStyle = BorderStyle.None;
                        trb1.Text = String.Format(comments[i].Content.Replace("\\n", Environment.NewLine));
                        trb1.Height = 45;
                        trb1.Left = 109;
                        trb1.Width = 130;
                        trb1.Top = (i + 1) * 45;
                        trb1.BorderStyle = BorderStyle.FixedSingle;
                        //label1.TextAlign = ContentAlignment.MiddleLeft;
                        panel1.Controls.Add(trb1);
                        //this.Controls.Add(label1);

                        RichTextBox trb2 = new RichTextBox();
                        trb2.ReadOnly = true;
                        trb2.Text = String.Format(comments[i].User);
                        trb2.Height = 45;
                        trb2.Left = 238;
                        trb2.Width = 166;
                        trb2.Top = (i + 1) * 45;
                        trb2.BorderStyle = BorderStyle.FixedSingle;
                        //label2.TextAlign = ContentAlignment.MiddleLeft;
                        panel1.Controls.Add(trb2);
                        //this.Controls.Add(label1);

                        RichTextBox trb3 = new RichTextBox();
                        trb3.ReadOnly = true;
                        trb3.Text = String.Format(comments[i].Date);
                        trb3.Height = 45;
                        trb3.Left = 403;
                        trb3.Width = 69;
                        trb3.Top = (i + 1) * 45;
                        trb3.BorderStyle = BorderStyle.FixedSingle;
                        //label3.TextAlign = ContentAlignment.MiddleLeft;
                        panel1.Controls.Add(trb3);
                        //this.Controls.Add(label1);
                    }
                    panelComments.BringToFront();
                    panelTry.BringToFront();
                    labelAllComments.BringToFront();


                    DateTime date = DateTime.Now;
                    DateTime dateOnly = date.Date;
                    string date1 = dateOnly.ToString("yy/MM/dd");
                    string[] dateSplit = date1.Split('.');
                    if (date1.Contains("."))
                    {
                        dateSplit = date1.Split('.');
                    }
                    else if (date1.Contains("-"))
                    {
                        dateSplit = date1.Split('-');
                    }
                    string nDate = dateSplit[0] + dateSplit[1] + dateSplit[2];
                    char[] studentEgn = graduatedStudent.Egn.ToCharArray();
                    string engDate = studentEgn[0].ToString() + studentEgn[1].ToString() + studentEgn[2].ToString() + studentEgn[3].ToString() + studentEgn[4].ToString() + studentEgn[5].ToString();
                    long getDate = long.Parse(nDate);
                    long engDateLong = long.Parse(engDate);

                    if (engDateLong > getDate)
                    {
                        date1 = dateOnly.ToString("yyyy/MM/dd");
                        char[] dateTimeNow = date1.ToCharArray();
                        int first = Convert.ToInt32(dateTimeNow[0].ToString() + dateTimeNow[1].ToString());
                        int second = first - 1;
                        nDate = first.ToString() + dateSplit[0] + dateSplit[1] + dateSplit[2];
                        engDate = second.ToString() + studentEgn[0].ToString() + studentEgn[1].ToString() + studentEgn[2].ToString() + studentEgn[3].ToString() + studentEgn[4].ToString() + studentEgn[5].ToString();
                        getDate = long.Parse(nDate);
                        engDateLong = long.Parse(engDate);
                        long birthday = getDate - engDateLong;
                        char[] array = birthday.ToString().ToCharArray();
                        string years = array[0].ToString() + array[1].ToString();
                        labelYear.Text = years;
                    }
                    else
                    {
                        engDateLong = engDateLong - 4000;
                        long birthday = getDate - engDateLong;
                        char[] array = birthday.ToString().ToCharArray();
                        string years = array[0].ToString() + array[1].ToString();
                        labelYear.Text = years;
                    }
                }
                else if (count != 0)
                {
                    buttonGraduated.Enabled = true;
                    labelStudentName.Text = student.FullName;
                    labelFnum.Text = student.fNumber;
                    labelEgn.Text = student.Egn;
                    labelGender.Text = student.Gender;
                    labelEmail.Text = student.Email;
                    labelSpec.Text = student.spec;
                    labelCourse.Text = student.course.ToString();
                    labelAverage.Text = student.AverageMark.ToString();
                    using (FileStream fs = new FileStream(student.Photo, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        byte[] buffer1 = new byte[fs.Length];
                        fs.Read(buffer1, 0, (int)fs.Length);
                        using (MemoryStream ms = new MemoryStream(buffer1))
                        this.pictureBoxPhoto.Image = Image.FromStream(ms);
                    }

                    List<Mark> marks = repo.GetStudentMarks(student);

                    Panel panel = new Panel();
                    panel.AutoScroll = true;
                    panel.Left = 0;
                    panel.Width = 492;
                    panel.Height = 133;
                    panel.Location = new Point(4,251);
                    this.Controls.Add(panel);
                    panel.BringToFront();

                        for (int i = 0; i < marks.Count; i++)
                        {
                            Label label = new Label();
                            label.Text = String.Format(marks[i].subject);
                            label.Left = 0;
                            label.Width = 334;
                            label.TextAlign = ContentAlignment.MiddleLeft;
                            label.Top = (i + 1) * 22;
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
                            label1.Left = 332;
                            label1.Width = 139;
                            label1.Top = (i + 1) * 22;
                            label1.BorderStyle = BorderStyle.FixedSingle;
                            label1.TextAlign = ContentAlignment.MiddleLeft;
                            panel.Controls.Add(label1);
                            //this.Controls.Add(label1);
                        }
                        panelMark.BringToFront();
                        labelStudentMark.BringToFront();
                        labelDiscipline.BringToFront();
                        labelMark.BringToFront();


                        List<Comment> comments = repo.GetStudentComments(student);

                        Panel panel1 = new Panel();
                        panel1.AutoScroll = true;
                        panel1.Left = 0;
                        panel1.Width = 492;
                        panel1.Height = 135;
                        //panel1.BorderStyle = BorderStyle.FixedSingle; // махни тази опция!
                        panel1.Location = new Point(3, 400);
                        this.Controls.Add(panel1);
                        panel1.BringToFront();

                        for (int i = 0; i < comments.Count; i++)
                        {
                            RichTextBox trb = new RichTextBox();
                            trb.ReadOnly = true;
                            trb.Text = String.Format(comments[i].Title);
                            trb.Left = 0;
                            trb.Height = 45;
                            trb.Width = 110;
                            //label.TextAlign = ContentAlignment.MiddleLeft;
                            trb.Top = (i + 1) * 45;
                            trb.BorderStyle = BorderStyle.FixedSingle;
                            panel1.Controls.Add(trb);
                            // this.Controls.Add(label);

                            RichTextBox trb1 = new RichTextBox();
                            trb1.ReadOnly = true;
                            trb1.BorderStyle = BorderStyle.None;
                            trb1.Text = String.Format(comments[i].Content.Replace("\\n", Environment.NewLine));
                            trb1.Height = 45;
                            trb1.Left = 109;
                            trb1.Width = 130;
                            trb1.Top = (i + 1) * 45;
                            trb1.BorderStyle = BorderStyle.FixedSingle;
                            //label1.TextAlign = ContentAlignment.MiddleLeft;
                            panel1.Controls.Add(trb1);
                            //this.Controls.Add(label1);

                            RichTextBox trb2 = new RichTextBox();
                            trb2.ReadOnly = true;
                            trb2.Text = String.Format(comments[i].User);
                            trb2.Height = 45;
                            trb2.Left = 238;
                            trb2.Width = 166;
                            trb2.Top = (i + 1) * 45;
                            trb2.BorderStyle = BorderStyle.FixedSingle;
                            //label2.TextAlign = ContentAlignment.MiddleLeft;
                            panel1.Controls.Add(trb2);
                            //this.Controls.Add(label1);

                            RichTextBox trb3 = new RichTextBox();
                            trb3.ReadOnly = true;
                            trb3.Text = String.Format(comments[i].Date);
                            trb3.Height = 45;
                            trb3.Left = 403;
                            trb3.Width = 69;
                            trb3.Top = (i + 1) * 45;
                            trb3.BorderStyle = BorderStyle.FixedSingle;
                            //label3.TextAlign = ContentAlignment.MiddleLeft;
                            panel1.Controls.Add(trb3);
                            //this.Controls.Add(label1);
                        }
                        panelComments.BringToFront();
                        panelTry.BringToFront();
                        labelAllComments.BringToFront();

                        DateTime date = DateTime.Now;
                        DateTime dateOnly = date.Date;
                        string date1 = dateOnly.ToString("yy/MM/dd");
                        string[] dateSplit = new string[3];
                        if (date1.Contains("."))
                        {
                            dateSplit = date1.Split('.');
                        }
                        else if (date1.Contains("-"))
                        {
                            dateSplit = date1.Split('-');
                        }

                        string nDate = dateSplit[0] + dateSplit[1] + dateSplit[2];
                        char[] studentEgn = student.Egn.ToCharArray();
                        string engDate = studentEgn[0].ToString() + studentEgn[1].ToString() + studentEgn[2].ToString() + studentEgn[3].ToString() + studentEgn[4].ToString() + studentEgn[5].ToString();
                        long getDate = long.Parse(nDate);
                        long engDateLong = long.Parse(engDate);

                        if (engDateLong > getDate)
                        {
                             date1 = dateOnly.ToString("yyyy/MM/dd");
                             char[] dateTimeNow = date1.ToCharArray();
                             int first = Convert.ToInt32(dateTimeNow[0].ToString() + dateTimeNow[1].ToString());
                             int second = first - 1;
                             nDate = first.ToString() + dateSplit[0] + dateSplit[1] + dateSplit[2];
                             engDate = second.ToString() + studentEgn[0].ToString() + studentEgn[1].ToString() + studentEgn[2].ToString() + studentEgn[3].ToString() + studentEgn[4].ToString() + studentEgn[5].ToString();
                             getDate = long.Parse(nDate);
                             engDateLong = long.Parse(engDate);
                             long birthday = getDate - engDateLong;
                             char[] array = birthday.ToString().ToCharArray();
                             string years = array[0].ToString() + array[1].ToString();
                             labelYear.Text = years;
                        }
                        else
                        {
                            engDateLong = engDateLong - 4000;
                            long birthday = getDate - engDateLong;
                            char[] array = birthday.ToString().ToCharArray();
                            string years = array[0].ToString() + array[1].ToString();
                            labelYear.Text = years;
                        }
                }
                else
                {
                    MessageBox.Show("Няма студент с такъв факултетен номер!");
                }
            }
            else
            {
                MessageBox.Show("Не може да оставяте непопълнени полета!");
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentInfo_Load(object sender, EventArgs e)
        {
            Label labelTittle = new Label();
            labelTittle.Text = String.Format("Заглавие");
            labelTittle.Left = 0;
            labelTittle.Height = 41;
            labelTittle.Width = 111;
            labelTittle.TextAlign = ContentAlignment.MiddleCenter;
            labelTittle.Top = 0;
            labelTittle.BorderStyle = BorderStyle.FixedSingle;
            panelTry.Controls.Add(labelTittle);

            Label labelContent = new Label();
            labelContent.Text = String.Format("Коментар");
            labelContent.Left = 110;
            labelContent.Height = 41;
            labelContent.Width = 130;
            labelContent.TextAlign = ContentAlignment.MiddleCenter;
            labelContent.Top = 0;
            labelContent.BorderStyle = BorderStyle.FixedSingle;
            panelTry.Controls.Add(labelContent);

            Label labelFrom = new Label();
            labelFrom.Text = String.Format("Написан от");
            labelFrom.Left = 239;
            labelFrom.Height = 41;
            labelFrom.Width = 166;
            labelFrom.TextAlign = ContentAlignment.MiddleCenter;
            labelFrom.Top = 0;
            labelFrom.BorderStyle = BorderStyle.FixedSingle;
            panelTry.Controls.Add(labelFrom);

            Label labelDate = new Label();
            labelDate.Text = String.Format("Заглавие");
            labelDate.Left = 403;
            labelDate.Height = 41;
            labelDate.Width = 69;
            labelDate.TextAlign = ContentAlignment.MiddleCenter;
            labelDate.Top = 0;
            labelDate.BorderStyle = BorderStyle.FixedSingle;
            panelTry.Controls.Add(labelDate);
        }

        private void textBoxStudentLoad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void buttonGraduated_Click(object sender, EventArgs e)
        {
            if (textBoxStudentLoad.Text != "")
            {
                DialogResult result = MessageBox.Show("Сигърни ли сте, че искате да приместите студента при завършилите студенти ?", "Form Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    StudentRepo repo = new StudentRepo();
                    GraduatedRepo graduatedRepo = new GraduatedRepo();
                    MarkRepo markRepo = new MarkRepo();
                    List<Student> students = repo.GetAll();
                    List<Mark> Allmarks = markRepo.GetAll();
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

                    Student student1 = new Student();

                    if (textBoxStudentLoad.Text != "")
                    {
                        string searched = textBoxStudentLoad.Text;

                        foreach (Student item in newListStudents)
                        {
                            if (item.fNumber == searched)
                            {
                                student1 = item;
                                break;
                            }
                        }
                    }

                    graduatedRepo.GraduateStudentAdd(student1);

                    repo.Delete(student1.Id);

                    CommentRepo commentRepo = new CommentRepo();
                    List<Comment> StudentComments = repo.GetStudentComments(student1);
                    List<Mark> StudentMarks = repo.GetStudentMarks(student1);

                    foreach (Comment item in StudentComments)
                    {
                        commentRepo.Delete(item.Id);
                    }

                    foreach (Mark item in StudentMarks)
                    {
                        markRepo.Delete(item.Id);
                    }

                    MessageBox.Show("Данните бяха успешно преместени!");
                }      
            }
            else
            {
                MessageBox.Show("Не сте въвели студент, който да преместите");
            }
            
        }

    }
}
