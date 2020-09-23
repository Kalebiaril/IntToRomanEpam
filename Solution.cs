using System.Collections.Generic;
using System.Text;

namespace IntToRomanLeetCode
{
    public class Solution
    {
        private Dictionary<int, string> _romanNumeralsDictionary
            => new Dictionary<int, string>()
        {
            {1, "I"},
            {4, "IV"},
            {5, "V" } ,
            {9, "IX"},
            {10, "X"},
            {40, "XL" },
            {50, "L"},
            {90, "XC"},
            {100, "C"},
            {400, "CD"},
            {500, "D"},
            {900, "CM" },
            {1000, "M"},
        };
        private int[] _specifiedNumerals = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        public string IntToRoman(int num)
        {
            var builder = new StringBuilder();

            for (var i = 0; i < _specifiedNumerals.Length && num > 0; i++)
            {
                while (num >= _specifiedNumerals[i])
                {
                    num -= _specifiedNumerals[i];

                    builder.Append(_romanNumeralsDictionary[_specifiedNumerals[i]]);
                }
            }
            return builder.ToString();
        }

    }
}