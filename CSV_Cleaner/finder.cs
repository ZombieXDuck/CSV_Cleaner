namespace CSV_Cleaner
{
    class Finder
    {
        //Finds a email address in a given string array
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
