namespace ADV01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BananaRipenessRange<int> bananaRange = new BananaRipenessRange<int>(5, 10);

            Console.WriteLine(bananaRange.Isperfectbanana(7));
            Console.WriteLine(bananaRange.Isperfectbanana(2));

            BananaRipenessRange<double> bananaRangedouble = new BananaRipenessRange<double>(5.5, 10.6);

            Console.WriteLine(bananaRangedouble.Isperfectbanana(4.8));
            Console.WriteLine(bananaRangedouble.Isperfectbanana(8.3));

        }
    }
}
