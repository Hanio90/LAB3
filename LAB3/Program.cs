using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace LAB3
{
    class Program
    {
        static void Main(string[] args)
        {

            //bool Continue = true;
            //string choice = "";
            
            //while(Continue)
            //{
                Console.WriteLine("Hello! Please enter an integer:");
                int x = int.Parse(Console.ReadLine());


                Console.WriteLine("Number\t\tSquared\t\tCubed");
                Console.WriteLine("======\t\t=======\t\t=====");


                Console.WriteLine("{0}\t\t{1}\t\t{2}", x, Math.Pow(x, 2), Math.Pow(x, 3));
                Console.WriteLine("{0}\t\t{1}\t\t{2}", ++x, Math.Pow(x, 2), Math.Pow(x, 3));
                Console.WriteLine("{0}\t\t{1}\t\t{2}", ++x, Math.Pow(x, 2), Math.Pow(x, 3));
                Console.WriteLine("{0}\t\t{1}\t\t{2}", ++x, Math.Pow(x, 2), Math.Pow(x, 3));
                Console.WriteLine("{0}\t\t{1}\t\t{2}", ++x, Math.Pow(x, 2), Math.Pow(x, 3));
                Console.WriteLine("{0}\t\t{1}\t\t{2}", ++x, Math.Pow(x, 2), Math.Pow(x, 3));
                Console.WriteLine("{0}\t\t{1}\t\t{2}", ++x, Math.Pow(x, 2), Math.Pow(x, 3));
                Console.WriteLine("{0}\t\t{1}\t\t{2}", ++x, Math.Pow(x, 2), Math.Pow(x, 3));
                Console.WriteLine("{0}\t\t{1}\t\t{2}", ++x, Math.Pow(x, 2), Math.Pow(x, 3));
                Console.WriteLine("{0}\t\t{1}\t\t{2}", ++x, Math.Pow(x, 2), Math.Pow(x, 3));

                Console.WriteLine("Continue? Y/N");
                string response = Console.ReadLine();

                if (response.ToLower() == "yes" || response.ToLower() == "y")
                Main(args);

                else
                Console.WriteLine("Goodbye");



            //Console.WriteLine("Would you like to try again?");
            //choice = Console.ReadLine();

            //if (choice == "No")
            //    Continue = false;



            //}
        }

    }
   
}
