using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceShuffler
{
    public static class Operators
    {
        //public static IEnumerable<T> Once<T>(this IEnumerable<T> sequence) =>
        //    new SinglePassSequence<T>(sequence);

        public static IEnumerator<T> BeginShuffle<T>(this IEnumerable<T> sequence) =>
            new SequenceShuffle<T>(sequence);

        public static IEnumerable<T> Iterate<T>(this IEnumerator<T> enumerator)
        {
            while(enumerator.MoveNext()) yield return enumerator.Current;
        }


    }
}
