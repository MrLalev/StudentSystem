using StudentDataBaseWinApp.Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentDataBaseWinApp.Repo
{
    class MessageRepo : BaseRepo<MyMessage>
    {
        public MessageRepo()
        {
            SourceFile = "messages.txt";
        }

        public override void ReadFromSource(StreamReader sr, MyMessage item)
        {
            item.Id = Convert.ToInt32(sr.ReadLine());
            item.From = sr.ReadLine();
            item.To = sr.ReadLine();
            item.Tittle = sr.ReadLine();
            item.Content = sr.ReadLine();
            item.seen = Convert.ToBoolean(sr.ReadLine());
        }

        public override void WriteToSource(StreamWriter sw, MyMessage item)
        {
            sw.WriteLine(item.Id);
            sw.WriteLine(item.From);
            sw.WriteLine(item.To);
            sw.WriteLine(item.Tittle);
            sw.WriteLine(item.Content);
            sw.WriteLine(item.seen);
        }
    }
}
