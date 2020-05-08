using System;

namespace QuestionThirteen
{
    public delegate void IntegerDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            IntegerDelegate ShiftArray = () =>
            {
                int[] ArrShift = { 2, 5, 4, 7, 1, 8 };
                int count = 1;
                for (int i = 0; i < ArrShift.Length; i++)
                {
                    if (count == ArrShift.Length)
                    {
                        ArrShift[i] = 0;
                    }
                    else
                    {
                        ArrShift[i] = ArrShift[i + 1];
                    }

                    Console.Write(ArrShift[i] + ",");
                    count++;
                }
            };
            ShiftArray();
        }
    }
}
