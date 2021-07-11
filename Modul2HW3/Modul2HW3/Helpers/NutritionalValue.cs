using System;

namespace Modul2HW3
{
    public class NutritionalValue
    {
        public NutritionalValue(double proteins, double fats, double carbohydrates)
        {
            if (IsValid(proteins, fats, carbohydrates))
            {
                Proteins = proteins;
                Fats = fats;
                Carbohydrates = carbohydrates;
            }
        }

        public double Proteins { get; private set; }
        public double Fats { get; private set; }
        public double Carbohydrates { get; private set; }

        public double Calories => (Proteins * 4) + (Fats * 9) + (Carbohydrates * 4);

        private bool IsValid(params double[] pfc)
        {
            var sum = 0d;
            foreach (var item in pfc)
            {
                if (item < 0 || item > 100)
                {
                    return false;
                }

                sum += item;
            }

            if (sum > 100)
            {
                return false;
            }

            return true;
        }
    }
}
