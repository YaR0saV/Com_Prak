namespace Com_Prak
{
    internal class Program1
    {
        static void Main(string[] args1)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0 & a > 9 & a < 100)
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