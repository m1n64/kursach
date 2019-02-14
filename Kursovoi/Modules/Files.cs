using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovoi.Modules
{
    class Files
    {
        public static string[] OpenReadFileLines(string file)
        {
            List<string> lines = new List<string>();
            StreamReader read = new StreamReader(file);

            while (!read.EndOfStream)
            {
                lines.Add(read.ReadLine());
            }

            read.Close();
            return lines.ToArray();
        }

        public static string OpenReadFile(string file)
        {
            string sr = string.Empty;
            StreamReader read = new StreamReader(file);

            while (!read.EndOfStream)
            {
                sr += read.ReadLine();
            }

            read.Close();
            return sr;
        }

        public static void OpenWriteFile(string path, string data)
        {
            StreamWriter write = new StreamWriter(path, true, Encoding.UTF8);
            write.WriteLine(data);
            write.Close();
        }

        public static void OpenWriteFile(string path, string[] data)
        {
            StreamWriter write = new StreamWriter(path, true, Encoding.UTF8);
            foreach(string s in data)
            {
                write.WriteLine(s);
            }
            write.Close();
        }
    }
}
