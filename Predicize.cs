using System;
using System.Collections.Generic;
using System.Linq;

namespace EnumerableHelper
{
	public static partial class CEnumerableHelper
	{
		public static U Predicize<T, U>(this IEnumerable<KeyValuePair<Predicate<T>, U>> map, T keyCandidate)
		{
			return map.Where(kvp => kvp.Key(keyCandidate)).First().Value;
		}
	}
}