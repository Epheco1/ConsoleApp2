using System;

namespace ConsoleApp2
{
    class MobileBanking
    {

        static void Main(string[] args)
        {
            Customer newCustomer = new Customer();

            newCustomer.Login();
            newCustomer.Deposit();

        }
    }
}
