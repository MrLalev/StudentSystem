using System;
using System.IO;
using StudentDataBaseWinApp.Enteties;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataBaseWinApp.Repo
{
    class GraduatedRepo : BaseRepo<GraduateStudent>
    {
        public GraduatedRepo()
        {
            SourceFile = "graduated.txt";
        }

        public override void ReadFromSource(StreamReader sr, GraduateStudent item)
        {
            item.Id = Convert.ToInt32(sr.ReadLine());
            item.FullName = sr.ReadLine();
            item.fNumber = sr.ReadLine();
            item.spec = sr.ReadLine();
            item.Egn = sr.ReadLine();
            item.Photo = sr.ReadLine();
            item.Gender = sr.ReadLine();
            item.Email = sr.ReadLine();
            item.AverageMark = Convert.ToDouble(sr.ReadLine());
            item.Marks = sr.ReadLine();
            item.Subjects = sr.ReadLine();
            item.Comments = sr.ReadLine();
            item.Titles = sr.ReadLine();
            item.Users = sr.ReadLine();
            item.Date = sr.ReadLine();
        }

        public override void WriteToSource(StreamWriter sw, GraduateStudent item)
        {
            sw.WriteLine(item.Id);
            sw.WriteLine(item.FullName);
            sw.WriteLine(item.fNumber);
            sw.WriteLine(item.spec);
            sw.WriteLine(item.Egn);
            sw.WriteLine(item.Photo);
            sw.WriteLine(item.Gender);
            sw.WriteLine(item.Email);
            sw.WriteLine(item.AverageMark);
            sw.WriteLine(item.Marks);
            sw.WriteLine(item.Subjects);
            sw.WriteLine(item.Comments);
            sw.WriteLine(item.Titles);
            sw.WriteLine(item.Users);
            sw.WriteLine(item.Date);
        }


        public void GraduateStudentAdd(Student student)
        {

            StudentRepo repo = new StudentRepo();

            List<Comment> StudentComments = repo.GetStudentComments(student);
            List<Mark> StudentMarks = repo.GetStudentMarks(student);

            string AllMarks = "";
            string AllSubjects = "";
            string AllComments = "";
            string AllTitles = "";
            string AllCommentsName = "";
            string AllCommentsDate = "";

            for (int i = 0; i < StudentMarks.Count; i++)
            {
                if (i == StudentMarks.Count - 1)
                {
                    AllMarks += StudentMarks[i].mark;
                    AllSubjects += StudentMarks[i].subject;
                }
                else
                {
                    AllMarks += StudentMarks[i].mark + "|";
                    AllSubjects += StudentMarks[i].subject + "|";
                }

            }

            for (int i = 0; i < StudentComments.Count; i++)
            {
                if (i == StudentComments.Count - 1)
                {
                    AllComments += StudentComments[i].Content;
                    AllTitles += StudentComments[i].Title;
                    AllCommentsName += StudentComments[i].User;
                    AllCommentsDate += StudentComments[i].Date;
                }
                else
                {
                    AllComments += StudentComments[i].Content + "|";
                    AllTitles += StudentComments[i].Title + "|";
                    AllCommentsName += StudentComments[i].User + "|";
                    AllCommentsDate += StudentComments[i].Date + "|";
                }

            }

            GraduateStudent graduated = new GraduateStudent();
            graduated.Id = this.GenerateId();
            graduated.FullName = student.FullName;
            graduated.fNumber = student.fNumber;
            graduated.spec = student.spec;
            graduated.Egn = student.Egn;
            graduated.Photo = student.Photo;
            graduated.Gender = student.Gender;
            graduated.Email = student.Email;
            graduated.AverageMark = student.AverageMark;
            graduated.Marks = AllMarks;
            graduated.Subjects = AllSubjects;
            graduated.Comments = AllComments;
            graduated.Titles = AllTitles;
            graduated.Users = AllCommentsName;
            graduated.Date = AllCommentsDate;

            FileStream stream = new FileStream("graduated.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(stream);

            WriteToSource(sw, graduated);

            sw.Close();
            stream.Close();
        }
    }
}
