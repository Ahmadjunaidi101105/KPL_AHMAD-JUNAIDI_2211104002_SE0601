using System;

namespace CommandDemo
{
    public interface ICommand
    {
        void Execute();
    }

    class SimpleCommand : ICommand
    {
        private string _payload;

        public SimpleCommand(string payload)
        {
            _payload = payload;
        }

        public void Execute()
        {
            Console.WriteLine($"SimpleCommand: Menampilkan '{_payload}'");
        }
    }

    class ComplexCommand : ICommand
    {
        private Receiver _receiver;
        private string _a, _b;

        public ComplexCommand(Receiver receiver, string a, string b)
        {
            _receiver = receiver;
            _a = a;
            _b = b;
        }

        public void Execute()
        {
            Console.WriteLine("ComplexCommand: Menyerahkan tugas ke receiver.");
            _receiver.DoSomething(_a);
            _receiver.DoSomethingElse(_b);
        }
    }

    class Receiver
    {
        public void DoSomething(string a)
        {
            Console.WriteLine($"Receiver: Melakukan sesuatu dengan ({a}).");
        }

        public void DoSomethingElse(string b)
        {
            Console.WriteLine($"Receiver: Melakukan hal lain dengan ({b}).");
        }
    }

    class Invoker
    {
        private ICommand _onStart;
        private ICommand _onFinish;

        public void SetOnStart(ICommand command)
        {
            _onStart = command;
        }

        public void SetOnFinish(ICommand command)
        {
            _onFinish = command;
        }

        public void DoSomethingImportant()
        {
            Console.WriteLine("Invoker: Apakah ada yang harus dilakukan sebelum saya mulai?");
            _onStart?.Execute();

            Console.WriteLine("Invoker: Sedang melakukan sesuatu yang penting...");

            Console.WriteLine("Invoker: Apakah ada yang harus dilakukan setelah saya selesai?");
            _onFinish?.Execute();
        }
    }
}
