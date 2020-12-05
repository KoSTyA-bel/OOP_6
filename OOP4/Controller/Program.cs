using OOP4.View;
using OOP4.Utils;
using OOP4.Models;

namespace OOP4
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
        }
    }
}
