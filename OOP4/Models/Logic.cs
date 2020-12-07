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

        public static int GetSumSinceGreatestTillLowest(int[] arr)
        {
            int maxInd = Array.LastIndexOf(arr, arr.Max());
            int minInd = Array.LastIndexOf(arr, arr.Min());
            return arr[Math.Min(maxInd, minInd)..Math.Abs(maxInd - minInd)]
                    .Sum();
        }
    }
}
