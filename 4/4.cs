namespace _4
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
            if (x > 0)
            {
                if (y >= 0 & x * x + y * y >= 0.09 & x * x + y * y <= 1)
                {
                    Console.WriteLine("1");
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
            else
            {
                if (y >= 0 & x * x + y * y <= 1)
                {
                    Console.WriteLine("1");
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
            Console.ReadLine();
        }
    }
}