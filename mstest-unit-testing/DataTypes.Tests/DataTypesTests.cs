using System.Text;

namespace DataTypes.Tests
{
    [TestClass]
    public class DataTypesTests
    {
        private readonly DataTypeService _dataTypeService;

        public DataTypesTests()
        {
            _dataTypeService = new DataTypeService();
        }

        [TestMethod]
        [DataRow("-150", "-150 can be fitted in: *short *int *long")]
        [DataRow("150000", "150000 can be fitted in: *int *long")]
        [DataRow("1500000000", "1500000000 can be fitted in: *int *long")]
        [DataRow("213333333333333333333333333333333333", "213333333333333333333333333333333333 can't be fitted anywhere.")]
        [DataRow("-100000000000000", "-100000000000000 can be fitted in: *long")]
        public void Numbers_Are_Fitted_According_To_Their_Data_Types(string input, string expectedResult)
        {
            string result = _dataTypeService.TryFitString(input);

            Assert.AreEqual(expectedResult, result);
        }
    }
}