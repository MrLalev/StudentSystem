using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataBaseWinApp.Enteties
{
    class MyMessage : BaseEntety
    {
        public string From;
        public string To;
        public string Tittle;
        public string Content;
        public bool seen;
    }
}
