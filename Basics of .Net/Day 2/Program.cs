namespace Assignment2
{
    internal class Program
    {
        static int account_number = 0;
        static string name = string.Empty;
        static int balance = 0;

        static void Main(string[] args)
        { 
            while (true)
            {
                Console.WriteLine("1. Create a new bank account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Display Account Detail");
                Console.WriteLine("5. Exit \n");

                Console.WriteLine("Enter the option: ");
                int option_number = Convert.ToInt32(Console.ReadLine());

                switch (option_number)
                {
                    case 1:
                        CreateAccount();
                        break;
                    case 2:
                        DepositMoney();
                        break;
                    case 3:
                        WithdrawMoney();
                        break;
                    case 4:
                        DisplayAccountDetail();
                        break;
                    default:
                        return;
                }
            }
        }

        static void CreateAccount()
        {
            Console.WriteLine("Enter the account number: ");
            account_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the account name: ");
            name = Console.ReadLine();
            Console.WriteLine("Account Created Successfully! \n");
        }

        static void DepositMoney()
        {
            Console.WriteLine("Enter the amount: ");
            balance += Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Deposit Successfull!");
            Console.WriteLine($"Available balance: {balance} \n");
        }

        static void WithdrawMoney()
        {
            Console.WriteLine("Enter the amount: ");
            int debit = Convert.ToInt32(Console.ReadLine());

            if (debit > balance)
            {
                Console.WriteLine("Insufficient Balance. \n");
            }
            else
            {
                balance -= debit;
                Console.WriteLine("Withdrawl Successfull!");
                Console.WriteLine($"Available balance: {balance} \n");
            }
        }

        static void DisplayAccountDetail()
        {
            Console.WriteLine($"Account Number: {account_number}, Account Name: {name}, Balance: {balance} \n");
        }
    }
}
