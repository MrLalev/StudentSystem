using StudentDataBaseWinApp.Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentDataBaseWinApp.Repo
{
    class CommentRepo : BaseRepo<Comment>
    {
        public CommentRepo()
        {
            SourceFile = "comments.txt";
        }

        public override void ReadFromSource(StreamReader sr, Comment item)
        {
            item.Id = Convert.ToInt32(sr.ReadLine());
            item.fNumber = sr.ReadLine();
            item.Title = sr.ReadLine();
            item.Content = sr.ReadLine();
            item.User = sr.ReadLine();
            item.Date = sr.ReadLine();
        }

        public override void WriteToSource(StreamWriter sw, Comment item)
        {
            sw.WriteLine(item.Id);
            sw.WriteLine(item.fNumber);
            sw.WriteLine(item.Title);
            sw.WriteLine(item.Content);
            sw.WriteLine(item.User);
            sw.WriteLine(item.Date);
        }
    }
}
