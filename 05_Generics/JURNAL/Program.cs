using System;
using System.Collections.Generic;

<<<<<<< HEAD
public class Penjumlahan
{
    // Method generic untuk menjumlahkan tiga angka
    public static T JumlahTigaAngka<T>(T angka1, T angka2, T angka3) where T : struct
    {
        dynamic a = angka1;
        dynamic b = angka2;
        dynamic c = angka3;
        return a + b + c;
=======
class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    // Konstruktor
    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    // Method untuk menambahkan data baru
    public void AddNewData(T item)
    {
        storedData.Add(item);
        inputDates.Add(DateTime.UtcNow);
    }

    // Method untuk mencetak semua data
    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine($"Data {i + 1} berisi: {storedData[i]}, yang disimpan pada waktu UTC: {inputDates[i]}");
        }
>>>>>>> implementasi-generic-class
    }
}

class Program
{
    static void Main()
    {
<<<<<<< HEAD
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
=======
        Console.WriteLine("NIM saya yaitu 2211104002");

        // Membuat instance SimpleDataBase untuk tipe data float
        SimpleDataBase<float> database = new SimpleDataBase<float>();

        // Menambahkan tiga data dari dua digit NIM (22, 11, 10)
        database.AddNewData(22f);
        database.AddNewData(11f);
        database.AddNewData(10f);

        // Menampilkan semua data yang tersimpan
        database.PrintAllData();
>>>>>>> implementasi-generic-class
    }
}
