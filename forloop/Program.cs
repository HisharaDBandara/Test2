using System;

namespace forloop
{
    public class forloop
    {
       static void Main(String[] args)
        {
            int x, y, row;

            Console.Write("Enter the Row: ");
            row = Convert.ToInt32(Console.ReadLine());

            for (x = 1; x <= row; x++)
            {
                for (y = 1; y <= x; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");

            }

            Console.ReadLine();
        } 
    }
}