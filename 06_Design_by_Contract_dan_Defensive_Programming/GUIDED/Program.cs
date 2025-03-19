//MODUL VI
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;

class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public string Title { get { return title; } }
    public int PlayCount { get { return playCount; } }

    public SayaTubeVideo(string title)
    {
        Contract.Requires<ArgumentException>(!string.IsNullOrEmpty(title) && title.Length <= 200, "Judul tidak boleh kosong dan maksimal 200 karakter.");
        
        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        Contract.Requires<ArgumentException>(count >= 0 && count <= 25000000, "Play count harus antara 0 dan 25.000.000.");
        
        checked
        {
            if (playCount + count > int.MaxValue)
                throw new OverflowException("Play count melebihi batas maksimum integer.");
            this.playCount += count;
        }
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
        Contract.Requires<ArgumentException>(!string.IsNullOrEmpty(username) && username.Length <= 100, "Username tidak boleh kosong dan maksimal 100 karakter.");
        
        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.Username = username;
        this.uploadedVideos = new List<SayaTubeVideo>();
    }

    public void AddVideo(SayaTubeVideo video)
    {
        Contract.Requires<ArgumentNullException>(video != null, "Video tidak boleh null.");
        this.uploadedVideos.Add(video);
    }

    public int GetTotalVideoPlayCount()
    {
        int total = 0;
        foreach (var video in uploadedVideos)
        {
            total += video.PlayCount;
        }
        return total;
    }

    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine($"User: {Username}");
        for (int i = 0; i < Math.Min(uploadedVideos.Count, 8); i++)
        {
            Console.WriteLine($"Video {i + 1}: {uploadedVideos[i].Title}");
        }
    }
}

class Program
{
    static void Main()
    {
        try
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
                video.IncreasePlayCount(100000);
                user.AddVideo(video);
            }

            user.PrintAllVideoPlaycount();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Terjadi kesalahan: " + ex.Message);
        }

        Console.WriteLine("\nTekan Enter untuk keluar...");
        Console.ReadLine();
    }
}
