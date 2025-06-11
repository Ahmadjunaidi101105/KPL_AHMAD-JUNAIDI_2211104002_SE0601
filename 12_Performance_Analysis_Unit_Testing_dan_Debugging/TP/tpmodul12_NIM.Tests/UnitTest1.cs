using Microsoft.VisualStudio.TestTools.UnitTesting;
using tpmodul12_2211104002; // Ganti sesuai nama namespace project kamu

namespace tpmodul12_2211104002.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Negatif()
        {
            var form = new Form1();
            string hasil = form.CariTandaBilangan(-5);
            Assert.AreEqual("Negatif", hasil);
        }

        [TestMethod]
        public void Test_Nol()
        {
            var form = new Form1();
            string hasil = form.CariTandaBilangan(0);
            Assert.AreEqual("Nol", hasil);
        }

        [TestMethod]
        public void Test_Positif()
        {
            var form = new Form1();
            string hasil = form.CariTandaBilangan(12);
            Assert.AreEqual("Positif", hasil);
        }
    }
}
