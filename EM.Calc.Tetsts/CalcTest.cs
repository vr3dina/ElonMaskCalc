using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EM.Calc.Tetsts
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void TestSum()
        {
            //arrange
            var calc = new Core.Calc();
            var sum = 10;

            //act
            var result = calc.Sum(new[] { 5, 3, 2 });

            //assert
            Assert.AreEqual(sum, result);
        }

        [TestMethod]
        public void TestSub()
        {
            var calc = new Core.Calc();
            var sub = 10;

            var result = calc.Sub(new[] { 100, 80, 10 });

            Assert.AreEqual(sub, result);
        }

        [TestMethod]
        public void TestPow()
        {
            var calc = new Core.Calc();
            var pow = 4 * 4 * 4;

            var result = calc.Pow(new[] {2, 2, 3});

            Assert.AreEqual(pow, result);
        }

        [TestMethod]
        public void TestMult()
        {
            var calc = new Core.Calc();
            var mul = 30;

            var result = calc.Mult(new[] { 2, 3, 5 });

            Assert.AreEqual(mul, result);
        }


    }
}