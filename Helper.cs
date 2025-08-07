using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV01
{
    internal class Helper/*<T>*/
    {
        //Generic Linear Search Method
        public static int LinearSearch<T>(T[] Arr, T value)
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    if (Arr[i] .Equals( value)) return i;
                }
            }

            return -1;
        }

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
