namespace Modul2HW3
{
    public class Weight
    {
        public double Value { get; set; }
        public Units Unit { get; set; }
        public double Grams => Value * GetCoef();
        private double GetCoef()
        {
            return Unit switch
            {
                Units.Gram => 1,
                Units.Kilogram => 1000,
                Units.Pound => 453.59,
                Units.Ounce => 28.349,
                _ => 0,
            };
        }
    }
}
