using System.Collections.Generic;
using System.Linq;

namespace EnumerableHelper
{
   public static partial class CEnumerableHelper
   {
      public static IEnumerable<IEnumerable<T>> PartitionBy<T>(this IEnumerable<T> arrData, int intPartitionBy)
      {
         return arrData
            .Select((item, index) => new { index, item })
            .GroupBy(x => (x.index / intPartitionBy))
            .Select(x => x.Select(y => y.item));
      }
   }
}
