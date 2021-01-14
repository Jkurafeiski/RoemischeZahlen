using NUnit.Framework;
using RoemischeZahlen;

namespace RomanNumberTest
{
    [TestFixture]
    public class RomanNumberTest
    {

        private Roman _sut;


        [SetUp]
        public void Setup()
        {
            _sut = new Roman();
        }


        [TestCase(3)]
        public void Convert_III_3(int number)
        {
            string romanTest = "III";
            const int expected = 3;

            var actual = _sut.RomanMath(romanTest);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(4)]
        public void Convert_IV_4(int number)
        {
            string romanTest = "IV";
            const int expected = 4;

            var actual = _sut.RomanMath(romanTest);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(4)]
        public void Convert_IX_9(int number)
        {
            string romanTest = "IX";
            const int expected = 9;

            var actual = _sut.RomanMath(romanTest);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(11)]
        public void Convert_XI_11(int number)
        {
            string romanTest = "XI";
            const int expected = 11;

            var actual = _sut.RomanMath(romanTest);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(40)]
        public void Convert_XL_40(int number)
        {
            string romanTest = "XL";
            const int expected = 40;

            var actual = _sut.RomanMath(romanTest);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(50)]
        public void Convert_L_50(int number)
        {
            string romanTest = "L";
            const int expected = 50;

            var actual = _sut.RomanMath(romanTest);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(100)]
        public void Convert_C_100(int number)
        {
            string romanTest = "C";
            const int expected = 100;

            var actual = _sut.RomanMath(romanTest);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1000)]
        public void Convert_C_1000(int number)
        {
            string romanTest = "M";
            const int expected = 1000;

            var actual = _sut.RomanMath(romanTest);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(404)]
        public void Convert_IIV(int number)
        {
            string romanTest = "IIV";

            TestDelegate action = () => _sut.RomanMath(romanTest);

            Assert.Throws(typeof(NoRomanNumberException), action);
        }
    }
}