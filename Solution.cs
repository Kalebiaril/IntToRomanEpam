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


        public string IntToRoman2(int num)
        {
            switch (num)
            {
                case int x when x >= 1000:
                    return _romanNumeralsDictionary[1000] + IntToRoman(x - 1000);
                case int x when x >= 900:
                    return _romanNumeralsDictionary[900] + IntToRoman(x - 900);
                case int x when x >= 500:
                    return _romanNumeralsDictionary[500] + IntToRoman(x - 500);
                case int x when x >= 400:
                    return _romanNumeralsDictionary[400] + IntToRoman(x - 400);
                case int x when x >= 100:
                    return _romanNumeralsDictionary[100] + IntToRoman(x - 100);
                case int x when x >= 90:
                    return _romanNumeralsDictionary[90] + IntToRoman(x - 90);
                case int x when x >= 50:
                    return _romanNumeralsDictionary[50] + IntToRoman(x - 50);
                case int x when x >= 40:
                    return _romanNumeralsDictionary[40] + IntToRoman(x - 40);
                case int x when x >= 10:
                    return _romanNumeralsDictionary[10] + IntToRoman(x - 10);
                case int x when x >= 9:
                    return _romanNumeralsDictionary[9] + IntToRoman(x - 9);
                case int x when x >= 5:
                    return _romanNumeralsDictionary[5] + IntToRoman(x - 5);
                case int x when x >= 4:
                    return _romanNumeralsDictionary[4] + IntToRoman(x - 4);
                case int x when x >= 1:
                    return _romanNumeralsDictionary[1] + IntToRoman(x - 1);
                default:
                    return string.Empty;
            }
        }
    }
}