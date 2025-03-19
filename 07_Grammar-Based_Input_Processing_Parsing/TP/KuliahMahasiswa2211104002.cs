using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class KuliahMahasiswa2211104002
{
    public class Course
    {
        public string code { get; set; } = string.Empty;
        public string name { get; set; } = string.Empty;
    }

    public class CourseList
    {
        public List<Course> courses { get; set; } = new List<Course>();
    }

    public static void ReadJSON()
    {
        string filePath = "solution/tp7_2_2211104002.json"; // Pastikan path sesuai
        if (!File.Exists(filePath))
        {
            Console.WriteLine("❌ File JSON tidak ditemukan.");
            return;
        }

        string json = File.ReadAllText(filePath);
        CourseList? courseList = JsonConvert.DeserializeObject<CourseList>(json);

        if (courseList?.courses != null)
        {
            Console.WriteLine("✅ Daftar mata kuliah yang diambil:");
            int i = 1;
            foreach (var course in courseList.courses)
            {
                Console.WriteLine($"MK {i} {course.code} - {course.name}");
                i++;
            }
        }
        else
        {
            Console.WriteLine("⚠️ Data kosong atau tidak sesuai format.");
        }
    }
}
