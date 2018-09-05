using System;

class BS1
{
    static void Main(string[] args)
    {
        Console.Write("Enter height: ");
        int rows = Int32.Parse(Console.ReadLine());

        Console.Write("Enter width: ");
        int cols = Int32.Parse(Console.ReadLine());

        int a = 0;
        for (int row = 1; row <= rows; row++)
        {
            Console.Write(row + " ");

            a = row;
            for (int col = 1; col < cols; col++)
            {
                a += rows;
                Console.Write(a + " ");
            }
            Console.WriteLine();
            a = 0;
        }
    }
}