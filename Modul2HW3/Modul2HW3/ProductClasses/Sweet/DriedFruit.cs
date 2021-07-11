namespace Modul2HW3
{
   public class DriedFruit : Sweet
    {
        private double _waterPercent;
        public double WaterPercent
        {
            get => _waterPercent;
            set
            {
                if (value >= 0 && value < 10)
                {
                    _waterPercent = value;
                }
            }
        }

        public override string ToString()
        {
            return base.ToString() + $" :: Water: {WaterPercent}%";
        }
    }
}
