using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurev2
{
    internal class Records_intro
    {
        struct Player // the fields of the record (columns of the table ig)
        {
            public string name;
            public int age;
            public string position;
            public string nationality;
            public int goals;
        }

        public static void Main_Records()
        {
            Player new_player = new Player(); // new record                         

            Console.WriteLine("Enter name: "); // data
            new_player.name = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            new_player.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter position: ");
            new_player.position = Console.ReadLine();
            Console.WriteLine("Enter nationality: ");
            new_player.nationality = Console.ReadLine();

            Player[] BristolFC = new Player[11]; // no. of players (size like an array)

            BristolFC[0] = new_player;
            Console.WriteLine(BristolFC[0]
                ); // doesn't output the data in the record 
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            for (int i = 0; i < BristolFC.Length; i++) // outputing the data in the fields
            {
                Console.WriteLine($"Name : {BristolFC[i].name}");
                Console.WriteLine($"Age : {BristolFC[i].age}");
                Console.WriteLine($"Position : {BristolFC[i].position}");
                Console.WriteLine($"Nationality : {BristolFC[i].nationality}");
            }
        }
    }
}
