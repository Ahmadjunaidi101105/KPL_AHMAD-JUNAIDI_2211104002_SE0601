using System;

namespace AljabarApp
{
    /// <summary>
    /// Kelas utama untuk menampilkan operasi aljabar.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Aljabar calculator = new Aljabar();

            Console.WriteLine("Hasil Penjumlahan: " + calculator.Add(2, 3));
            Console.WriteLine("Hasil Perkalian: " + calculator.Multiply(2, 3));
        }
    }
}
