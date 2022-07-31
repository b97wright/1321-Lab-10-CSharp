using System;

namespace Lab10
{
    class Lab10B
    {

        static void Main(string[] args)
        {


            string uI;
            char choice = 'a';
            double x = 0, y = 0;
            decimal x1 = 0, y1 = 0;
            bool isPlaying = true;

            do
            {
                Console.Write("enter width: ");
                uI = Console.ReadLine();
                x = Convert.ToDouble(uI);
                x1 = Convert.ToDecimal(x);

                Console.Write("enter height: ");
                uI = Console.ReadLine();
                y = Convert.ToDouble(uI);
                y1 = Convert.ToDecimal(y);

                if (isValid(x,y))
                {
                    Console.WriteLine("This is a valid rectangle ");


                    Console.WriteLine("The area is: " + area(x,y) + ".0");
                    Console.WriteLine("The perimeter is: " + perimeter(x,y) + ".0 \n");
                }
                else
                {
                    Console.WriteLine("This is an invalid rectangle \n");
                }

                Console.Write("Do you want to enter another width and height (Y/N)? : ");
                uI = Console.ReadLine();
                choice = Convert.ToChar(uI);
                Console.Write("\n");

                isPlaying = (choice == 'Y' | choice == 'y' ? true : false);
                isPlaying = (choice == 'N' | choice == 'n' ? false : true);

            } while (isPlaying);

            Console.WriteLine("Program Ends ");
        }

        public static bool isValid(double width, double height)
        {
            if ((width + height) > 30)
                return true;
            return false;
        }
        public static double area(double width, double height)
        {
            return (width * height);
        }
        public static double perimeter(double width, double height)
        {
            return ((width * 2) + (height * 2));
        }

    }
}
