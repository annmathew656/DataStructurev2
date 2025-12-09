namespace DataStructuresv2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arrays_intro();
            //Arrays_Exam_marks();
            //Arrays_rainfall();
            //Arrays_Multi_marks();
            //Intro_to_lists.Intro_Lists_Main();
            //Records_intro.Main_Records();
        }


        public static void Arrays_intro()
        {
            int[] votes = new int[4] { 2300, 1091, 105, 7891 };

            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("Candidate {0} had {1} votes.", i + 1, votes[i]);
            }
        }

        public static void Arrays_Exam_marks()
        {
            int[] marks = new int[5];
            int total = 0;

            for (int i = 0; i <= marks.Length; i++)
            {

                Console.WriteLine("Enter mark:");
                marks[i] = Convert.ToInt32(Console.ReadLine());
                total += marks[i];
            }
            Console.WriteLine("Average:" + total / marks.Length);
        }

        public static void Arrays_rainfall()
        {
            int[] months = new int[12];
            int total = 0;

            for (int i = 0; i <= 11; i++)
            {

                Console.WriteLine("Enter rainfall in mm:");
                months[i] = Convert.ToInt32(Console.ReadLine());
                total += months[i];
            }
            int average = total / 12;

            Console.WriteLine($"Total: {total}");
            Console.WriteLine($"Average: {average}");

            for (int i = 0; i <= 11; i++)
            {
                if (months[i] > average)
                {
                    Console.WriteLine($"Month {i + 1} is above the mean.");
                }

            }

        }

        public static void Arrays_Multi_marks()
        {
            string[,] students_marks = new string[5, 2];
            int total = 0;

            for (int r = 0; r < students_marks.Length; r++)
            {
                Console.Write("Enter student:");
                students_marks[r, 0] = Console.ReadLine();
                Console.Write("Enter mark:");
                students_marks[r, 1] = Console.ReadLine();

                int mark = Convert.ToInt32(students_marks[r, 1]);
                total += mark;


            }
            Console.Write($"Average: {total / students_marks.Length}");
        }


    }
}
