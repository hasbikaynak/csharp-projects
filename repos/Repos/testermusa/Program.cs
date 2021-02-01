using System;

namespace switch_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number plz ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(GetDay(number));
            Console.ReadLine();


        }
        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;  // if we dont put the break here, c sharp is gonna check all the other cases
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;

                default:
                    dayName = "Invalid day number";
                    break;
            }


            return dayName;



        }
    }
}