using System;

namespace example
{
    class Test1
    {
        static void Main(String[] args)
        {
            string cusname,cusid;
            int unit;
            double charges,amount,servicechargers = 0,netAmount;

            Console.WriteLine("\n\n");
            Console.WriteLine("Calculate Electricity Bill\n");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("\n\n");


            Console.Write("Input Customer ID:");
            cusid = Console.ReadLine();

            Console.Write("Input Customer Name:");
            cusname = Console.ReadLine();

            Console.Write("Input unit consume by customer:");
            unit = Convert.ToInt32(Console.ReadLine());

                        
            if (unit<200)
            {
               charges = 1.20;

            }else if (unit >= 200 && unit < 400)
            {
                charges = 1.50;
            }
            else if (unit >= 400 && unit < 600)
            {
                charges = 1.8;
            }
            else
            {
                charges = 2;
            }

            amount = unit * charges;

            if (amount > 300)
                            servicechargers = amount * 15 / 100.00;

            netAmount = amount + servicechargers;

            if (netAmount < 100)
                netAmount = 100;


            Console.Write("\nElectricity Bill \n");
            Console.Write("Customer ID                       :{0}\n", cusid);
            Console.Write("Customer Nmae                     :{0}\n" , cusname);
            Console.Write("Unit Consume                      :{0}\n" , unit);
            Console.Write("Amount Chargers @Rs. {0} per Unit :{1}\n", charges,amount);
            Console.Write("Servise charge Amount             :{0}\n" , servicechargers);
            Console.Write("Net Amount paid by Customer       :{0}\n" , netAmount);

            Console.ReadLine();
            {
                
            }
        }
    }
}
