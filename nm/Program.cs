using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nm
{
    class Program
    {

        static void midpoint()
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("mid.txt");


            Console.WriteLine("Start Value for the f(x) values (without the letter):");
            int start = Convert.ToInt32(Console.ReadLine()); //Value of the starting row in table of values

            Console.WriteLine("Total number of rectangles: ");
            int n = Convert.ToInt32(Console.ReadLine()); //The maximum number of rectangles to be used

            Console.WriteLine("Number of rectangles: ");
            int m = Convert.ToInt32(Console.ReadLine()); //Number of stripes that need to be calculated

            Console.WriteLine("a: ");
            int a = Convert.ToInt32(Console.ReadLine()); //a value for the definite integral

            Console.WriteLine("b: ");
            int b = Convert.ToInt32(Console.ReadLine()); //b value for the definite integral

            Console.WriteLine("Column for f(x): ");
            string f = Console.ReadLine(); //Just the letter of the column where the f(x) values are

            Console.WriteLine("Location of h: ");
            string ch = Console.ReadLine(); //the cell ref where the h value is

            string s = "=" + ch + "*(";



            double h = (double)(b - a) / (double)m;
            double step = (double)(b - a) / (double)n;

            for (int i = 1; i <= m; i++)
            {
                double d = (h / 2) * (2 * i - 1) / step;
                int z = Convert.ToInt32(d);
                s += f + Convert.ToString(z + start) + "+";
            }
            s = s.Remove(s.Length - 1);
            s += ")";
            file.WriteLine(s);
            file.Close();
            Console.WriteLine(s);
            Console.ReadLine();
        }


        static void trapezium()
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("trap.txt");

            Console.WriteLine("Cell reference for f(a): ");
            string fa = Console.ReadLine(); 

            Console.WriteLine("Cell reference fo f(b): ");
            string fb = Console.ReadLine();

            Console.WriteLine("Cell refercence for h/2: ");
            string s = "="+Console.ReadLine()+"*(" + fa + "+" + fb + "+2*(";

            Console.WriteLine("Start Value for the f(x) values (without the letter):");
            int start = Convert.ToInt32(Console.ReadLine()); //Value of the starting row in table of values

            Console.WriteLine("Total number of rectangles: ");
            int n = Convert.ToInt32(Console.ReadLine()); //The maximum number of rectangles to be used

            Console.WriteLine("Number of rectangles: ");
            int m = Convert.ToInt32(Console.ReadLine()); //Number of stripes that need to be calculated

            Console.WriteLine("a: ");
            int a = Convert.ToInt32(Console.ReadLine()); //a value for the definite integral

            Console.WriteLine("b: ");
            int b = Convert.ToInt32(Console.ReadLine()); //b value for the definite integral

            double h = (double)(b - a) / (double)m;
            double step = (double)(b - a) / (double)n;

            for (int i = 1; i < m; i++)
            {
                double d = (h / step) * i;
                int z = Convert.ToInt32(d);
                s += "B" + Convert.ToString(z + start) + "+";
            }
            s = s.Remove(s.Length - 1);
            s += "))";
            file.WriteLine(s);
            file.Close();
            Console.WriteLine(s);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            int i = -1;
            while (i != 0)
            {
                Console.Clear();
                Console.WriteLine("1. Midpoint");
                Console.WriteLine("2. Trapezium");
                Console.WriteLine("0. Exit");
                i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        midpoint();
                        break;
                    case 2: 
                        trapezium();
                        break;
                }
            }
        }
    }
}
