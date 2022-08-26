using System;
using System.Linq;

namespace Exercises
{
    public class Exercise003
    {
        // Replace the exception statement below with your code!
        public string[] IceCreamFlavours = { "Pistachio", "Raspberry Ripple", "Vanilla", "Mint Chocolate Chip", "Chocolate", "Mango Sorbet" };

        // Replace the exception statement below with your code!
        public int IceCreamCode(string iceCreamFlavour) {
            if (!string.IsNullOrEmpty(iceCreamFlavour))
            {
                for (int i = 0; i < IceCreamFlavours.Count(); i++)
                {
                    if (IceCreamFlavours[i] == iceCreamFlavour) return i;
                }
                return -1;
            }
            else return -1;
        }
    }
}
