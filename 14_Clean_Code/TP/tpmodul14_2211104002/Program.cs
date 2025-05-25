using System;

namespace AljabarApp
{
    /// <summary>
    /// Program utama untuk menjalankan operasi aljabar.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Aljabar calculator = new Aljabar();

            Console.WriteLine("Hasil Penjumlahan: " + calculator.Add(5, 3));
            Console.WriteLine("Hasil Perkalian: " + calculator.Multiply(5, 3));
        }
    }
}
