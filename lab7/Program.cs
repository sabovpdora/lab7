using System;
using System.Collections.Generic;
using System.Text;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            var Check = new CheckBalance();
            var Upload = new UploadMoney();

            Console.WriteLine("\t\tPlease, choose the operation\n1.Check the balance; \t\t2.Upload credit card\nPlease, press 1 or 2");

            int n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                var CheckB = new CheckBalance();

                Client.CustomerCode(CheckB);

            }
            else if (n == 2)
            {
                var Upload = new UploadMoney();

                Client.CustomerCode(Upload);
                Upload.SetNext(Upload).SetNext(UploadMoney);
            }
            else
                Console.WriteLine("Choose numbers from 1 to 2");
        }
    }
    class Block : AbsHandler
    {
        public override void Block()
        {
            Console.WriteLine("We are blocking your account.");
            this._context.TransitionTo(new UnBlock());
        }

        public override void Unblock()
        {
            Console.WriteLine("We are unblocking your account.");
        }
    }
    class UnBlock : AbsHandler
    {
        public override void Block()
        {
            Console.Write("We are Blocking your account");
        }

        public override void Unblock()
        {
            Console.WriteLine("We are UnBlocking your account.");
            this._context.TransitionTo(new Block());
        }
    }
}
