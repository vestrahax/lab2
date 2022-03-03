using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lab2.Tests
{
    [TestClass()]
    public class RomanNumberTests
    {
        [TestMethod()]
        public void Add()
        {
            var RomanNumberFirst = new RomanNumber(9);
            var RomanNumberSecond = new RomanNumber(2);
            var RomanNumberThird = new RomanNumber(16);
            var ExpectedFirst = new RomanNumber(11);
            var ExpectedSecond = new RomanNumber(25);
            RomanNumber Actual = RomanNumberFirst + RomanNumberSecond;
            RomanNumber Actual2 = RomanNumberFirst + RomanNumberThird;
            Assert.AreEqual(ExpectedFirst.ToString(), Actual.ToString());
            Assert.AreEqual(ExpectedSecond.ToString(), Actual2.ToString());

        }
        [TestMethod()]
        public void Sub()
        {
            var RomanNumberFirst = new RomanNumber(30);
            var RomanNumberSecond = new RomanNumber(21);
            var RomanNumberThird = new RomanNumber(160);
            var RomanNumberFourth = new RomanNumber(10);
            var Expected = new RomanNumber(9);
            var Expected2 = new RomanNumber(20);

            RomanNumber Actual = RomanNumberFirst - RomanNumberSecond;
            RomanNumber Actual2 = RomanNumberFirst - RomanNumberFourth;

            Assert.AreEqual(Expected.ToString(), Actual.ToString());
            Assert.AreNotEqual(Actual.ToString(), Actual2.ToString());
            Assert.AreEqual(Expected2.ToString(), Actual2.ToString());
            Assert.ThrowsException<RomanNumberException>(() => (RomanNumberFirst - RomanNumberThird));

        }
        [TestMethod()]
        public void Div()
        {
            var RomanNumberFirst = new RomanNumber(150);
            var RomanNumberSecond = new RomanNumber(2);
            var RomanNumberThird = new RomanNumber(160);
            var Expected = new RomanNumber(75);


            RomanNumber Actual = RomanNumberFirst / RomanNumberSecond;

            Assert.AreEqual(Expected.ToString(), Actual.ToString());
            Assert.ThrowsException<RomanNumberException>(() => (RomanNumberFirst / RomanNumberThird));
            Assert.ThrowsException<RomanNumberException>(() => (RomanNumberSecond / RomanNumberThird));
        }
        [TestMethod()]
        public void Mul()
        {
            var RomanNumberFirst = new RomanNumber(9);
            var RomanNumberSecond = new RomanNumber(6);
            var RomanNumberThird = new RomanNumber(12);
            var Expected1 = new RomanNumber(54);
            var Expected2 = new RomanNumber(108);
            RomanNumber ActualFirst = RomanNumberFirst * RomanNumberSecond;
            RomanNumber ActualSecond = RomanNumberFirst * RomanNumberThird;
            Assert.AreEqual(Expected1.ToString(), ActualFirst.ToString());
            Assert.AreEqual(Expected2.ToString(), ActualSecond.ToString());
            Assert.IsNotNull(RomanNumberFirst);
            Assert.IsNotNull(RomanNumberSecond);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            RomanNumber RomanNumberFirst = new RomanNumber(1001);
            string Expected = "MI";
            string Actual = RomanNumberFirst.ToString();
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod()]
        public void CloneTest()
        {
            RomanNumber RomanNumberFirst = new RomanNumber(6);
            RomanNumber Expected = new RomanNumber(6);
            RomanNumber Clone = (RomanNumber)RomanNumberFirst.Clone();
            Assert.AreEqual(Expected.ToString(), Clone.ToString());
            Assert.AreNotSame(Expected, Clone);
        }


        [TestMethod()]
        public void CompareToTest()
        {
            RomanNumber RomanNumberFirst = new RomanNumber(10);
            RomanNumber RomanNumberSecond = new RomanNumber(10);
            const int Expected = 0;
            int Actual = RomanNumberFirst.CompareTo(RomanNumberSecond);
            Assert.AreEqual(Expected, Actual);
        }
    }
}