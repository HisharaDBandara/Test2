using System;
using System.Threading.Channels;

namespace passwordvalidity
{
    class password
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter your Password : ");
            string password = Console.ReadLine();

            bool hasUppercase = false;
            bool hasLowercase = false;
            bool hasDigit = false;
            bool hasSpecial = false;

            for (int i = 0; i < password.Length; i++)
            {
                char ch = password[i];

                if (char.IsUpper(ch))
                {
                    hasUppercase = true;
                   
                }else if (char.IsLower(ch))
                    
                {
                    hasLowercase = true;
                   
                }else if (char.IsDigit(ch))
                {
                    hasDigit = true; 
                }
                else
                {
                    hasSpecial = true;
                }
            }
            bool isValid = hasUppercase && hasLowercase && hasDigit && hasSpecial && password.Length >= 8;
            if (isValid)
            {
                Console.WriteLine("Password valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            Console.ReadLine();
        }
    }
}