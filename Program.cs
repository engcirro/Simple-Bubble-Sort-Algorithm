using System;

namespace ConsoleApp_BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Bubble = {7, 3, 1, 4, 6, 2, 3 };

            BubbleSort(Bubble);
            Console.Write("The sorted array is: ");
            foreach (int sorted in Bubble)
            {
                Console.Write(sorted +"  ");
                
            }
            
        }
        public static void BubbleSort(int[] bubble)

        {
            for (int i = 0; i < bubble.Length; i++)
                for (int j = 1; j < bubble.Length; j++)
                    if (bubble[j] < bubble[j - 1])
                    {
                        var temp = bubble[j];
                        bubble[j] = bubble[j - 1];
                        bubble[j - 1] = temp;
                    }

        }


    }
}
