using System;

/// <summary>
/// Program utama untuk menjalankan aplikasi clean code.
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        // Membuat instance dari User
        User currentUser = new User("Ahmad Junaidi", new DateTime(2004, 11, 10));

        // Menampilkan informasi
        Console.WriteLine($"Nama Lengkap  : {currentUser.FullName}");
        Console.WriteLine($"Tanggal Lahir : {currentUser.BirthDate.ToString("dd MMMM yyyy")}");
        Console.WriteLine($"Umur Saat Ini : {currentUser.CalculateAge()} tahun");
    }
}
