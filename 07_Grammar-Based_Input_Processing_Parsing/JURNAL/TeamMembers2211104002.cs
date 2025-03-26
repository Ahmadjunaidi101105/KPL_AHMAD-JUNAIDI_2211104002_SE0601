using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

class TeamMember
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public string nim { get; set; }
}

class TeamMembers2211104002
{
    public List<TeamMember> members { get; set; }

    public static void ReadJSON()
    {
        try
        {
            string filePath = @"C:\SEMESTER 6\PRAKTIKUM KONSTRUKSI PERANGKAT LUNAK\modul7_kelompok7\modul7_kelompok7\bin\Debug\jurnal7_2_2211104002.json";

            Console.WriteLine($"Mencari file JSON di: {filePath}");

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File JSON tidak ditemukan.");
                return;
            }

            string jsonData = File.ReadAllText(filePath);
            TeamMembers2211104002 team = JsonConvert.DeserializeObject<TeamMembers2211104002>(jsonData);

            Console.WriteLine("Team member list:");
            foreach (var member in team.members)
            {
                Console.WriteLine($"{member.nim} {member.firstName} {member.lastName} ({member.age} {member.gender})");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Terjadi kesalahan: {ex.Message}");
        }
    }
}
