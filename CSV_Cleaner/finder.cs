using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Cleaner
{
    class Finder
    {
        public string findEmail(string[] details)
        {
            for(int i = 0; i<details.Length; i++)
            {
                if(details[i].Contains("@"))
                {
                    return details[i];
                }
            }
            return "";
        }
    }
}
