namespace ADV01
{
    internal class Program
    {
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


            

        }
    }
}
