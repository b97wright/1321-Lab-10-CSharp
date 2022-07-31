using System;

namespace Lab10
{
    class Lab10A
    {

        static void Main(string[] args)
        {
            string uI;
            double x = 0, y = 0, temp = 0, sum = 0;

            Console.Write("enter number 1: ");
            uI = Console.ReadLine();
            x = Convert.ToDouble(uI);

            Console.Write("enter number 2: ");
            uI = Console.ReadLine();
            y = Convert.ToDouble(uI);

            if (y < x)
            {
                temp = x;
                x = y;
                y = temp;
            }
            
            Console.WriteLine("Min is " + x);

            Console.WriteLine("Max is " + y);

            sum = amongus(x, y);


            Console.WriteLine("Average is " + sum);
        }

        public static double amongus (double sus1, double sus2)
        {
            double sus = 0;

            sus = (sus1 + sus2) / 2;

            return sus;
        }

    }
}
