using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {

        private const string Expected = "[2 3 5 7 ]";

        [TestMethod]
        public void GetTheCorrectPrimeNumbersAndPrintThem()
        {
            int primeRequest = 4;
            PrimeNumbersTest.PrimeLogic primeLogic = new PrimeNumbersTest.PrimeLogic();
            PrimeNumbersTest.ListLogic listLogic = new PrimeNumbersTest.ListLogic();
            listLogic.primeMemory = new List<int>();
            string result;

            result = PrimeNumbersTest.Program.primes(primeRequest, listLogic, primeLogic);

            Assert.AreEqual(result, Expected);
            Assert.AreEqual(listLogic.primeMemory.Count, 4);

        }

    }
}
