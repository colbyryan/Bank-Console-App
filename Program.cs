using System;

namespace Bank_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            try
            {
                string bankName = args[0];
                bank.Name = bankName;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Please Enter the bank name.");
                return;
            }

            Console.WriteLine($"Welcome to {bank.Name}'s Management System!");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Please Select an option: ");
            Console.WriteLine("1 - Exit");
            Console.Write("> ");
            Console.ReadLine();
        }
    }
}
