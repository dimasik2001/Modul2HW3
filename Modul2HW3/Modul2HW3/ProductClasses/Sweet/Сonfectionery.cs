namespace Modul2HW3
{
    public abstract class Сonfectionery : Sweet
    {
        public Ingridients[] MainIngridients { get; set; }
        public override string ToString()
        {
            return base.ToString() + $" :: Main Ingridients: {string.Join(", ", MainIngridients)}";
        }
    }
}
