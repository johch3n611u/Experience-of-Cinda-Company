using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class IntegrationTest1
    {
        // https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-mstest

        [TestMethod]
        public void TestMethod1()
        {
            // Arrange - 初始化物件設置測試值
            var primeService = new PrimeService();
            int Test = 1;

            // Act - 表示要調用的測試方法
            bool result = primeService.IsPrime(Test);

            // Assert 斷言 (判斷真假) - 表示確認期望值和實際值應該相同
            Assert.IsFalse(result, "1 should not be prime");
        }

    }

    [TestClass]
    public class IntegrationTest2
    {
        // https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-mstest

        [TestMethod]
        public void TestMethod1()
        {
            // Arrange - 初始化物件設置測試值
            var primeService = new PrimeService();
            int Test = 1;

            // Act - 表示要調用的測試方法
            bool result = primeService.IsPrime(Test);

            // Assert 斷言 (判斷真假) - 表示確認期望值和實際值應該相同
            Assert.IsFalse(result, "1 should not be prime");
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange - 初始化物件設置測試值
            var primeService = new PrimeService();
            int Test = 1;

            // Act - 表示要調用的測試方法
            bool result = primeService.IsPrime(Test);
            bool result2 = primeService.IsPrime(Test + 1);

            // Assert 斷言 (判斷真假) - 表示確認期望值和實際值應該相同
            Assert.IsFalse(result, "1 should not be prime");
            Assert.IsFalse(result2, "1 should not be prime");
        }

    }

    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate == 1)
            {
                return false;
            }
            throw new NotImplementedException("Please create a test first.");
        }
    }
}
