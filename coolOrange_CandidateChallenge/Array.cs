using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coolOrange_CandidateChallenge
{
    public class Array
    {
        // Todo
        public static int FindMaxValue(int[] array, int position1, int position2)
        {
            int ret = 0;
            for (int i = position1; i < position2; i++)
            {
                if (array[i] > ret)
                {
                    ret = array[i];
                }
            }
            return ret;
        }
        public static int FindMinPosition(int[] array, int position1, int position2)
        {
            int ret = 2147483647;
            for (int i = position1; i < position2; i++)
            {
                if (array[i] < ret)
                {
                    ret = array[i];
                }
            }
            return ret;
        }
        public static void Swap(int[] array, int position1, int position2)
        {
            int help = array[position1];
            array[position1] = array[position2];
            array[position2] = help;
        }
        public static void ShiftLeftByOne(int[] array, int position1, int position2)
        {
            if (position1 > position2)
            {
                int hilfe = array[position1];
                array[position1] = array[position2];
                array[position2] = hilfe;
            }
            int hilfe2 = array[position1];
            for (int i = position1; i < position2; i++)
            {
                if (i + 1 != position2)
                {
                    array[i] = array[i + 1];
                }
                else
                {
                    array[i] = hilfe2;
                }
            }
        }
        public static int[] CreateRandomArray(int size, int minValue, int maxValue)
        {
            int[] ret=new int[size];
            if (minValue > maxValue)
            {
                int hilfe = minValue;
                minValue = maxValue;
                maxValue = hilfe;
            }
            Random rand = new Random();
            for (int i=0; i < size;i++)
            {
                ret[i] = rand.Next(minValue,maxValue+1);
            }
            return ret;
        }
        public static int[,] CreateRandomMatrix(int rows, int columns, int minValue, int maxValue)
        {
            int[,] ret=new int[rows, columns];
            Random rand=new Random();
            for (int i=0; i<rows;i++)
            {
                for (int j=0;j<columns;j++)
                {
                    ret[i,j] = rand.Next(minValue,maxValue+1);
                }
            }
            return ret;
        }
        public static int[,] CopyArray(int[] array)
        {
            int[,] ret = new int[2, array.Length];
            for (int i =0; i < array.Length; i++)
            {
                ret[0,i] = array[i];
                ret[1,i] = array[i];
            }
            return ret;
        }
        public static int FindInSortedArrary(int[] array, int number)
        {
            int ret = -1;
            if (array.Length > 0)
            {
                int a = 0;
                int b = array.Length-1;
                bool x = false;
                while (a <= b && !x) 
                {
                    int mid = (a+b)/2;
                    if (array[mid]==number)
                    {
                        ret = mid;
                        x = true;
                    } else if (array[mid] < number) 
                    {
                        a = mid + 1;
                    } else
                    {
                        b = mid - 1;
                    }
                }
            }
            return ret;
        }

    }
}
