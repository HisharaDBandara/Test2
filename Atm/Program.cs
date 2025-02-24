using System;
using System.Threading.Channels;

namespace atm
{
    class Atm
    {
        static void Main(String[] args)
        {
            int atmPin = 1234;
            int enterPin=0;
            int attempt = 3;

            

            for (int i = 0; i < attempt; i++)
            {
                Console.Write("Enter the Pin : ");
                enterPin = Convert.ToInt32(Console.ReadLine());

                if (enterPin == atmPin)
                {
                    Console.WriteLine("Done");
                    break;
                }
                else
                {
                    Console.WriteLine($"Incorrect pin. {attempt - i - 1}attempt left: ");
                }
            }
            Console.WriteLine("thank you");
        }
    }
}