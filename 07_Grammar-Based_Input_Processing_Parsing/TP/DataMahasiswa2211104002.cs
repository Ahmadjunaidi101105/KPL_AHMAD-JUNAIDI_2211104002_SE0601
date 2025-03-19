using System;
using System.IO;
using Newtonsoft.Json;

namespace TP
{
    class DataMahasiswa2211104002
    {
        public string Nama { get; set; }
        public string NIM { get; set; }
        public string Fakultas { get; set; }

        public static void ReadJSON()
        {
            string filePath = @"TP/tp7_1_2211104002.json"; // Path ke file JSON
            if (File.Exists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);
                DataMahasiswa2211104002 mahasiswa = JsonConvert.DeserializeObject<DataMahasiswa2211104002>(jsonData);

                Console.WriteLine($"Nama {mahasiswa.Nama} dengan NIM {mahasiswa.NIM} dari Fakultas {mahasiswa.Fakultas}");
            }
            else
            {
                Console.WriteLine("File JSON tidak ditemukan.");
            }
        }
    }
}
