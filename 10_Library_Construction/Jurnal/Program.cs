using System;
using MatematikaLibraries;

namespace modul10_NIM
{
    class Program
    {
        static void Main(string[] args)
        {
            Matematika mtk = new Matematika();

            Console.WriteLine("FPB dari 60 dan 45: " + mtk.FPB(60, 45));
            Console.WriteLine("KPK dari 12 dan 8: " + mtk.KPK(12, 8));
            Console.WriteLine("Turunan dari x^3 + 4x^2 -12x + 9: " + mtk.Turunan(new int[] { 1, 4, -12, 9 }));
            Console.WriteLine("Integral dari 4x^3 + 6x^2 -12x + 9: " + mtk.Integral(new int[] { 4, 6, -12, 9 }));

            Console.ReadKey();
        }
    }
}
