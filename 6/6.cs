namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            float value = 0.0f;
            value = Single.Parse(Console.ReadLine());
            double a = value;
            value = Single.Parse(Console.ReadLine());
            double b = value;
            double e = (b - a) / n;
            Console.WriteLine(e);
            double c = a;
            for (int i = 0; i < n + 1; i++)
            {
                Console.WriteLine(c);
                c += e;
            }
            Console.ReadLine();
        }
    }
}