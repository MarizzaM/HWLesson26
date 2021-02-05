using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson26
{
    class Program
    {
        static void Main(string[] args)
        {
            MyProtectedUniqueList<string> myList = new MyProtectedUniqueList<string>("love");

            myList.Add("Enjoy");
            myList.Add("every");
            myList.Add("moment");

            //myList.Add("Enjoy");
            //myList.Remove("f");
            //myList.Clear("e");
            myList.Clear("love");
            
            myList.Add("z");
            myList.Add("y");
            myList.Add("x");

            //myList.Sort("qq");
            myList.Sort("love");

            //myList.RemoveAt(-1);
            Console.WriteLine(myList);
        }
    }
}
