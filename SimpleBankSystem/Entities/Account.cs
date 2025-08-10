namespace SimpleBankSystem.Entities
{
    internal class Account
    {
        public string Holder { get; set; }
        public int Number { get; set; }
        public double Balance { get; private set; }
        public Account(string holder, int number)
        {
            Holder = holder;
            Number = number;
            Balance = 0;
        }
        public Account()
        {
        }

        public virtual void Deposit(double amount)
        {
            Balance += amount;
        }

        public virtual void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public override string ToString()
        {
            return "HOLDER: " 
                + Holder 
                + "\nNUMBER: " 
                + Number 
                + "\nBALANCE: " 
                + Balance;
        }
    }
}
