using System;
using SingletonDemo;
using AdapterDemo;
using CommandDemo;

namespace modul13Guided_2211104002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== DEMO SINGLETON ===");
            Singleton singleton1 = Singleton.GetInstance();
            Singleton singleton2 = Singleton.GetInstance();
            if (singleton1 == singleton2)
            {
                Console.WriteLine("Singleton berhasil: kedua objek sama.");
            }
            else
            {
                Console.WriteLine("Singleton gagal: objek berbeda.");
            }
            singleton1.DoSomething();

            Console.WriteLine("\n=== DEMO ADAPTER ===");
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);
            Console.WriteLine("Tanpa adapter, interface adaptee tidak bisa digunakan langsung.");
            Console.WriteLine("Dengan adapter:");
            Console.WriteLine(target.GetRequest());

            Console.WriteLine("\n=== DEMO COMMAND ===");
            Invoker invoker = new Invoker();
            invoker.SetOnStart(new SimpleCommand("Say Hi!"));
            Receiver receiver = new Receiver();
            invoker.SetOnFinish(new ComplexCommand(receiver, "Kirim Email", "Simpan Laporan"));
            invoker.DoSomethingImportant();

            Console.WriteLine("\n=== SEMUA DESIGN PATTERN TELAH DITAMPILKAN ===");
        }
    }
}
