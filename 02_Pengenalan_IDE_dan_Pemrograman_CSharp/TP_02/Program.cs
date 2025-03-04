using System;

class Program
{
    static void Main()
    {
        Console.Write("Masukkan satu huruf: ");
        char huruf = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine(); 

        if ("AIUEO".Contains(huruf))
        {
            Console.WriteLine($"Huruf {huruf} merupakan huruf vokal");
        }
        else
        {
            Console.WriteLine($"Huruf {huruf} merupakan huruf konsonan");
        }

        int[] bilanganGenap = { 2, 4, 6, 8, 10 };
        for (int i = 0; i < bilanganGenap.Length; i++)
        {
            Console.WriteLine($"Angka genap {i + 1} : {bilanganGenap[i]}");
        }
    }
}