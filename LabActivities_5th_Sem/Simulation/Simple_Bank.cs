using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabActivities_5th_Sem.Simulation
{
    public static class Simple_Bank
    {
        static Dictionary<string, Tuple<string, Action>> options = new Dictionary<string, Tuple<string, Action>>
        {
            { "1", new Tuple<string, Action>("Create Account", Banking_System.Create_Account) },
            { "2", new Tuple<string, Action>("Deposit Money", Banking_System.Deposit) },
            { "3", new Tuple<string, Action>("Withdraw Money", Banking_System.Withdraw) },
            { "4", new Tuple<string, Action>("Balance Enquery", Banking_System.Enquery) },
            { "0", new Tuple<string, Action>("Exit", Kill) },
        };

        public static void Entry_Point()
        {
            while (true)
            {
                Console.WriteLine("What you want to do? ");
                foreach (var option in options)
                {
                    Console.WriteLine($"{option.Key}\t:\t{option.Value.Item1}");
                }
                Console.Write("Choose a option: ");
                options[Console.ReadLine()].Item2.Invoke();
            }
        }

        static void Kill()
        {
            Environment.Exit(0);
        }
    }

    class Account
    {
        public Account(string account_holder_name, string account_number, double amount) 
        {
            this.account_holder_name = account_holder_name;
            this.account_number = account_number;
            this.amount = amount;
        }
        string account_holder_name;
        string account_number;
        double amount;

        public void Deposit(double amount)
        {
            this.amount += amount;
            //Console.WriteLine("फेरि पनि आउदै गर्नु होला!");
            Console.WriteLine("See you again!");

        }
        public void Withdraw(double amount)
        {
            if (this.amount < amount)
            {
                //Console.WriteLine("राख्न देको थिइस् र?");
                Console.WriteLine("Insufficient Balance!");

                return;
            }
            this.amount -= amount;
            //Console.WriteLine("हजुर को समय उज्ज्वल रहोस्।");
            Console.WriteLine("Have a nice day!");

            return;
        }
        public void Enquery()
        {
            Console.WriteLine($"You have Rs. {this.amount}");
            return;
        }
    }

    static class Banking_System
    {
        static Dictionary<string, Account> members = new Dictionary<string, Account> { };
        public static void Create_Account()
        {
            Console.Write("Enter Account Holder Name: ");
            string account_holder_name = Console.ReadLine();
            Console.Write("Enter Account Number: ");
            string account_number = Console.ReadLine();
            Console.Write("Enter Initial Deposit: ");
            Double.TryParse(Console.ReadLine(), out double amount);

            Account new_account = new Account(account_holder_name, account_number, amount);
            members.Add(account_number, new_account);
            Console.WriteLine("Account created succssfully!");
        }

        public static void Deposit()
        {
            Console.Write("Enter Account Number: ");
            string account_number = Console.ReadLine();

            Console.Write("Enter the amount to deposit: ");
            Double.TryParse(Console.ReadLine(), out double amount);

            members[account_number].Deposit(amount);
        }
        public static void Withdraw()
        {
            Console.Write("Enter Account Number: ");
            string account_number = Console.ReadLine();

            Console.Write("Enter the amount to Withdraw: ");
            Double.TryParse(Console.ReadLine(), out double amount);

            members[account_number].Withdraw(amount);
        }
        public static void Enquery()
        {
            Console.Write("Enter Account Number: ");
            string account_number = Console.ReadLine();

            members[account_number].Enquery();
        }
    }
}
