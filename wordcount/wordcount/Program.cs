using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace wordcount
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get line with max word count
            // test
            IEnumerable<string> filedata = File.ReadLines(@"C:\Anil\Test.txt");
            char[] seperator = { ' ' };
            int maxcount = 0;
            List<string> strlist = new List<string>();
            strlist.Add("");
            foreach(string str in filedata)
            {
                if (maxcount < str.Split(seperator, StringSplitOptions.RemoveEmptyEntries).Count())
                {
                    maxcount = str.Split(seperator, StringSplitOptions.RemoveEmptyEntries).Count();
                    strlist[0] = str;
                }
                else if (maxcount == str.Split(seperator, StringSplitOptions.RemoveEmptyEntries).Count())
                {
                    strlist.Add(str);
                }
            }

            foreach (string s in strlist)
                Console.WriteLine(s);

            Console.WriteLine("Word Count="+maxcount);
        }
    }
}
