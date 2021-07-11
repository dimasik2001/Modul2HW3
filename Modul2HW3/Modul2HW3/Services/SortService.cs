using System;
namespace Modul2HW3
{
    public class SortService : ISortService
    {
       public void SortByCalority(Sweet[] sweets)
        {
            Array.Sort(sweets);
        }
    }
}
