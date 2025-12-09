using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurev2
{
    internal class Intro_to_lists
    {
        public static void Intro_Lists_Main()
        {
            List<int> marks = new List<int>();
            List<string> students = new List<string>();

            int mark = 0;
            string student = "";

            do
            {
                Console.Write("Enter Student:");
                student = Console.ReadLine();
                students.Add(student);

                Console.Write("Enter Mark:");
                mark = Convert.ToInt32(Console.ReadLine());
                marks.Add(mark);

            }
            while (student != "");

            foreach (int i in marks) { Console.Write(i); }
            foreach (string i in students) { Console.Write(i); }

        }
    }
}
