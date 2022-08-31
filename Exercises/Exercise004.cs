using System;
namespace Exercises
{
    public class Exercise004
    {
        public static DateTime AddGigaSecond(DateTime dateTime) => dateTime.AddSeconds(Math.Pow(10,9));
    }
}
