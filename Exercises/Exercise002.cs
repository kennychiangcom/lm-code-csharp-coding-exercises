using Exercises.Models;
using System;
using System.Linq;

namespace Exercises
{
    public class Exercise002
    {
        public bool IsFromManchester(Person person) => (person != null) && person.ToString().Any() && person.FromCity.Equals("Manchester");
        public bool CanWatchFilm(Person person, int ageLimit) => person.Age >= ageLimit;
    }
}
