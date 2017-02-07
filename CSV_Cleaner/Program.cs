using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Cleaner
{
    class Program
    {
        static void Main(string[] args)
        {
            Finder find = new Finder();
            //Read database
            string database = File.ReadAllText("Member Database.csv");
            //Split into members
            string[] member = database.Split('\n');
            string[] details;
            //Remaining Values
            string first_name, surname, email;

            //Delete previous cleaner
            if (File.Exists("Clean Database.csv"))
            {
                File.Delete("Clean Database.csv");
            }
                        
            using (FileStream fs = File.Create("Clean Database.csv"))
            {
                //For each member
                for (int i = 0; i < member.Length; i++)
                {
                    details = member[i].Split(',');
                    first_name = details[2];
                    surname = details[3];
                    email = find.findEmail(details);
                    if(email == "" || email == "Plantsplus@clyx.com.au" || email == "plantsplus@clyx.com.au")
                    {
                        continue;
                    }
                    byte[] memberInfo = new UTF8Encoding(true).GetBytes(first_name+","+surname+","+email+"\n");
                    fs.Write(memberInfo, 0, memberInfo.Length);
                }
            }
            Console.ReadLine();
        }
    }
}
