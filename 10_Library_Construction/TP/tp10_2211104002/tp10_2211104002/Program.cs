using System;
using AljabarLibraries;

namespace TPConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var akar = Aljabar.AkarPersamaanKuadrat(new double[] { 1, -3, -10 });
            Console.WriteLine($"Akar: {akar[0]}, {akar[1]}");

            var hasilKuadrat = Aljabar.HasilKuadrat(new double[] { 2, -3 });
            Console.WriteLine($"Hasil Kuadrat: {hasilKuadrat[0]}x^2 + {hasilKuadrat[1]}x + {hasilKuadrat[2]}");
        }
    }
}
