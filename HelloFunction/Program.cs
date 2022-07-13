// See https://aka.ms/new-console-template for more information



using System;

namespace HelloFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {1, 2, 3, 4, 5, 11};
            // Console.WriteLine("I is: ");
            // int x = Convert.ToInt32(Console.ReadLine());

            // int position = Search(a, x);
            // if (position == -1) Console.WriteLine("Not found");

            // else Console.WriteLine("Found at " + position);

            int s = Sum(a);
            Console.WriteLine("Sum of array: " + s);

            int ss = Sumofeven(a);
            Console.WriteLine("Sum of even array: " + ss);

            int sss = Sumofodd(a);
            Console.WriteLine("Sum of odd array: " + sss);

            
            Console.WriteLine("Even or Odd?");
            Console.WriteLine("1. Sum of even" );
            Console.WriteLine("2. Sum of odd" );

            int choice = Convert.ToInt32(Console.ReadLine());

            // if (choice == 1)
            // {
                
            //     Console.WriteLine("Sum of even: " + SumEvenorOdd(a, true));
            // }
            // if  (choice == 2)
            // {
                
            //     Console.WriteLine("Sum of odd: " + SumEvenorOdd(a, false));
            // }

            if (choice == 1)
            {
                Console.WriteLine("Number of array: " + Count(a, true));
            }
            if (choice == 2)
            {
                Console.WriteLine("Number of array: " + Count(a, false));
            }
            
        }

        static int Search(int[] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (x == arr[i]){
                    return i;
                }
                
            }
            return -1;
        }

        static int Sum(int[] a)
        {
            int s = 0;
            for (int i = 0; i < a.Length; i++)
            {
                s = s + a[i];
                
            }
            return s;
        }

        static int Sumofeven(int[] a)
        {
            int ss = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i]%2 == 0)
                {
                    ss = ss + a[i];
                }
            }
            return ss;
        }

        static int Sumofodd(int[] a)
        {
            int sss = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i]%2 != 0)
                {
                    sss = sss + a[i];
                }
            }
            return sss;
        }

        static int SumEvenorOdd(int[] a, bool even)
        {
            int sx = 0;
            for (int i = 0; i < a.Length; i++)
            {
                // if (even && a[i] % 2 == 0)
                // {
                //     s += a[i];
                // }
                // if (!even && a[i] % 2 != 0) 
                // {
                //     s += a[i];
                // }

                if ((a[i] % 2 == 0) == even)
                    sx += a[i];
            }
            return sx;
        }

        static int Count (int[] a, bool even)
        {
            int c = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if ((a[i] % 2 == 0) == even)
                c++;
            }
            return c;
        }

        
    }
}