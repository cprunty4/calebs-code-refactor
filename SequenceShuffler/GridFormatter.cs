using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceShuffler
{
    public class GridFormatter<T>
    {
        public GridFormatter(IEnumerable<T> data)
        {
            this.Data = new List<string>();

            foreach (T item in data)
            {
                this.Data.Add(item?.ToString() ?? string.Empty);
            }
        }

        private IList<string> Data { get; }

        public IEnumerable<string> Format(int width, int gap) =>
            this.FormatRows(this.GetColumnsCount(width, gap), gap);

        private IEnumerable<string> FormatRows(int columnsCount, int gap) =>
            throw new NotImplementedException();

        private int GetColumnsCount(int width, int gap) =>
            throw new NotImplementedException();
    }
}
