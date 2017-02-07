using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Cleaner
{
    class Cleaner
    {
        public void cleanFile()
        {
            FileHandler fileHandle = new FileHandler();
            MemberHandler memberHandle = new MemberHandler();

            fileHandle.deleteFile("Member Database.csv");
            string database = fileHandle.readFile("Member Database.csv");

            string[] members = memberHandle.splitMembers(database);
            string details = memberHandle.getDetails(members);

            fileHandle.writeString(details, "Clean Database.csv");
        }
    }
 }

