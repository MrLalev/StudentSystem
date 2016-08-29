using StudentDataBaseWinApp.Enteties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataBaseWinApp.Repo
{
    public abstract class BaseRepo<T> where T:BaseEntety, new()
    {
        public string SourceFile  { get; set; }

        public abstract void ReadFromSource(StreamReader sr, T item);
        public abstract void WriteToSource(StreamWriter sw, T item);

        public void Insert(T item)
        {
            item.Id = GenerateId();

            FileStream stream = new FileStream(SourceFile, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(stream);

            WriteToSource(sw,item);

            sw.Close();
            stream.Close();
        }

        public int GenerateId()
        {
            List<T> result = this.GetAll();
            int nextid = 1;

            foreach (T item in result)
            {
                nextid = item.Id + 1;
            }

            return nextid;
        }

        public List<T> GetAll()
        {
            List<T> result = new List<T>();

            FileStream stream = new FileStream(SourceFile, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(stream);

            while (sr.EndOfStream == false)
            {
                T item = new T();

                ReadFromSource(sr,item);

                result.Add(item);
            }

            sr.Close();
            stream.Close();
            return result;
        }

        public void Edit(T edit)
        {
            List<T> All = this.GetAll();
            List<T> result = new List<T>();

            foreach (T item in All)
            {
                if (item.Id == edit.Id)
                {
                    result.Add(edit);
                }
                else
                {
                    result.Add(item);
                }
            }


            OverWrite(result);
        }

        public void OverWrite(List<T> source)
        {
            FileStream stream = new FileStream(SourceFile, FileMode.Truncate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(stream);

            foreach (T item in source)
            {
                WriteToSource(sw,item);
            }

            sw.Close();
            stream.Close();
        }

        public void Delete(int id)
        {
            List<T> All = this.GetAll();
            List<T> result = new List<T>();
            foreach (T item in All)
            {
                if (item.Id != id)
                {
                    result.Add(item);
                }
            }

            OverWrite(result);
        }

        public T GetById(int id)
        {
            List<T> all = this.GetAll();
            T searched = new T();

            foreach (T item in all)
            {
                if (item.Id != id)
                {
                    searched = item;
                    break;
                }
            }

            return searched;
        }


    }
}
