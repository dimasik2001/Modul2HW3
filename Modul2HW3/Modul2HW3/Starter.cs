using System;
namespace Modul2HW3
{
    public class Starter
    {
        private const int _presentSize = 10;
        private readonly PresentService _presentService;
        private readonly SortService _sortService;
        private readonly SweetsProvider _sweetsProvider;
        private Sweet[] _present;
        public Starter()
        {
            _sweetsProvider = new SweetsProvider();
            _presentService = new PresentService(10);
            _sortService = new SortService();
        }

        public void Run()
        {
            var rnd = new Random();
            for (var i = 0; i < _presentSize; i++)
            {
                _presentService.Add(_sweetsProvider.Sweets[rnd.Next(_sweetsProvider.Sweets.Length)]);
            }

            Console.WriteLine($"Weight of present: {_presentService.Weight}g");
            _present = _presentService.Sweets;
            Console.WriteLine("Generated present:");
            Console.WriteLine(string.Join<Sweet>(Environment.NewLine, _present));
            _sortService.SortByCalority(_present);
            Console.WriteLine("Sorted by calority:");
            Console.WriteLine(string.Join<Sweet>(Environment.NewLine, _present));
            Console.WriteLine("Finding sweets from Ukraine:");
            var result = _present.FindbyProducer(Countries.Ukraine);
            Console.WriteLine(string.Join<Sweet>(Environment.NewLine, result));
            Console.WriteLine("Finding Snickers:");
            result = _present.FindbyName("Snickers");
            Console.WriteLine(string.Join<Sweet>(Environment.NewLine, result));
        }
    }
}
