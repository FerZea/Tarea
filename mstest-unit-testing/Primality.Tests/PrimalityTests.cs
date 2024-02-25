namespace Primality.Tests
{
    [TestClass]
    public class PrimalityTests
    {
        private readonly PrimalityService _primalityService;

        public PrimalityTests()
        {
            _primalityService = new PrimalityService();
        }

        [TestMethod]
        [DataRow(13, true)]
        public void IsPrime_Returns_True(int number, bool expectedResult)
        {
            bool result = _primalityService.IsPrime(number);

            Assert.AreEqual(expectedResult, result);
        }
    }
}