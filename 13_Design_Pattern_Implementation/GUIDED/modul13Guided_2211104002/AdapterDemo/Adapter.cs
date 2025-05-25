using System;

namespace AdapterDemo
{
    public interface ITarget
    {
        string GetRequest();
    }

    class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "Permintaan spesifik.";
        }
    }

    class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            this._adaptee = adaptee;
        }

        public string GetRequest()
        {
            return $"Ini adalah '{_adaptee.GetSpecificRequest()}'";
        }
    }
}
