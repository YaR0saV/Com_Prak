namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int c = a;
            int b = 0;
            for (int i = 0; i < 4; i++)
            {
                b = b * 10 + c % 10;
                c = c / 10;
            }
            if (b == a)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.ReadLine();
        }
    }
}