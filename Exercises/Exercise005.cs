using System;
using System.Linq;

namespace Exercises
{
    public class Exercise005
    {
        public bool IsPangram(string input)
        {
            // Replace the exception statement below with your code!
            //throw new NotImplementedException();
            if (!string.IsNullOrEmpty(input)) {
                //string sample = string.Concat(input.ToUpper().OrderBy(c => c).Distinct()); <-slower than the following 3 lines
                char[] characters = input.ToUpper().Distinct().ToArray();
                Array.Sort(characters);
                string sample = new string(characters);
                Console.WriteLine(sample);
                int count = 0;
                for (int i = 0; i < sample.Length - 1; i++)
                {
                    if ((int)sample[i] > 64 && (int)sample[i + 1] < 91 && (int)sample[i] != (int)sample[i + 1])
                        count++;
                }
                if (count == 25) return true;
                else return false;
            }
            else return false;
        }
    }
}
