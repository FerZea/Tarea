namespace Substring.Tests
{
    [TestClass]
    public class SubstringTests
    {
        private SubstringService _substringService;

        public SubstringTests()
        {
            _substringService = new SubstringService();
        }

        [TestMethod]
        [DataRow("Hi 5", "myString is: Hi", "myInt is: 5")]
        public void StringOutput_And_NumericOutput_Are_Correct(string input, string stringOutput, string numericOutput)
        {
            Tuple<string, string> result = _substringService.SplitInput(input);

            Assert.AreEqual($"{stringOutput}; {numericOutput}", $"{result.Item1}; {result.Item2}");
        }
    }
}