using System;
using System.Collections;

namespace QuestionEight
{
    public delegate void NumArr();
    class Program
    {
        static void Main(string[] args)
        {
            NumArr num = () =>
            {
                ArrayList numbers = new ArrayList();
                numbers.Add(23);
                numbers.Add(21);
                numbers.Add(-1);
                numbers.Add(45);
                numbers.Add(-6);
                for (int i = 0; i < numbers.Count; i++)
                {
                    if ((int)numbers[i] < 0)
                        numbers[i] = "Codebits";
                    Console.WriteLine(numbers[i]);
                }               
            };
            num();
        }  
    }
}
