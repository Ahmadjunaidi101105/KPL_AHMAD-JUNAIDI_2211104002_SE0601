using System;

public class Penjumlahan
{
    // Method generic untuk menjumlahkan tiga angka
    public static T JumlahTigaAngka<T>(T angka1, T angka2, T angka3) where T : struct
    {
        dynamic a = angka1;
        dynamic b = angka2;
        dynamic c = angka3;
        return a + b + c;
    }
}

class Program
{
    static void Main()
    {
        // NIM 2211104002 -> Berakhiran 2, maka tipe data adalah float
        string nim = "2211104002";
        Console.WriteLine($"NIM saya yaitu {nim}");

        // Mengambil 2-digit angka dari NIM
        float angka1 = 22.0f;
        float angka2 = 11.0f;
        float angka3 = 10.0f;

        // Memanggil method generic dengan tipe data float
        float hasil = Penjumlahan.JumlahTigaAngka(angka1, angka2, angka3);

        // Menampilkan hasil sesuai format
        Console.WriteLine($"Hasil penjumlahan: {hasil}");
    }
}
