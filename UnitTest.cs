using Xunit;

namespace IntToRomanLeetCode
{

    public class RomanToIntegerTests
	{
		[Theory]
		[InlineData(1994, "MCMXCIV")]
		[InlineData(58, "LVIII")]
		[InlineData(1000, "M")]
		[InlineData(0, "")]
		public void TestMethod(int num, string expected)
		{
			//Arrange
			var solution = new Solution();


			//Action
			var actual = solution.IntToRoman(num);

			//Assert
			Assert.Equal(expected, actual);
		}
	}
}
