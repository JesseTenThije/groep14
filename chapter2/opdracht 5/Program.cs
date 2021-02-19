using System;

namespace opdracht_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int minGetal = 10;
            int maxGetal = 99;

            int[] array1 = new int[10];

            Random randNum = new Random();
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = randNum.Next(minGetal, maxGetal);
            }
            Console.WriteLine("[{0}]", string.Join(", ", array1));

            int temp;
            for (int j = 0; j <= array1.Length - 2; j++)
            {
                for (int i = 0; i <= array1.Length - 2; i++)
                {
                    if (array1[i] > array1[i + 1])
                    {
                        temp = array1[i + 1];
                        array1[i + 1] = array1[i];
                        array1[i] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted:");
            foreach (int p in array1)
                Console.Write(p + " ");
            Console.Read();
        }
    }
}
