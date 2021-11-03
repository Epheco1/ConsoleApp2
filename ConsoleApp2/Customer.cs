using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Customer
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        public string Password { get; set; }

        public void Login() 
        {
            Console.WriteLine("Pls Enter Your PhoneNumber");
            PhoneNumber = Console.ReadLine();

            if (PhoneNumber == "08011223344")
            {
                Console.WriteLine("Welcome");
            }
        }

        public void Deposit() 
        {
            double initialBalance, newBalance, amount;
            initialBalance = 5000;
            Console.WriteLine("How much would you like to deposit?");
            amount = double.Parse(Console.ReadLine());
            newBalance = initialBalance + amount;
            
            Console.WriteLine(" Your new Balance is : " + newBalance);

        }
    }
}
