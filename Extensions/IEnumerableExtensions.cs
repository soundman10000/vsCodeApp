using System.Collections;
using System.Collections.Generic;

namespace vsCode
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<T> YieldOne<T>(this T input)
        {
            yield return input;
        }
    }
}