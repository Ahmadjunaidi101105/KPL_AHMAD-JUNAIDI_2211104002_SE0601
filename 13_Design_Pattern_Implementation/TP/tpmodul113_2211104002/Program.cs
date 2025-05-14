using System;

namespace tpmodul113_NIM
{
    class Program
    {
        static void Main(string[] args)
        {
            var agency = new NewsAgency();

            var sub1 = new Subscriber("Ahmad");
            var sub2 = new Subscriber("Junaidi");

            agency.Attach(sub1);
            agency.Attach(sub2);

            agency.SetNews("Cuaca hari ini cerah.");
            agency.SetNews("Harga BBM naik.");
        }
    }
}
