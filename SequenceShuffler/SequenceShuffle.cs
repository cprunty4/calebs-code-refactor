using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceShuffler
{
    public class SequenceShuffle<T> : IEnumerator<T>
    {
        public SequenceShuffle(IEnumerable<T> sequence)
        {
            this.Data = sequence.ToArray();

            this.RandomNumbers = new Random();  //default is seeded by time

        }

        public T Current => this.Data[this.Position];

        private T[] Data { get; }


        private Random RandomNumbers;

        private int Position { get; set; } = -1;

        object? IEnumerator.Current => this.Current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (this.Position >= this.Data.Length - 1) return false;
            this.Position += 1;

            int pick = this.RandomNumbers.Next(this.Position, this.Data.Length);

            (Data[Position], Data[pick]) = (Data[pick], Data[Position]);    // using tuple(s)

            return true;
        }

        public void Reset()
        {
            this.Position = -1;
        }
    }
}
