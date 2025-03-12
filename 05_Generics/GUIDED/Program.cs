using System;
using System.Collections.Generic;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 0, 1, 2, 3, 4 };
            List<int> list = new List<int>();

            for (int x = 5; x < 10; x++)
            {
                list.Add(x);
            }

            ProcessItems(arr);
            ProcessItems(list);
        }

        static void ProcessItems<T>(IList<T> coll)
        {
            // Menampilkan apakah koleksi bersifat read-only
            Console.WriteLine($"IsReadOnly: {coll.IsReadOnly}");

            // Statement berikut akan menyebabkan runtime exception jika digunakan pada array
            // coll.RemoveAt(4);

            // Menampilkan item dalam koleksi
            foreach (T item in coll)
            {
                System.Console.Write($"{item} ");
            }

            System.Console.WriteLine();
        }
    }
}
