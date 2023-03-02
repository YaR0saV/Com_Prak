namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float value = 0.0f;
            value = Single.Parse(Console.ReadLine());
            double x = value;
            value = Single.Parse(Console.ReadLine());
            double y = value;
            if (y >= 0 & x * x + y * y <= 1 & Math.Abs(x) <= y)
            {
                Console.WriteLine(x + y);
            }
            else
            {
                Console.WriteLine(x - y);
            }
            Console.ReadLine();
        }
    }
}