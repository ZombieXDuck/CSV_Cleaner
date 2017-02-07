using System.IO;
using System.Text;

namespace CSV_Cleaner
{
    class Program
    {
        static void Main(string[] args)
        {
            Cleaner clean = new CSV_Cleaner.Cleaner();
            clean.cleanFile();
        }
    }
}
