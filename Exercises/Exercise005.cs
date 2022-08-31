using System;
using System.Linq;

namespace Exercises
{
    public class Exercise005
    {
        public int startASCIICode = 65;
        public int endASCIICode = 90;
        public int countZeroBasedTotalAlphabets = 25;
        public bool IsPangram(string input)
        {
            if (string.IsNullOrEmpty(input)) return false;
            else
            {
                char[] characters = input.ToUpper().Distinct().ToArray();
                Array.Sort(characters);
                string sample = new string(characters);
                int count = 0;
                for (int i = 0; i < sample.Length - 1; i++)
                    if ((int)sample[i] >= startASCIICode && (int)sample[i + 1] <= endASCIICode && (int)sample[i] != (int)sample[i + 1]) count++;
                return count.Equals(countZeroBasedTotalAlphabets);
            }
        }
    }
}
