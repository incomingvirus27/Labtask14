using System;

namespace QuestionSix
{
    public delegate void Numbers();
    class Program
    {
        static void Main(string[] args)
        {
            Numbers number = () =>
            {
                int[] numbers = { 11, 2, 3, 4, 5, 6, 1 };
                int sum = 0;
                int max = numbers[0];
                int min = numbers[0];
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] > max)
                    {
                        max = numbers[i];
                    }
                    if (numbers[i] < min)
                    {
                        min = numbers[i];
                    }

                    sum += numbers[i];
                }
                int result = sum / numbers.Length;
                Console.WriteLine("The maximum number is: {0}\nThe minimum number is: {1}\nThe average of the numbers is: {2}", max, min, result);
            };
            number();
        }
    }
}
