using Exercises.Models;
using System;
using System.Linq;

namespace Exercises
{
    public class Exercise002
    {
        public bool IsFromManchester(Person person)
        {
            if ((person != null) && person.ToString().Any()) {
                return person.FromCity == "Manchester";
            }
            return false;
        }
        public bool CanWatchFilm(Person person, int ageLimit) {
            return person.Age >= ageLimit;
        }
}
}
