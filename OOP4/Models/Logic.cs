using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4.Models
{
    static class Logic
    {
        public static string SymOfDigitsAfterLastZero(int[] array)
        {
            int maxIndexZero = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    maxIndexZero = i;
                }
            }
            if (maxIndexZero != -1 && maxIndexZero + 1 != array.Length)
            {
                int sum = 0;
                for (int i = maxIndexZero; i < array.Length; i++)
                {
                    sum += array[i];
                }
                return Convert.ToString(sum);
            }
            return "No sum";
        }
    }
}
