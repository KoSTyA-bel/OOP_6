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
            if (Array.LastIndexOf(arr, arr.Max()) < Array.LastIndexOf(arr, arr.Min()))
            {
                return arr.Skip(Array.LastIndexOf(arr, arr.Min()))
                    .Take(Array.LastIndexOf(arr, arr.Min()) - Array.LastIndexOf(arr, arr.Max()))
                    .Sum();
            }
            return arr.Skip(Array.LastIndexOf(arr, arr.Max()))
                .Take(Array.LastIndexOf(arr, arr.Max()) - Array.LastIndexOf(arr, arr.Min()))
                .Sum();
        }
    }
}
