using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Cleaner
{
    class MemberHandler
    {
        private string str_details;

        public string[] splitMembers(string Database)
        {
            string[] members;
            members = Database.Split('\n');
            return members;
        }

        public string getDetails(string[] members)
        {
            Finder find = new Finder();
            string[] details;
            string email;
            for (int i = 0; i < members.Length; i++)
            {
                details = members[i].Split(',');
                email = find.findEmail(details);
                if (email == "" || email == "Plantsplus@clyx.com.au" || email == "plantsplus@clyx.com.au")
                {
                    continue;
                }
                str_details += details[2] + "," + details[3] + "," + email + "\n";
            }
            return str_details;
        }
    }
}
