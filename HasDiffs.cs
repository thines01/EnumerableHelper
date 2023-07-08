using System.Collections.Generic;
using System.Linq;

namespace EnumerableHelper
{
   public static partial class CEnumerableHelper
   {
      public static bool HasDiffs<T>(this IEnumerable<T> arr1, IEnumerable<T> arr2)
      {
         return
            (!arr1.Count().Equals(arr2.Count()))
            ||
            (arr1.Except(arr2).Any())
            ||
            (arr2.Except(arr1).Any());
      }

      public static bool HasDiffs<T>(this IEnumerable<T> arr1, IEnumerable<T> arr2, IEqualityComparer<T> comp)
      {
         return
            (!arr1.Count().Equals(arr2.Count()))
            ||
            (arr1.Except(arr2, comp).Any())
            ||
            (arr2.Except(arr1, comp).Any());
      }
   }
}