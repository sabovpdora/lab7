using System;
using System.Collections.Generic;
using System.Text;

namespace lab7
{
    class Client
    {
            public static void CustomerCode(AbsHandler handler)
        {
            Console.Write("If you want to upload your credit card, please enter the amount :");
            var total = Console.ReadLine();
            try
            {
                var res = handler.Handle(float.Parse(total));
                if (res != null)
                    Console.WriteLine($"The billing system will receive: {res}");
                else
                    Console.WriteLine("Operation Failed, please try again");
            }
            catch (Exception e)
            {
                Console.WriteLine($"You have : {e}\n Enter valid numbers!");
            }

        }
    }
}