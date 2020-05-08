using System;

namespace QuestionEight
{
    class Program
    {
        static void Main(string[] args)
        {             
                int[] numbers = { 3, 4, -5, 7, -8 };
                string a = "Codebits"
                for (int i = 0; i < numbers.Length; i++)
                {

                    if (numbers[i] < 0)
                    {
                        numbers[i] = a;
                    }
                    Console.Write(+numbers[i] + " ");
                };
            }
       
        }  
    }
}
