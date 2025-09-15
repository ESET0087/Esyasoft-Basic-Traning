using System.Security.Principal;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = null;

            while (true)
            {
                DisplayMenu();

                // asking inputs
                Console.WriteLine("Enter the option: ");
                int option_number = Convert.ToInt32(Console.ReadLine());

                // performing options based on input
                switch (option_number)
                {
                    case 1:
                        CreateAccount(ref account);
                        break;
                    case 2:
                        account.Deposit();
                        break;
                    case 3:
                        account.Withdraw();
                        break;
                    case 4:
                        account.DisplayDetails();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid option! \n");
                        break;
                }
            }
        }

        static void CreateAccount(ref Account account)
        {
            Console.WriteLine("Enter the account number: ");
            int account_number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the account name: ");
            string name = Console.ReadLine() ?? string.Empty;

            account = new Account(account_number, name);

            // confirmation
            Console.WriteLine("Account Created Successfully! \n");
        }

        static void DisplayMenu()
        {
            // displaing options
            Console.WriteLine("1. Create a new bank account");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Display Account Detail");
            Console.WriteLine("5. Exit \n");
        }
    }
}
