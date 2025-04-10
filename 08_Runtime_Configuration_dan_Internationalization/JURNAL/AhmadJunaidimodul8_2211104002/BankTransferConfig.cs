using System.Collections.Generic;
using System.IO; 
using System.Text.Json; 

public class BankTransferConfig
{
    public string Lang { get; set; } = "en";
    public TransferConfig Transfer { get; set; } = new TransferConfig();
    public List<string> Methods { get; set; } = new List<string> { "RTO", "SKN", "RTGS", "BI FAST" };
    public ConfirmationConfig Confirmation { get; set; } = new ConfirmationConfig();

    public class TransferConfig
    {
        public int Threshold { get; set; } = 25000000;
        public int LowFee { get; set; } = 6500;
        public int HighFee { get; set; } = 15000;
    }

    public class ConfirmationConfig
    {
        public string En { get; set; } = "yes";
        public string Id { get; set; } = "ya";
    }

    public static BankTransferConfig LoadConfig(string filePath)
    {
        if (!File.Exists(filePath))
            return new BankTransferConfig();

        string json = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<BankTransferConfig>(json);
    }
}