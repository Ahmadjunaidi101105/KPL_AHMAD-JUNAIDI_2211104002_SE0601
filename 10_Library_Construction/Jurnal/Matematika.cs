using System;

namespace MatematikaLibraries
{
    public class Matematika
    {
        public int FPB(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public int KPK(int a, int b)
        {
            return (a * b) / FPB(a, b);
        }

        public string Turunan(int[] persamaan)
        {
            string hasil = "";
            int pangkat = persamaan.Length - 1;
            for (int i = 0; i < persamaan.Length - 1; i++)
            {
                int koefisien = persamaan[i] * (pangkat - i);
                int derajatBaru = pangkat - i - 1;

                if (koefisien == 0) continue;

                if (hasil.Length > 0 && koefisien > 0)
                    hasil += " + ";

                if (koefisien < 0)
                    hasil += " - " + Math.Abs(koefisien);
                else
                    hasil += koefisien;

                if (derajatBaru > 1)
                    hasil += "x" + derajatBaru;
                else if (derajatBaru == 1)
                    hasil += "x";
            }
            return hasil.Trim();
        }

        public string Integral(int[] persamaan)
        {
            string hasil = "";
            int pangkat = persamaan.Length;

            for (int i = 0; i < persamaan.Length; i++)
            {
                int derajatBaru = pangkat - i;
                double koefisienBaru = (double)persamaan[i] / derajatBaru;

                if (i != 0 && koefisienBaru > 0)
                    hasil += " + ";
                else if (koefisienBaru < 0)
                    hasil += " - ";

                hasil += Math.Abs(koefisienBaru);

                if (derajatBaru > 1)
                    hasil += "x" + derajatBaru;
                else
                    hasil += "x";
            }

            hasil += " + C";
            return hasil;
        }
    }
}
