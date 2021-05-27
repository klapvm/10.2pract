using System;

namespace Pract10._2BurKla
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] m = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    m[i, j] = rnd.Next(1, 99);
                    Console.Write("\t" + m[i, j]);
                }
                Console.WriteLine();
            }
            int min, temp;
            for(int c = 0; c < 10; c++)
            {
                for(int r = 0; r < 10; r++)
                {
                    for(int j = r+1; j < 10; j++)
                    {
                        min = r;
                        if (m[j, c] < m[min, c])
                        {
                            min = j;
                        }
                        temp = m[r, c];
                        m[r, c] = m[min, c];
                        m[min, c] = temp;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            for (int r = 0; r < 10; r++)
            {
                for (int c = 0; c < 10; c++)
                {
                    Console.Write("\t" + m[r, c]);
                }
                Console.WriteLine();
            }
        }
    }
}
