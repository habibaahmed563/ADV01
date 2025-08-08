using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV01
{
    internal class Helper/*<T>*/
    {
        public static void Bubblesort<T>(T[] Arr)where T : IComparable<T>
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    for (int j = 0; j < Arr.Length - i - 1; j++)
                    {
                        if (Arr[j].CompareTo(Arr[j + 1])>0)
                            Swap(ref Arr[j], ref Arr[j + 1]);
                    }
                }
            }
        }

        public static int LinearSearch<T>(T[] Arr, T value,IEqualityComparer<T> equalityComparer)
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    if (equalityComparer.Equals(value)) return i;
                }
            }

            return -1;
        }

        public static void Bubblesort<T>(T[] Arr,IComparer<T>comparer) where T : IComparable<T>
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    for (int j = 0; j < Arr.Length - i - 1; j++)
                    {
                        if (Arr[j].CompareTo(Arr[j + 1]) > 0)
                            Swap(ref Arr[j], ref Arr[j + 1]);
                    }
                }
            }
        }

        #region Non Generic Bubble
        //public static void Bubblesort(int[] Arr)
        //{
        //    if (Arr?.Length>0)
        //    {
        //        for(int i =0;i<Arr.Length;i++)
        //        {
        //            for (int j=0;j<Arr.Length-i-1;j++)
        //            {
        //                if (Arr[j] > Arr[j + 1])
        //                    Swap(ref Arr[j], ref Arr[j + 1]);
        //            }
        //        }
        //    }
        //} 
        #endregion

        #region Generic Linear Search Method
        //Generic Linear Search Method
        public static int LinearSearch<T>(T[] Arr, T value)
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    if (Arr[i].Equals(value)) return i;
                }
            }

            return -1;
        } 
        #endregion

        #region Non Generic Linear Search
        //public static int LinearSearch(int[] Arr, int value)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            if (Arr[i] == value) return i;
        //        }
        //    }

        //    return -1;
        //} 
        #endregion

        #region Generic Swap
        public static void Swap<T>(ref T x, ref T y)
        {
            T Temp = x;
            x = y;
            y = Temp;
        } 
        #endregion

        #region Methods
        public static void Print<T>(T data)
        {
            Console.WriteLine(data);
        } 
        #endregion

        #region Non Generic
        //public static void Swap(ref int x , ref int y)
        //{
        //    int Temp = x;
        //    x = y;
        //    y = Temp;

        //}
        //public static void Swap(ref double x, ref double y)
        //{
        //    double Temp = x;
        //    x = y;
        //    y = Temp;

        //}
        //public static void Swap(ref Point x, ref Point y)
        //{
        //    Point Temp = x;
        //    x = y;
        //    y = Temp;

        //} 
        #endregion


    }
}
