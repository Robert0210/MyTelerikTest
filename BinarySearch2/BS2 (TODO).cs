using System;
class BS2
{
    static void Main()
    {
        int n = 4;

        int a = 0;

        for (int row = 1; row <= n; row++)
        {
            Console.Write(row + " ");
            
            for (int col = row; col <= n; col++)
            {
                if (col / 2 == 0)
                {
                    Console.Write(n * 2 * col + " ");
                }
                else
                {
                    Console.Write((n * col - 1) + 1 + " ");
                }
            }
            Console.WriteLine();
        }
    }
}