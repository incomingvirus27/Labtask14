using System;
using System.Collections.Generic;

namespace QuestionFour
{
    public delegate void Numbers();
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[25];
            Numbers number = () =>
            {
                List<int> numbers = new List<int>();
                for (int i = 0; i < 255; i++)
                {
                    if (i % 2 != 0)
                    {
                        numbers.Add(i);
                    }
                }
                foreach (int item in numbers)
                {
                    Console.WriteLine(item);
                }

            };
            number();
           
        }
    }
}
