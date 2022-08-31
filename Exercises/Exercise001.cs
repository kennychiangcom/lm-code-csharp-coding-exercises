using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Exercises.Models;

namespace Exercises
{
    public class Exercise001
    {
        public string CapitalizeWord(string word)
        {
            if (string.IsNullOrWhiteSpace(word)) return word;
            else return string.Concat(word.Trim()[..1].ToUpper(), word.Trim()[1..].ToLower());
        }

        public string GenerateInitials(string firstName, string lastName) => firstName.Trim()[..1].ToUpper() + "." + lastName.Trim()[..1].ToUpper();

        public double AddVat(double originalPrice, double vatRate)
        {
            if (originalPrice < 0) throw new ArgumentException("Price cannot be negative. Please enter a valid price.");
            else if (vatRate < 0) throw new ArgumentException("VAT cannot be negative. Please enter a valid VAT.");
            return Math.Round(originalPrice + originalPrice * vatRate / 100,2);
        }

        public string Reverse(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence)) return sentence;
            else {
                char[] chars = sentence.ToCharArray();
                Array.Reverse(chars);
                return new string(chars);
            }
        }

        public int CountLinuxUsers(List<User> users)
        {
            if ((users != null) && users.Any()) {
                int count = 0;
                foreach (User user in users) if (user.Type.Equals("Linux")) count++;
                return count;
            }
            else return 0;
        }
    }
}
