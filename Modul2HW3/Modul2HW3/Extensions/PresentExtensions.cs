namespace Modul2HW3
{
    public static class PresentExtensions
    {
        public static Sweet[] FindbyName(this Sweet[] sweets, string name)
        {
            PresentService result;
            var capacity = 0;
            foreach (var item in sweets)
            {
                if (item.Name == name)
                {
                    capacity++;
                }
            }

            result = new PresentService(capacity);

            foreach (var item in sweets)
            {
                if (item.Name == name)
                {
                    result.Add(item);
                }
            }

            return result.Sweets;
        }

        public static Sweet[] FindbyProducer(this Sweet[] sweets, Countries producer)
        {
            PresentService result;
            var capacity = 0;
            foreach (var item in sweets)
            {
                if (item.Producer == producer)
                {
                    capacity++;
                }
            }

            result = new PresentService(capacity);

            foreach (var item in sweets)
            {
                if (item.Producer == producer)
                {
                    result.Add(item);
                }
            }

            return result.Sweets;
        }
    }
}