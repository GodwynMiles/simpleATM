namespace simpleATM
{
    internal class Program
    {
            static decimal balance = 10000.00m;

            static void Main()
            {
                bool exit = false;

                while (!exit)
                {
                    Console.WriteLine("\nSIMPLE ATM INTERFACE");
                    Console.WriteLine("Press 1 to Check Balance");
                    Console.WriteLine("Press 2 to Deposit");
                    Console.WriteLine("Press 3 to Withdraw");
                    Console.WriteLine("Press 4 to Exit");

                    Console.WriteLine("Enter your choice: ");
                    int choice;

                    if (int.TryParse(Console.ReadLine(), out choice))
                    {
                        switch (choice)
                        {
                            case 1:
                                CheckBalance();
                                break;
                            case 2:
                                DepositMoney();
                                break;
                            case 3:
                                WithdrawMoney();
                                break;
                            case 4:
                                exit = true;
                                break;
                            default:
                                Console.WriteLine("Invalid...");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid...");
                    }
                }
            }

            static void CheckBalance()
            {
                Console.WriteLine($"Balance: {balance}");
            }
            static void DepositMoney()
            {
                Console.WriteLine("Enter amount: ");
                decimal depostiAmount;

                if (decimal.TryParse(Console.ReadLine(), out depostiAmount) && depostiAmount > 0)
                {
                    balance =+ depostiAmount;
                    Console.WriteLine($"Depsit succesful. New Balance: {balance}");
                }
                else
                {
                    Console.WriteLine("Invalid...");
                }
            }
            static void WithdrawMoney()
            {
                Console.WriteLine("Enter the amount to withdraw: ");
                decimal withdrawAmount;

                if (decimal.TryParse(Console.ReadLine(), out withdrawAmount) && withdrawAmount > 0)
                {
                    if (withdrawAmount <= balance)
                    {
                        balance -= withdrawAmount;
                        Console.WriteLine($"Withdraw Succesful. New Balance: {balance}");
                    }
                    else
                    {
                        Console.WriteLine("Insufficeint funds.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid....");
                }
            }
        }
}
