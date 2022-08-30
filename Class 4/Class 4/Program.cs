using System;

namespace _3033_4_lc_0830_loopsmethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 15;
            for (; ; )
            {
                i++;
                if (i > 20)
                {
                    break; //stops the loop
                }
                if (i == 13 || i == 17)
                {
                    continue;
                }
                Console.WriteLine(i);

            }
            Console.WriteLine("This is the result of the for loop");
            i = 10;
            while (i <= 20)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine("Results from while loop");

            i = 10;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 20);

            Console.WriteLine("Results from do while loop");

            //Methods functions
            DataType functions_name(DataType var1, DataType var2, ...){

                return product;
            }
            Console.WriteLine("Methods/functions results");
            double testN = 10.2;
            getLargeDblVal(testN, 100);
            Console.ReadLine();

            double getLargeDblVal(double dbl1, double dbl2)
            {
                double product;
                if (dbl1 > dbl2)
                {
                    product = dbl1;
                }
                else
                {
                    product = dbl2;
                }

                return 0;
            }
        }
    }
}