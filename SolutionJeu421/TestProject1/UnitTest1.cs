using FizzBuzzMethodeRache;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FizzBuzzTest1()
        {
            string result = Program.FizzBuzz(1);

            Assert.AreEqual("1", result);
        }

        [TestMethod]
        public void FizzBuzzTest2()
        {
            string result = Program.FizzBuzz(2);

            Assert.AreEqual("2", result);
        }

        [TestMethod]
        public void FizzBuzzTest3()
        {
            string result = Program.FizzBuzz(3);

            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void FizzBuzzTest6()
        {
            string result = Program.FizzBuzz(6);

            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void FizzBuzzTest5()
        {
            string result = Program.FizzBuzz(5);

            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        public void FizzBuzzTest10()
        {
            string result = Program.FizzBuzz(10);

            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        public void FizzBuzzTest15()
        {
            string result = Program.FizzBuzz(15);

            Assert.AreEqual("FizzBuzz", result);
        }

        [TestMethod]
        public void FizzBuzzTest30()
        {
            string result = Program.FizzBuzz(30);

            Assert.AreEqual("FizzBuzz", result);
        }
    }
}