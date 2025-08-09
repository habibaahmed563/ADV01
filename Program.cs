using System.Collections;

namespace ADV01
{
    internal class Program
    {

        static void ReverseArrayList(ArrayList list)
        {
            int start = 0;
            int end = list.Count - 1;

            while(start<end)
            {
                Object temp = list[start];
                list[start] = list[end];
                list[end] = temp;

                start++;
                end--;
            }
           
        }

        static void Main(string[] args)
        {

            //Q1

            var r1 = new Range<int>(2, 10);
            Console.WriteLine(r1);
            Console.WriteLine(r1.IsRange(3));
            Console.WriteLine(r1.IsRange(16));

            var r2 = new Range<double>(2.5, 10.5);
            Console.WriteLine(r2.Length);

            var r3 = new Range<int>(12, 4);
            Console.WriteLine(r3);


            //Q2

            ArrayList list = new ArrayList() { 2, 4, 6, 8 };

            Console.WriteLine("before reverse");
            foreach (int i in list)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            ReverseArrayList(list);

            Console.WriteLine("after reverse");
            foreach (int i in list)
            {
                Console.Write($"{i} ");
            }

        }
    }
}
