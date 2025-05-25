using System;

namespace modul13_1202210001
{
    class Program
    {
        static void Main(string[] args)
        {
            // A. Buat dua variabel singleton
            PusatDataSingleton data1 = PusatDataSingleton.GetDataSingleton();
            PusatDataSingleton data2 = PusatDataSingleton.GetDataSingleton();

            // B. Tambahkan data nama anggota & asisten praktikum ke data1
            data1.AddSebuahData("Ahmad Junaidi");
            data1.AddSebuahData("Rafli Dhafin Kamil");
            data1.AddSebuahData("Alfian Mutakim");
            data1.AddSebuahData("Muhammad Lutfi Hamdani");
            data1.AddSebuahData("Asisten: Budi");

            // C. Print semua data dari data2
            data2.PrintSemuaData();

            // D. Hapus asisten dari data2
            data2.HapusSebuahData(4); // menghapus "Asisten: Budi"

            // E. Print ulang dari data1 untuk memastikan data sudah dihapus
            data1.PrintSemuaData();

            // F. Print jumlah elemen dari data1 dan data2
            Console.WriteLine("Jumlah data pada data1: " + data1.GetSemuaData().Count);
            Console.WriteLine("Jumlah data pada data2: " + data2.GetSemuaData().Count);
        }
    }
}
