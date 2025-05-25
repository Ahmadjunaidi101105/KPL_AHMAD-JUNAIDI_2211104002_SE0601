using System;
using System.Collections.Generic;

namespace modul13_1202210001
{
    public class PusatDataSingleton
    {
        private static PusatDataSingleton _instance;
        public List<string> DataTersimpan { get; set; }

        // Konstruktor private
        private PusatDataSingleton()
        {
            DataTersimpan = new List<string>();
        }

        // Method singleton
        public static PusatDataSingleton GetDataSingleton()
        {
            if (_instance == null)
            {
                _instance = new PusatDataSingleton();
            }
            return _instance;
        }

        public List<string> GetSemuaData()
        {
            return DataTersimpan;
        }

        public void PrintSemuaData()
        {
            Console.WriteLine("Data saat ini:");
            for (int i = 0; i < DataTersimpan.Count; i++)
            {
                Console.WriteLine($"{i}. {DataTersimpan[i]}");
            }
        }

        public void AddSebuahData(string input)
        {
            DataTersimpan.Add(input);
        }

        public void HapusSebuahData(int index)
        {
            if (index >= 0 && index < DataTersimpan.Count)
            {
                DataTersimpan.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Index tidak valid.");
            }
        }
    }
}
