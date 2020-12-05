using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4.Utils
{
    static class UserInput
    {
        public static string GetString()
        {
            return Console.ReadLine();
        }
        public static int GetInt()
        {
            while (true)
            {
                try
                {
                    return Convert.ToInt32(GetString());
                }
                catch
                {
                    Console.WriteLine("Input correct data");
                }
            }
        }
    }
}
