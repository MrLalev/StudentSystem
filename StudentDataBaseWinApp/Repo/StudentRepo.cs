using StudentDataBaseWinApp.Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentDataBaseWinApp.Repo
{
    class StudentRepo : BaseRepo<Student>
    {
        public StudentRepo()
        {
            SourceFile = "students.txt";
        }

        public override void ReadFromSource(StreamReader sr, Student item)
        {
            item.Id = Convert.ToInt32(sr.ReadLine());
            item.FullName = sr.ReadLine();
            item.fNumber = sr.ReadLine();
            item.spec = sr.ReadLine();
            item.course = Convert.ToInt32(sr.ReadLine());
            item.Egn = sr.ReadLine();
            item.Photo = sr.ReadLine();
            item.Gender = sr.ReadLine();
            item.Email = sr.ReadLine();
            item.AverageMark = Convert.ToDouble(sr.ReadLine());
        }

        public override void WriteToSource(StreamWriter sw, Student item)
        {
            sw.WriteLine(item.Id);
            sw.WriteLine(item.FullName);
            sw.WriteLine(item.fNumber);
            sw.WriteLine(item.spec);
            sw.WriteLine(item.course);
            sw.WriteLine(item.Egn);
            sw.WriteLine(item.Photo);
            sw.WriteLine(item.Gender);
            sw.WriteLine(item.Email);
            sw.WriteLine(item.AverageMark);
        }

        public List<Comment> GetStudentComments(Student student)
        {
            CommentRepo commentRepo = new CommentRepo();
            List<Comment> allComments = commentRepo.GetAll();

            List<Comment> studentComments = new List<Comment>();

            foreach (Comment item in allComments)
            {
                if (item.fNumber == student.fNumber)
                {
                    studentComments.Add(item);
                }
            }

            return studentComments;
        }

        public List<Mark> GetStudentMarks(Student student)
        {
            MarkRepo MarkRepo = new MarkRepo();
            List<Mark> allMarks = MarkRepo.GetAll();

            List<Mark> studentMarks = new List<Mark>();

            foreach (Mark item in allMarks)
            {
                if (item.fNumber == student.fNumber)
                {
                    studentMarks.Add(item);
                }
            }
            
            return studentMarks;
        }

        internal static Student GetByFNumber(string fNumber)
        {
            StudentRepo repo = new StudentRepo();
            List<Student> students = repo.GetAll();

            Student loggedStudent = null;

            foreach (Student student in students)
            {
                if (fNumber == student.fNumber)
                {
                    loggedStudent = student;
                }
            }

            return loggedStudent;
        }
    }
}
