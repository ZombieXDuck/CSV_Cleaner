using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Cleaner
{
    class FileHandler
    {
        public string readFile(string path)
        {
            string database;
            return database = File.ReadAllText(path);
        }

        public void deleteFile(string path)
        {
            if (File.Exists("Clean Database.csv"))
            {
                File.Delete("Clean Database.csv");
            }
        }

        public void writeString(string str, string path)
        {
            using (FileStream fs = File.Create(path))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(str);
                fs.Write(info, 0, info.Length);
            }
        }
    }
}
