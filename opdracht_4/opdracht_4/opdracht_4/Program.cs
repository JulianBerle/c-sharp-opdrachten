namespace Opdracht4
{
    class Program
    {
        static void Main(string[] args)
        {
            int val = 10;
            int i, j, k, a, b, c, d;
            d = 0;
            for (i = 1; i <= val; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    //Console.Write("*");
                }
                for (k = 1; k <= i; k++)
                {
                    if (k % 2 != 0)
                    {
                        Console.Write($"odd({k})");
                    } else
                    {
                        Console.Write($"even({k})");
                    }
                }
                Console.WriteLine("");
            }
            for (a = 1; a <= val; a++)
            {
                for (b = 1; b <= val - a; b++)
                {
                    // Console.Write(" ");  
                }
                for (c = 1; c <= b; c++)
                {
                    if (c % 2 != 0)
                    {
                        Console.Write($"odd({c})");
                    }
                    else
                    {
                        Console.Write($"even({c})");
                    }
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}