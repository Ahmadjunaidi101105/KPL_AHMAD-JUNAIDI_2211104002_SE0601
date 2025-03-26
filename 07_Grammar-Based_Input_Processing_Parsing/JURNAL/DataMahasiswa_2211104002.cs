//using System;
//using System.IO;
//using Newtonsoft.Json;

//class Address
//{
//    public string streetAddress { get; set; }
//    public string city { get; set; }
//    public string state { get; set; }
//}

//class Course
//{
//    public string code { get; set; }
//    public string name { get; set; }
//}

//class DataMahasiswa_2211104002
//{
//    public string firstName { get; set; }
//    public string lastName { get; set; }
//    public string gender { get; set; }
//    public int age { get; set; }
//    public Address address { get; set; }
//    public Course[] courses { get; set; }

//    public static void ReadJSON()
//    {
//        try
//        {
//            string filePath = @"C:\SEMESTER 6\PRAKTIKUM KONSTRUKSI PERANGKAT LUNAK\modul7_kelompok7\modul7_kelompok7\bin\Debug\jurnal7_1_2211104002.json";

//            Console.WriteLine($"Mencari file JSON di: {filePath}");

//            if (!File.Exists(filePath))
//            {
//                Console.WriteLine("File JSON tidak ditemukan.");
//                return;
//            }

//            string jsonData = File.ReadAllText(filePath);
//            DataMahasiswa_2211104002 mahasiswa = JsonConvert.DeserializeObject<DataMahasiswa_2211104002>(jsonData);

//            Console.WriteLine("===== Data Mahasiswa =====");
//            Console.WriteLine($"Nama       : {mahasiswa.firstName} {mahasiswa.lastName}");
//            Console.WriteLine($"Gender     : {mahasiswa.gender}");
//            Console.WriteLine($"Age        : {mahasiswa.age}");
//            Console.WriteLine($"Alamat     : {mahasiswa.address.streetAddress}, {mahasiswa.address.city}, {mahasiswa.address.state}");
//            Console.WriteLine("===== Mata Kuliah =====");
//            foreach (var course in mahasiswa.courses)
//            {
//                Console.WriteLine($"Kode: {course.code}, Nama: {course.name}");
//            }
//            Console.WriteLine("==========================");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Terjadi kesalahan: {ex.Message}");
//        }
//    }
//}
