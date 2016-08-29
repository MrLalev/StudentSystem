using StudentDataBaseWinApp.Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentDataBaseWinApp.Repo
{
    class MarkRepo : BaseRepo<Mark>
    {
        public MarkRepo()
        {
            SourceFile = "allMarks.txt";
        }

        public override void ReadFromSource(StreamReader sr, Mark item)
        {
            item.Id = Convert.ToInt32(sr.ReadLine());
            item.fNumber = sr.ReadLine();
            item.subject = sr.ReadLine();
            item.mark = Convert.ToInt32(sr.ReadLine());
        }

        public override void WriteToSource(StreamWriter sw, Mark item)
        {
            sw.WriteLine(item.Id);
            sw.WriteLine(item.fNumber);
            sw.WriteLine(item.subject);
            sw.WriteLine(item.mark);
        }
    }
}
