using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace recursion
{
    internal class Program
    {
        public static int fibonachi(int index)
        //the fibbonachi number at the specified index
        {
            if (index == 1)
            {
                return 0;
            }
            if (index == 2)
            {
                return 1;
            }
            return fibonachi(index - 2) + fibonachi(index - 1);
        }
        public static int Sum(int n)
        // sum of all the numbers up to (and including) n
        {
            if (n == 0)
            {
                return 0;
            }
            return n + Sum((n - 1));
        }
        public static int digitSum(int n)
        // the sum of n's digits
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
        //factorail of n
        {
            if (n == 0)
            {
                return 1;
            }
            return n * Factorial((n - 1));
        }
        public static int Factorial2(int n)
        //non-recursive solution to a factorial
        {
            int z = 0;
            for (int i = 0; i < n; i++)
            {
                z = i * (i + 1);
            }
            return z;
        }
        public static int DigitCount(int n)
        // count the amount of digits in an integer
        {
            if (n == 0)
            {
                return 0;
            }
            return 1 + DigitCount((n / 10));
        }
        public static void print(int n)
        //print  a triangle (in descending amounts of stars)
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
        public static int recXpowY(int x, int y)
        // x to the power of y
        {
            if (y == 0)
            {
                return 1;
            }
            return x * recXpowY(x, y - 1);
        }

        public static bool isDevisible(int x, int y)
        // is y devisible by x
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
        // is x a prime
        {
            if (x == 2 || x == 3)
            {
                return true;
            }
            if (digitSum(x) % 3 == 0)
            {
                return false;
            }
            return true;
        }
        static bool isPrimeV2(int n, int i)
        //determines if n is prime (i has to be given the value of 2 in the main method)
        {

            // Base cases
            if (n <= 2)
                return (n == 2) ? true : false;
            if (n % i == 0)
                return false;
            if (i * i > n)
                return true;

            // Check for next divisor
            return isPrimeV2(n, i + 1);
        }
        public static void fillArray(int[] arr, int i)
        //input values into the array (i has to be given the value of 0 in the main method)
        {
            if (i < arr.Length)
            {
                Console.WriteLine("input a value");
                arr[i] = int.Parse(Console.ReadLine());
                fillArray(arr, i + 1);
            }
        }
        public static void printArray(int[] arr, int i)
        //print an array (i has to be given the value of 0 in the main method)
        {
            if (i < arr.Length)
            {
                Console.WriteLine(arr[i]);
                printArray(arr, i + 1);
            }
        }
        public static int findIndex(int[] arr, int i, int index)
        //returns the index of the element index in the array arr (i has to be given the value of 0 in the main method)
        {
            if (i < arr.Length)
            {
                if (arr[i] == index)
                {
                    return i;
                }
                if (arr[i] != index && i + 1 == arr.Length)
                {
                    return -1;
                }
            }
            return findIndex(arr, i + 1, index);
        }
        public static int sumOfArray(int[] arr, int i, int sum)
        //returns the sum of the arrays elements (i and sum have to be given the value of 0 in the main method)
        {
            if (i < arr.Length)
            {
                sum += arr[i];
                return sumOfArray(arr, i + 1, sum);
            }
            return sum;
        }
        public static int sumOfArrayV2(int[] arr, int i)
        //returns the sum of the arrays elements (i has to be given the value of 0 in the main method)
        {
            if (i == arr.Length)
            {
                return 0;
            }
            return arr[i] + sumOfArrayV2(arr, i + 1);
        }
        public static int minimalElement(int[] arr, int i, int min)
        // returns the value of the smallest element in the array 
        // (i has to be given the value of 0 and min the int.MaxValue in the main method)
        {
            if (i < arr.Length)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                return minimalElement(arr, i + 1, min);
            }
            return min;
        }
        public static int maximalElement(int[] arr, int i, int max)
        //find the value of the largest element in the array
        //(i has to be given the value of 0 and max the int.MinValue in the main method)
        {
            if (i < arr.Length)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                return maximalElement(arr, i + 1, max);
            }
            return max;
        }
        public static bool isSorted (int[] arr, int i)
        {
            if (i==arr.Length-1)
            {
                return true;
            }
            if (arr[i] > arr[i+1])
            {
                return false;
            }
            return isSorted(arr, i+1);
        }



        public static void Main(string[] args)
        {
            int i =0;
            int sum = 0;
            int min = int.MaxValue; 
            int max = int.MinValue;
            //int n = Sum(10);
            //int z = Factorial(3);
            //int y = Factorial2(3);
            //int x = DigitCount(123);
            //int w = fibonachi(10);
            //int t = recXpowY(3,5);
            //bool u = isDevisible(3,15);
            //int o = digitSum(15);
            //int a = findIndex(new int[] { 1, 2, 3, 4, }, i, 3);
            int b = sumOfArray(new int[] { 1, 2, 3,},i,sum);
            //Console.WriteLine(n);
            //Console.WriteLine(z);
            //Console.WriteLine(y);
            //Console.WriteLine(x);
            //Console.WriteLine(w);
            //print(5);
            //Console.WriteLine(t);
            //Console.WriteLine(u);
            //Console.WriteLine(o);
            //Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadKey();


        }
    }
}
