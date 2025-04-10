using System;

class Program
{
    static void Main()
    {
        var config = BankTransferConfig.LoadConfig("bank_transfer_config.json");

        // Tampilkan pesan berdasarkan bahasa
        Console.WriteLine(config.Lang == "id" ?
            "Masukkan jumlah uang yang akan di-transfer:" :
            "Please insert the amount of money to transfer:");

        int amount = int.Parse(Console.ReadLine());

        // Hitung biaya transfer
        int fee = amount <= config.Transfer.Threshold ?
            config.Transfer.LowFee : config.Transfer.HighFee;
        int total = amount + fee;

        Console.WriteLine(config.Lang == "id" ?
            $"Biaya transfer = {fee}\nTotal biaya = {total}" :
            $"Transfer fee = {fee}\nTotal amount = {total}");

        // Tampilkan metode transfer
        Console.WriteLine(config.Lang == "id" ?
            "Pilih metode transfer:" : "Select transfer method:");
        for (int i = 0; i < config.Methods.Count; i++)
            Console.WriteLine($"{i + 1}. {config.Methods[i]}");

        // Konfirmasi transaksi
        string confirmationMsg = config.Lang == "id" ?
            $"Ketik \"{config.Confirmation.Id}\" untuk konfirmasi:" :
            $"Please type \"{config.Confirmation.En}\" to confirm:";
        Console.WriteLine(confirmationMsg);

        string input = Console.ReadLine();
        if (input == (config.Lang == "id" ? config.Confirmation.Id : config.Confirmation.En))
            Console.WriteLine(config.Lang == "id" ? "Transfer berhasil!" : "Transfer completed!");
        else
            Console.WriteLine(config.Lang == "id" ? "Transfer dibatalkan." : "Transfer cancelled.");
    }
}