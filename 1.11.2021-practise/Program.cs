using System;

namespace _1._11._2021_practise
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //Console.WriteLine(SumOfArray(new int[] { 5, 7, 3 }));
            #endregion

            #region Task 2
            //Console.WriteLine(FindInArray(new int[] { 2, 4, 6, 8 }, 5));
            //Console.WriteLine(FindInArray(new int[] { 2, 4, 6, 8 }, 6));
            #endregion

            #region Task 3
            Console.WriteLine(CountWords("This is Code Academy Course   "));
            #endregion
        }

        static int SumOfArray(int[] arr)
        {
            int sum = 0;
            foreach (int x in arr)
            {
                sum += x;
            }
            return sum;
        }

        static bool FindInArray(int[] arr, int x)
        {
            foreach (int item in arr)
            {
                if (item == x)
                {
                    return true;
                }
            }
            return false;
        }

        static int CountWords(string sentence)
        {
            int count = 1;
            for (int i = 0; i < sentence.Length - 1; i++)
            {
                if (sentence[i] == ' ' && sentence[i + 1] != ' ')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
