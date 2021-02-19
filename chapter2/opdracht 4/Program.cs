using System;
using System.ComponentModel;

namespace opdracht_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int minGetal = 10;
            int maxGetal = 99;

            int[] array1 = new int[10];
            int[] array2 = new int[10];


            Random randNum = new Random();
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = randNum.Next(minGetal, maxGetal);
                array2[i] = randNum.Next(minGetal, maxGetal);
            }
            Console.WriteLine("[{0}]", string.Join(", ", array1));
            Console.WriteLine("[{0}]", string.Join(", ", array2));

            int[] array3 = new int[10];

            for (int i = 0, j = 0; i < array1.Length; i++, j++)
            {
                array3[i] = array1[i] + array2[j];
            }

            for (int i = 0; i < array3.Length; i++)
            {
                Console.Write( array3[i] + ", ");
            }
        }
    }
}
