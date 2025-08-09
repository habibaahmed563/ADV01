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

        static List<int> EvenNumbers(List<int> numbers)
        {
            List<int> even = new List<int>();
            foreach(int num in numbers)
            {
                if (num % 2 == 0)
                    even.Add(num);
            }
            return even;
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

            Console.WriteLine("==================================");


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

            Console.WriteLine();
            Console.WriteLine("==================================");

            //Q3

            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> evennumbers = EvenNumbers(numbers);

            Console.Write("even numbers is :");
            foreach(int i in evennumbers)
            {
                Console.Write($"{i} ");
            }


            Console.WriteLine();
            Console.WriteLine("==================================");


            //Q4

            try
            {
                FixedSizeList<int> List = new FixedSizeList<int>(3);

                list.Add(10);
                list.Add(20);
                list.Add(30);

                Console.WriteLine(List.Get(0));
                Console.WriteLine(List.Get(1));
                Console.WriteLine(List.Get(2));
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }


        }
    }
}
