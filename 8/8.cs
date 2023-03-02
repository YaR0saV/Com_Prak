namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float value = 0.0f;
            value = Single.Parse(Console.ReadLine());
            double p = value;
            double s = 1000;
            int i = 0;
            while (s < 1100)
            {
                i ++;
                s = s + s * p / 100;
            }
            Console.WriteLine(i + " " + s);
            Console.ReadLine();
        }
    }
}