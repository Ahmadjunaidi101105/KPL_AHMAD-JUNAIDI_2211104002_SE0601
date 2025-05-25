using System;

/// <summary>
/// Class User menyimpan informasi pengguna dan menghitung umur dari tanggal lahir.
/// </summary>
public class User
{
    public string FullName { get; set; }
    public DateTime BirthDate { get; set; }

    /// <summary>
    /// Konstruktor untuk menginisialisasi objek User.
    /// </summary>
    public User(string fullName, DateTime birthDate)
    {
        FullName = fullName;
        BirthDate = birthDate;
    }

    /// <summary>
    /// Menghitung umur pengguna berdasarkan tanggal lahir.
    /// </summary>
    public int CalculateAge()
    {
        DateTime currentDate = DateTime.Today;
        int age = currentDate.Year - BirthDate.Year;

        if (BirthDate > currentDate.AddYears(-age))
        {
            age--;
        }

        return age;
    }
}
