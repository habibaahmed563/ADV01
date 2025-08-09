using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV01
{
    internal class Range<T> where T :IComparable<T>,IConvertible
    {
        public T Min { get; }
        public T Max { get; }

        public Range(T min,T max)
        {
            if(min.CompareTo(max)>0)
            {
                var temp = min;
                min = max;
                max = temp;
            }

            Min = min;
            Max = max;
        }
        public bool IsRange (T value)
        {
            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        }

        public double Length
        {
            get 
            {
                double dMin = Convert.ToDouble(Min);
                double dMax = Convert.ToDouble(Max);
                return dMax - dMin;
            }
        }

        public override string ToString()
        {
            return $"{Min} , {Max},Length = {Length}";
        }
    }
}
