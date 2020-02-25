using System;
using System.Collections;

namespace Lab4_6_Array_To_Do_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Peter's World!");

            string[] days = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            string[] tasks = new string[7];

            for (int i = 0; i < days.Length; i++)
            {

                Console.WriteLine("Type in a new Task for " + days[i]);
                tasks[i] = days[i] + " : " + Console.ReadLine();

            }

            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(tasks[i]);
            }   }
    }
}
