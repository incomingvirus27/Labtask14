using System;

namespace QuestionSeven
{
    public delegate void Numbers();
    class Program
    {
        static void Main(string[] args)
        {
            Numbers numArr = () =>
            {
                int Num = 21;
                int[] NumArr = { 100, 3, 4, 5, 12, 78, 54, 3, 8 };
                for (int i = 0; i < NumArr.Length; i++)
                {
                    if (NumArr[i] > Num)
                    {
                        Console.Write(+NumArr[i] + " ");
                    }
                }
            };
            numArr();
           
        }
    }
}
