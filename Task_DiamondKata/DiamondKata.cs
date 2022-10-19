using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_DiamondKata
{
    public class DiamondKata
    {
        private const char firstChar = 'A';
        private const char underScore = '_';
        private const char newLine = '\n';

        public static string Generate(char lastChar)
        {
            if (lastChar == firstChar) return "A";            

            var left = lastChar - firstChar;
            var diamondLength = left + 1;

            var lines = new List<string>();
            var spacing = 1;
            IEnumerable<int> chars = Enumerable.Range(firstChar, lastChar + 1 - firstChar);

            foreach (var character in chars)
            {
                lines.Add(CreateLine(left, character, spacing));
                --left;
                ++diamondLength;
                spacing = diamondLength - left - 2;
            }

            //Generate All
            var half1 = string.Join(newLine, lines);
            lines.Reverse();
            lines.RemoveAt(0);
            var half2 = string.Join(newLine, string.Join(newLine, lines));
            return half1 + newLine + half2;
        }


        private static string CreateLine(int left, int character, int spacing)
        {
            var letter = Convert.ToChar(character);

            var builder = new StringBuilder();
            builder.Append(underScore, left);
            builder.Append(letter);

            if (letter == firstChar) return builder.ToString();

            builder.Append(underScore, spacing);
            builder.Append(letter);

            return builder.ToString();
        }

    }
}
