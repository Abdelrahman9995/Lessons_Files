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
                    total += 50 * 0.68;
                    remaining -= 50;
                }
                else
                {
                    total += remaining * 0.68;
                    remaining = 0;
                }

                //Tier2
                 if(kw > 50)
                {
                    total += 50 * 0.95;
                    remaining -= 50;
                }
                else
                {
                    total += remaining * 0.95;
                    remaining = 0;
                }

                //Tier3
                 if(kw > 100)
                {
                    total += 100 * 1.15;
                    remaining -= 100;
                }
                else
                {
                    total += remaining * 1.15;
                    remaining = 0;
                }

                //Tier4
                 if(kw > 150)
                {
                    total += 150 * 1.72;
                    remaining -= 150;
                }
                else
                {
                    total += remaining * 1.72;
                    remaining = 0;
                }

                //Tier5
                 if(kw > 200)
                {
                    total += 200 * 2.18;
                    remaining -= 200;
                }
                else
                {
                    total += remaining * 2.18;
                    remaining = 0;
                }
            }

            total += fee;
            Console.Write
        }
    }
}