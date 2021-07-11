namespace Modul2HW3
{
    public class SweetsProvider
    {
        public SweetsProvider()
        {
            Sweets = new Sweet[]
            {
                new CaramelCandy
                {
                    Name = "Chupa-Chups",
                    Weight = new Weight { Value = 12, Unit = Units.Gram },
                    Producer = Countries.Ukraine,
                    CaramelType = CaramelType.Lollipop,
                    MainIngridients = new Ingridients[] { Ingridients.Sugar },
                    NutritionalValue = new NutritionalValue(0.1, 94, 0.2),
                    Taste = Tastes.Orange,
                    WrapperType = WrapperType.Sachet
                },

                new Marmalade
                {
                    Name = "British Enjoy",
                    Weight = new Weight { Unit = Units.Ounce, Value = 2 },
                    Producer = Countries.GreatBritain,
                    MainIngridients = new Ingridients[] { Ingridients.Sugar, Ingridients.FruitJuice },
                    NutritionalValue = new NutritionalValue(0.3, 0, 66),
                    Taste = Tastes.Orange,
                    ThickenerName = Thickener.AgarAgar
                },

                new DriedFruit
                {
                    Name = "Apricot Ecofood",
                    Producer = Countries.Poland,
                    Weight = new Weight { Value = 60, Unit = Units.Gram },
                    NutritionalValue = new NutritionalValue(5.65, 0.3, 36.43),
                    WaterPercent = 7
                },

                new BubbleChocolate
                {
                    Name = "Milka",
                    Producer = Countries.Germany,
                    ChocolateType = ChocolateType.Milk,
                    MainIngridients = new Ingridients[] { Ingridients.Milk, Ingridients.Sugar, Ingridients.Cacao },
                    NutritionalValue = new NutritionalValue(5.7, 30.9, 57.6),
                    Oil = OilType.Cacao,
                    Weight = new Weight { Value = 90, Unit = Units.Gram }
                },

                new Bar
                {
                    Name = "Snickers",
                    ChocolateType = ChocolateType.White,
                    MainIngridients = new Ingridients[] { Ingridients.Milk, Ingridients.Sugar },
                    NougatTaste = Tastes.Caramel,
                    NutritionalValue = new NutritionalValue(7, 24, 63),
                    Producer = Countries.USA,
                    Weight = new Weight { Value = 50, Unit = Units.Gram }
                },

                new FudgeCandy
                {
                    Name = "Night Dream",
                    MainIngridients = new Ingridients[] { Ingridients.Cacao, Ingridients.Sugar },
                    Fudge = FudgeType.Vanilla,
                    Taste = Tastes.Sugary,
                    NutritionalValue = new NutritionalValue(7.65, 0.8, 20.43),
                    Producer = Countries.France,
                    Weight = new Weight { Value = 6, Unit = Units.Gram },
                    WrapperType = WrapperType.None
                },

                new Cookie
                {
                    Name = "King Arthur",
                    FlourType = FlourType.Oat,
                    DoughType = DoughType.Sandy,
                    MainIngridients = new Ingridients[]
                    {
                        Ingridients.Cacao,
                        Ingridients.Eggs,
                        Ingridients.Flour,
                        Ingridients.Milk
                    },
                    NutritionalValue = new NutritionalValue(1, 0, 16),
                    Weight = new Weight { Value = 3, Unit = Units.Ounce },
                    Producer = Countries.GreatBritain
                },
                new Сake
                {
                    Name = "Viennese",
                    FlourType = FlourType.Wheat,
                    MainIngridients = new Ingridients[]
                    {
                        Ingridients.Yeast,
                        Ingridients.Sugar,
                        Ingridients.Eggs,
                        Ingridients.Honey
                    },
                    NutritionalValue = new NutritionalValue(4.6, 12.6, 70.2),
                    Producer = Countries.Italy,
                    StuffingTaste = Tastes.Strawberry,
                    Weight = new Weight { Value = 85, Unit = Units.Gram }
                }
            };
        }

        public Sweet[] Sweets { get; }
    }
}
