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
            // Replace the exception statement below with your code!
            //throw new NotImplementedException();
            if (!string.IsNullOrWhiteSpace(word)) { 
                string f = word.Trim();
                return string.Concat(f.Substring(0,1).ToUpper(),f.Substring(1).ToLower());
            }
            else {return word;};
        }

        public string GenerateInitials(string firstName, string lastName)
        {
            // Replace the exception statement below with your code!
            //throw new NotImplementedException();
            return firstName.Trim().Substring(0,1).ToUpper()+"."+lastName.Trim().Substring(0,1).ToUpper();
        }

        public double AddVat(double originalPrice, double vatRate)
        {
            // Replace the exception statement below with your code!
            //throw new NotImplementedException();
            if (originalPrice < 0) {
                throw new ArgumentException("Price cannot be negative. Please enter a valid price.");
            }
            else if (vatRate < 0) {
                throw new ArgumentException("VAT cannot be negative. Please enter a valid VAT.");
            };
            return Math.Round(originalPrice + originalPrice * vatRate / 100,2);

            // NB: Look in Exercise001Tests.cs
            //     There is a test with commented out assertions.
            //     For an extra challenge, uncomment those assertions and make that test pass too.
        }

        public string Reverse(string sentence)
        {
            // Replace the exception statement below with your code!
            //throw new NotImplementedException();
            if (!string.IsNullOrWhiteSpace(sentence)) {
                char[] chars = sentence.ToCharArray();
                Array.Reverse(chars);
                return new string(chars);
            }
            else {return sentence;};
        }

        public int CountLinuxUsers(List<User> users)
        {
            // Replace the exception statement below with your code!
            //throw new NotImplementedException();
            if ((users != null) && users.Any()) {
                int count = 0;
                foreach (User user in users)
                {
                    //Console.WriteLine(user.Type);
                    if (user.Type == "Linux") count++;
                };
                return count;
            }
            else {return 0;};
        }
    }
}
