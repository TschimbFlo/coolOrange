using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coolOrange_CandidateChallenge
{
    class Test
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PalindromeChecker.IsPalindrome("noon"));
            int[] n = { 4, 8, 1, 9 };
            Console.WriteLine(Array.FindMaxValue(n, 0, 3));

            Console.WriteLine(Array.FindMinPosition(n, 0, 3));

            Console.WriteLine();
            Array.Swap(n, 2, 3);
            for(int i=0;i<n.Length;i++) {
                Console.WriteLine(n[i]); 
            }
            Console.WriteLine();

            Array.ShiftLeftByOne(n, 0, 2);
            Console.WriteLine();
            Array.Swap(n, 2, 3);
            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine(n[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            int[] x = Array.CreateRandomArray(4, 1, 10);
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            int[,] m = Array.CreateRandomMatrix(4,4,0,10);
            for (int i = 0; i < 4; i++)
            {
                for (int j=0;j<4; j++)
                {
                    Console.Write(m[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int[] originalArray = { 1, 2, 3, 4, 5 };
            int[,] copiedArray = Array.CopyArray(originalArray);
            Console.WriteLine("Original Array:");
            for (int i = 0; i < originalArray.Length; i++)
            {
                Console.Write(originalArray[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Copied Array:");
            for (int i = 0; i < copiedArray.GetLength(1); i++)
            {
                Console.Write(copiedArray[0, i] + " ");
                Console.Write(copiedArray[1, i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(Array.FindInSortedArrary(originalArray, 4));
            Test test = new Test();
        }
    }
}
