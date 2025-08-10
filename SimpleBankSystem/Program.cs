using SimpleBankSystem.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            int option = 0;
            List <Account> accounts = new List<Account>();
            while(option!= 5)
            {
                Console.WriteLine("1 - Create new account");
                Console.WriteLine("2 - Deposit");
                Console.WriteLine("3 - Withdraw");
                Console.WriteLine("4 - Check account status");
                Console.WriteLine("5 - Exit");
                option = int.Parse(Console.ReadLine());
                

                
                switch (option){
                    case 1:
                        Console.WriteLine("Normal or bussiness account?(N/B)");
                        char temp = char.Parse(Console.ReadLine());
                        Console.Write("Holder:");
                        string holder = Console.ReadLine();
                        Console.Write("Number:");
                        int number = int.Parse(Console.ReadLine());
                        if (temp == 'n' || temp == 'N')
                        {
                            accounts.Add(new Account(holder, number));
                        }
                        else
                        {
                            Console.Write("Loan Limit:");
                            double loanlimit = double.Parse(Console.ReadLine());
                            accounts.Add(new BusinessAccount(holder, number,loanlimit));
                        }
                        Console.Clear();
                            break;

                    case 2:
                        Console.Write("Type the account number:");
                        number = int.Parse(Console.ReadLine());
                        Account acc = accounts.Find(x => x.Number == number);
                        Console.Write("Enter the amount:");
                        double amount = double.Parse(Console.ReadLine());
                        acc.Deposit(amount);
                        Console.Clear();
                        Console.WriteLine("Successful");


                        break;
                    case 3:
                        Console.Write("Type the account number:");
                        number = int.Parse(Console.ReadLine());
                        Account act = accounts.Find(x => x.Number == number);
                        Console.Write("Enter the amount");
                        double amountt = double.Parse(Console.ReadLine());
                        act.Withdraw(amountt);
                        Console.Clear();
                        Console.WriteLine("Successful");
                        break;
                    case 4:
                        Console.Write("Type the account number:");
                        number = int.Parse(Console.ReadLine());
                        Account acte = accounts.Find(x => x.Number == number);
                        Console.Clear();
                        Console.WriteLine(acte);
                        Console.WriteLine("Successful");
                        break;

                }
            }
        }catch(FormatException e)
        {
            Console.WriteLine("An error occured: " + e.Message);
        }catch(Exception e)
        {
            Console.WriteLine("An error occured: " + e.Message);
        }
    }
}