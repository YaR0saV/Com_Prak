namespace _3
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
            if (y >= 0 & x * x + y * y >= 1 & x * x + y * y <= 4)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
            Console.ReadLine();
        }
    }
}