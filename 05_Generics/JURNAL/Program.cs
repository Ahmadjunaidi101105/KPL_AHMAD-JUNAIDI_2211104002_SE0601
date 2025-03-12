using System;
using System.Collections.Generic;

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
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("NIM saya yaitu 2211104002");

        // Membuat instance SimpleDataBase untuk tipe data float
        SimpleDataBase<float> database = new SimpleDataBase<float>();

        // Menambahkan tiga data dari dua digit NIM (22, 11, 10)
        database.AddNewData(22f);
        database.AddNewData(11f);
        database.AddNewData(10f);

        // Menampilkan semua data yang tersimpan
        database.PrintAllData();
    }
}
