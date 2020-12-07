using OOP6.View;
using OOP6.Utils;
using OOP6.Models;

namespace OOP6
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = UserInput.GetInt();
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = UserInput.GetInt();
            }
            OutInConsole.Print(Logic.SymOfDigitsAfterLastZero(arr));
            OutInConsole.Print(Logic.GetSumSinceGreatestTillLowest(arr));
        }
    }
}
