namespace Task
{
    public class Account
    {
        int AccountNumber;
        string Name;
        int Balance;

        public Account(int accountNumber, string name)
        {
            AccountNumber = accountNumber;
            Name = name;
            Balance = 0;
        }

        public void Deposit()
        {
            Console.WriteLine("Enter the Amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            Balance += amount;
            Console.WriteLine("Deposit Successful!");
            Console.WriteLine($"Available balance: {Balance} \n");
        }

        public void Withdraw()
        {
            Console.WriteLine("Enter the Amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            if (amount > Balance)
            {
                Console.WriteLine("Insufficient Balance. \n");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine("Withdrawal Successful!");
                Console.WriteLine($"Available balance: {Balance} \n");
            }
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Account Number: {AccountNumber}, Account Name: {Name}, Balance: {Balance} \n");
        }
    }
}