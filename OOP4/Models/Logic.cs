using System;
using System.Linq;

namespace OOP6.Models
{
    static class Logic
    {
        public static string SymOfDigitsAfterLastZero(int[] array)
        {
            return Convert.ToString(array.Skip(Array.LastIndexOf(array, 0)).Sum());
        }

        public static void swap(ref int x, ref int y)
        { 
            x = x ^ y;
            y = y ^ x;
            x = x ^ y;
        }


        private static int GetGreatestNumberIndex(int[] arr)
        {
            int imax = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > arr[imax])
                {
                    imax = i;
                }
            }
            return imax;
        }

        private static int GetLowestNumberIndex(int[] arr)
        {
            int imin = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < arr[imin])
                {
                    imin = i;
                }
            }
            return imin;
        }


        public static int GetSumSinceGreatestTillLowest(int[] arr)
        {
            if (arr.Length < 1)
            {
                return -1;
            }
            else if(arr.Length == 1)
            {
                return arr[0];
            }
            int sum = 0;
            int imax = GetGreatestNumberIndex(arr);
            int imin = GetLowestNumberIndex(arr);
            if (imin > imax)
            {
                swap(ref imin, ref imax);
            }
            for(int i = imin; i <= imax; i++)
            {
                sum += arr[i];
            }
            return sum;
        }



    }
}
