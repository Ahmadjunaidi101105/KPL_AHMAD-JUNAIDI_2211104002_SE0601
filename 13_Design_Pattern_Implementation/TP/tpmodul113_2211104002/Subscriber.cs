using System;

namespace tpmodul113_NIM
{
    public class Subscriber : IObserver
    {
        private string name;

        public Subscriber(string name)
        {
            this.name = name;
        }

        public void Update(string message)
        {
            Console.WriteLine($"{name} menerima berita: {message}");
        }
    }
}
