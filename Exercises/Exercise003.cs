using System;
using System.Linq;

namespace Exercises
{
    public class Exercise003
    {
        public string[] IceCreamFlavours = { "Pistachio", "Raspberry Ripple", "Vanilla", "Mint Chocolate Chip", "Chocolate", "Mango Sorbet" };

        public int IceCreamCode(string iceCreamFlavour) {
            if (string.IsNullOrEmpty(iceCreamFlavour)) return -1;
            else {
                for (int i = 0; i < IceCreamFlavours.Count(); i++) {
                    if (IceCreamFlavours[i] == iceCreamFlavour) return i;
                }
                return -1;
            }
        }
    }
}
