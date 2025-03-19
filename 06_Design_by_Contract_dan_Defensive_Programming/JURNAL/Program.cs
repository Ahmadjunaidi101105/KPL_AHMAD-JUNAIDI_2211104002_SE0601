using System;
using System.Collections.Generic;

class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    // Properti hanya untuk membaca nilai title dan playCount dari luar kelas
    public string Title { get { return title; } }
    public int PlayCount { get { return playCount; } }

    public SayaTubeVideo(string title)
    {
        if (string.IsNullOrEmpty(title) || title.Length > 200)
            throw new ArgumentException("Judul tidak boleh kosong dan maksimal 200 karakter.");

        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        if (count < 0 || count > 25000000)
            throw new ArgumentException("Play count harus antara 0 dan 25.000.000.");
        this.playCount += count;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"ID: {id}, Title: {title}, Play Count: {playCount}");
    }
}

class SayaTubeUser
{
    private int id;
    private string Username;
    private List<SayaTubeVideo> uploadedVideos;

    public SayaTubeUser(string username)
    {
        if (string.IsNullOrEmpty(username) || username.Length > 100)
            throw new ArgumentException("Username tidak boleh kosong dan maksimal 100 karakter.");

        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.Username = username;
        this.uploadedVideos = new List<SayaTubeVideo>();
    }

    public void AddVideo(SayaTubeVideo video)
    {
        if (video == null)
            throw new ArgumentNullException("Video tidak boleh null.");
        this.uploadedVideos.Add(video);
    }

    public int GetTotalVideoPlayCount()
    {
        int total = 0;
        foreach (var video in uploadedVideos)
        {
            total += video.PlayCount; // Menggunakan getter PlayCount
        }
        return total;
    }

    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine($"User: {Username}");
        for (int i = 0; i < Math.Min(uploadedVideos.Count, 8); i++)
        {
            Console.WriteLine($"Video {i + 1}: {uploadedVideos[i].Title}"); // Menggunakan getter Title
        }
    }
}

class Program
{
    static void Main()
    {
        SayaTubeUser user = new SayaTubeUser("Junaidi");

        List<string> filmList = new List<string>
        {
            "Review Film Inception oleh Junaidi",
            "Review Film Interstellar oleh Junaidi",
            "Review Film The Dark Knight oleh Junaidi",
            "Review Film Parasite oleh Junaidi",
            "Review Film Avenger Endgame oleh Junaidi",
            "Review Film Tenet oleh Junaidi",
            "Review Film Spider-Man No Way Home oleh Junaidi",
            "Review Film The Batman oleh Junaidi",
            "Review Film Joker oleh Junaidi",
            "Review Film Dune oleh Junaidi"
        };

        foreach (var film in filmList)
        {
            SayaTubeVideo video = new SayaTubeVideo(film);
            user.AddVideo(video);
        }

        user.PrintAllVideoPlaycount();
    }
}
