using Microsoft.VisualStudio.TestTools.UnitTesting;
using modul12_2211104002;

namespace modul12_2211104026.Tests
{
    [TestClass]
    public class Form1Tests
    {
        private Form1 form;

        [TestInitialize]
        public void Setup()
        {
            form = new Form1();
        }

        [TestMethod]
        public void Pangkat_B_Positive_ValidRange_ReturnsCorrectResult()
        {
            int result = form.CariNilaiPangkat(2, 3);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void Pangkat_B_EqualsZero_ReturnsOne()
        {
            int result = form.CariNilaiPangkat(5, 0);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Pangkat_B_Negative_ReturnsMinusOne()
        {
            int result = form.CariNilaiPangkat(3, -2);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void Pangkat_B_GreaterThan10_ReturnsMinusTwo()
        {
            int result = form.CariNilaiPangkat(2, 11);
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void Pangkat_A_GreaterThan100_ReturnsMinusTwo()
        {
            int result = form.CariNilaiPangkat(101, 2);
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void Pangkat_Overflow_ReturnsMinusThree()
        {
            int result = form.CariNilaiPangkat(100, 10); // 100^10 = big number, likely overflow
            Assert.AreEqual(-3, result);
        }
    }
}
