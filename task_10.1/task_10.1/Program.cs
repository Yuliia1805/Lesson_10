using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_10._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = Console.ReadLine();
            //printSymb(str);
            /*int a = 6;
            int b = 44;

            
            Console.WriteLine("A is: " + a);
            Console.WriteLine("B is: " + b);
            swap(ref a, ref b);
            Console.WriteLine("After swap");

            Console.WriteLine("A is: " + a);
            Console.WriteLine("B is: " + b);*/

            /* string symb;
             int count;
             Console.Write("Enter symbol to repeat: ");
             symb = Console.ReadLine();
             Console.Write("Enter count of repeating: ");
             count = int.Parse(Console.ReadLine());

             print(count, symb);*/


            /*long number;
            
            Console.Write("Enter a number for factorial:  ");
            number = long.Parse(Console.ReadLine());
            number = factor(number);
            Console.WriteLine("The result is: " + number);*/
            /*int n = 3;
            long res = factorial(n);*/

            print("H");
            Console.WriteLine();
            print("I", 45, 80);

            Console.ReadLine();
        }

        static void print(string symb, int count, int border)
        {
            starsPrint(border);
            print(symb, count);
            starsPrint(border);
        }

        static void starsPrint(int count)
        {
            for(int i = 0; i < count; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        static void print(string symb, int count)
        {
            for (int i = 0; i < count; i++)
            {
                print(symb);
            }
            Console.WriteLine();
        }

        static void print(string symb)
        {
                Console.Write(symb + "\t");
        }

        static void printSymb(string symb)
        {
            Console.WriteLine(symb);
        }

        static void swap (ref int first, ref int second)
        {
            int temp = first;
            first = second;
            second = temp;
        }

        static long factor(long number)
        {
            long multiple = 1;
            for (int i = 1; i <= number; i++)
            {
                multiple *= i;
            }

            return multiple; 
        }
        static long factorial(int n)
        {
            if(n == 0) return 1;
            Console.WriteLine(n);
            return n * factorial(n - 1);
        }

        static void printNumber(int num)
        {
            Console.WriteLine("Integer: " + num);
        }
        static void printNumber(double num)
        {
            Console.WriteLine("Double: " + num);
        }


    }
 }

