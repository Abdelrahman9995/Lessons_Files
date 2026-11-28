using System;

namespace Lessons
{
    class Assignment3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your KW Consume: ");
            double kw = double.Parse(Console.ReadLine());
            double fee = 15;
            double total;

            if(kw > 1000)
            {
                total = kw * 2.74;
            }
            else
            {
                double remaining;
                
                //Tier1
                if(kw > 50)
                {
                    total +=
                }
            }
        }
    }
}