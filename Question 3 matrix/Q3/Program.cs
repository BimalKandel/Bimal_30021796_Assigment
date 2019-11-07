using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            //*Arrays a, b and c*//
            int[,] a = new int[3, 3];
            int[,] b = new int[3, 3];
            int[,] c = new int[3, 3];

            //*Name of the Program*//
            Console.WriteLine("**********************************");
            Console.WriteLine("*****Matrix Addition Program******");
            Console.WriteLine("**********************************");

            Console.WriteLine();

            //*Random class object*//
            Random r = new Random();


            //*Putting Random numbers in Array a*//
            for (int d = 0; d < 3; d++)
            {
                for (int e = 0; e < 3; e++)
                {
                    a[d, e] = r.Next(-10, +10);
                }
            }

            //*Putting Random numbers in Array b*//
            for (int d = 0; d < 3; d++)
            {
                for (int e = 0; e < 3; e++)
                {
                    b[d, e] = r.Next(-10, +10);
                }
            }

            Console.WriteLine("Matrix A");

            //*printing array a*//
            for (int d = 0; d < 3; d++)
            {
                for (int e = 0; e < 3; e++)
                {
                    Console.WriteLine(a[d, e].ToString());
                }
            }

            Console.WriteLine();
            Console.WriteLine("Matrix B");

            //*printing array b*//
            for (int d = 0; d < 3; d++)
            {
                for (int e = 0; e < 3; e++)
                {
                    Console.WriteLine(b[d, e].ToString());
                }
            }

            //*calculation for array c*//
            for (int d = 0; d < 3; d++)
            {
                for (int e = 0; e < 3; e++)
                {
                    c[d, e] = a[d, e] + b[d, e];
                }
            }

            Console.WriteLine();
            Console.WriteLine("Matrix C");

            //*printing array c*//
            for (int d = 0; d < 3; d++)
            {
                for (int e = 0; e < 3; e++)
                {
                    Console.WriteLine(c[d, e].ToString());
                }
            }


            Console.ReadLine();
            //*program end*//
        }
    }
}
