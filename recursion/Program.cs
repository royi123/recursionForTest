using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace recursion
{
    internal class Program
    {
        public static int fibonachi(int index)
        {
            if (index==1)
            {
                return 0;
            }
            if (index==2)
            {
                return 1;
            }
            return fibonachi(index -2)+fibonachi(index -1);
        }
        public static int Sum(int n) {
            if (n==0)
            {
                return 0;
            }
            return n+Sum((n-1));
        }
        public static int digitSum(int n)
        {
            if (n < 10)
            {
                return n;
            }
            else
            {
                int lastDigit = n % 10;
                int remainingDigits = n / 10;
                return lastDigit + digitSum(remainingDigits);
            }
        }
        public static int Factorial(int n)
        {
            if (n==0)
            {
                return 1;
            }
            return n*Factorial((n-1));
        }
        public static int Factorial2(int n)
        {
            int z=0;
            for (int i = 0; i < n; i++)
            {
                z=i * (i + 1);
            }
            return z;
        }
        public static int DigitCount(int n)
        {
            if (n==0)
            {
                return 0;
            }
            return 1+DigitCount((n/10));
        }
        public static void print(int n)
        {
            if (n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write("*");
                    Thread.Sleep(100);
                }
                Console.Write('\n');
                print(n - 1);
            }
        }
        public static int recXpowY(int x,int y)
        {
            if (y==0)
            {
                return 1;
            }
            return x*recXpowY(x,y-1);
        }

        public static bool isDevisible(int x,int y)
        {
            if (x > y && y == 0)
            {
                return true;
            }
            if (x > y && y != 0)
            {
                return false;
            }
                return isDevisible(x, y - x);
        }
        public static bool isPrime(int x)
        {
            if (x == 2 || x == 3)
            {
                return true;
            }
            if (digitSum(x)%3==0)
            {
                return false;
            }
                return true;
        }
        public static void fillArray(int[] arr,int i)
        {
            if (i==arr.Length)
            {
                Console.WriteLine("input a value");
                arr[i]= int.Parse(Console.ReadLine());
            }
            fillArray(arr,i+1);
        }


        static void Main(string[] args)
        {
            //int n = Sum(10);
            //int z = Factorial(3);
            //int y = Factorial2(3);
            //int x = DigitCount(123);
            //int w = fibonachi(10);
            //int t = recXpowY(3,5);
            //bool u = isDevisible(3,15);
            //int o = digitSum(15);
            //Console.WriteLine(n);
            //Console.WriteLine(z);
            //Console.WriteLine(y);
            //Console.WriteLine(x);
            //Console.WriteLine(w);
            //print(100);
            //Console.WriteLine(t);
            //Console.WriteLine(u);
            //Console.WriteLine(o);

            Console.ReadKey();


        }
    }
}
