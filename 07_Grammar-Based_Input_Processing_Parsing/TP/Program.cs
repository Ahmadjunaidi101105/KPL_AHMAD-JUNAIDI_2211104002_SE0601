using System;
using System.IO;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        string projectDirectory = Directory.GetCurrentDirectory(); // Ambil direktori kerja
        string filePath = Path.Combine(projectDirectory, "solution", "tp7_1_2211104002.json"); 

        Console.WriteLine($"Mencari file di: {filePath}"); // Debugging untuk melihat path yang digunakan

        if (!File.Exists(filePath))
        {
            Console.WriteLine("❌ File JSON tidak ditemukan.");
            return;
        }

        string jsonData = File.ReadAllText(filePath);
        Console.WriteLine("✅ File JSON ditemukan dan dibaca.");

        DataMahasiswa mahasiswa = JsonConvert.DeserializeObject<DataMahasiswa>(jsonData);
        Console.WriteLine($"Nama: {mahasiswa.Nama}, NIM: {mahasiswa.NIM}, Fakultas: {mahasiswa.Fakultas}");
    }
}

class DataMahasiswa
{
    public string Nama { get; set; }
    public string NIM { get; set; }
    public string Fakultas { get; set; }
}
