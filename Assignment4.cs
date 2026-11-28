using System;

namespace Lessons
{
    class Assignment4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Days: ");
            int days = int.Parse(Console.ReadLine());

            Console.Write("Enter Month: ");
            int months = int.Parse(Console.ReadLine());

            Console.Write("Enter year (yy): ");
            int year = 2000 + int.Parse(Console.ReadLine()); // 2000 to 2099 only

            int[] daysInMonths = { 31, 28 ,31 ,30, 31, 30, 31, 31, 30, 31 ,30 ,31};

            if(year % 4 == 0)
            {
                daysInMonths[1] = 29;
            }

            int julainday = days;
            for(int i = 0; i < months - 1; i++)
            {
                
            }


        }
    }
}