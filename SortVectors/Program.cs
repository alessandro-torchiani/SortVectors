using System;

namespace SortVectors
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10] { 1, 2, 3, 23, 56, -34, -98, 87, 3, -10 };
            for (int i = 0;i < 10; i++)
            {
                Console.WriteLine(vet[i]);
            }
            Console.ReadKey();
        }
    }
}
