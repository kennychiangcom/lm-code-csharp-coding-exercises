using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Models
{
    public class Person
    {
        public Person(string firstname, string lastname, string fromCity, int age)
        {
            FirstName = firstname;
            LastName = lastname;
            FromCity = fromCity;
            Age = age;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FromCity { get; set; }
        public int Age { get; set; }

    }
}
