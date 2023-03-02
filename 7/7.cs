namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float value = 0.0f;
            value = Single.Parse(Console.ReadLine());
            double a = value;
            int n = Convert.ToInt32(Console.ReadLine());
            double c = a;
            for (int i = 1; i < n; i++)
            {
                c = c * a;
            }
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}