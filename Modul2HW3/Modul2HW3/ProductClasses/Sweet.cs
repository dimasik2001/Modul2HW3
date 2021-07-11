using System;
namespace Modul2HW3
{
    public abstract class Sweet : IComparable
    {
        public string Name { get; set; }
        public Countries Producer { get; set; }
        public Weight Weight { get; set; }
        public NutritionalValue NutritionalValue { get; set; }

        public double Calories => NutritionalValue.Calories / 100 * Weight.Grams;
        public int CompareTo(object o)
        {
            var s = o as Sweet;
            if (s != null)
            {
                return Calories.CompareTo(s.Calories);
            }
            else
            {
                throw new Exception("Невозможно сравнить два объекта");
            }
        }

        public override string ToString()
        {
            return $"Type: {GetType().Name} :: Name: {Name} :: Producer: {Producer} ::  Weight: {Weight.Grams}g :: Calories: {(int)Calories}kkal";
        }
    }
}
