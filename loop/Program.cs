namespace example
{
    class loop
    {
        static void Main(String[] args)
        {

            for (int i = 101; i < 200; i++)
            {
                if (i % 9 == 0)
                {
                    Console.WriteLine(i);

                }
            }


        }
    }
}