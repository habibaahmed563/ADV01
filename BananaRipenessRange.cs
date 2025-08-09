using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV01
{
    internal class BananaRipenessRange<T> where T : IComparable<T>
    {
        public T minRipeness;
        public T maxRipeness;

        public BananaRipenessRange(T min,T max)
        {
            minRipeness = min;
            maxRipeness = max;
        }

        public bool Isperfectbanana(T ripeness)
        {
            return ripeness.CompareTo(minRipeness) >= 0 && ripeness.CompareTo(maxRipeness) <= 0;
        }

    }
}
