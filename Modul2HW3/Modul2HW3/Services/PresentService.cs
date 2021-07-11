namespace Modul2HW3
{
   public class PresentService
    {
        private int _iterator = 0;
        public PresentService(int capacity)
        {
            Sweets = new Sweet[capacity];
            Capacity = capacity;
        }

        public Sweet[] Sweets { get; private set; }
        public int Capacity { get; }
        public double Weight
        {
            get
            {
                var weightSum = 0d;
                foreach (var item in Sweets)
                {
                    weightSum += item.Weight.Grams;
                }

                return weightSum;
            }
        }

        public void Add(Sweet sweet)
        {
           if (_iterator < Capacity)
            {
                Sweets[_iterator++] = sweet;
            }
        }

        public void Remove()
        {
            Sweets[_iterator--] = null;
        }
    }
}
