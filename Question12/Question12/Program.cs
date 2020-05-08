using System;
using System.Globalization;

namespace Question12
{
    public delegate void NumArr();
    class Program
    {
        static void Main(string[] args)
        {
            NumArr numbers = () =>               
            {
                int[] numbers = { 3, 4, -5, 7, -8 };
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] < 0)
                    {
                        numbers[i] = 0;
                    }
                    Console.Write(+numbers[i] + " ");
                }
            };
            numbers();
        }
    }
}
