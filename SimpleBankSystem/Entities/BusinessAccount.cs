
namespace SimpleBankSystem.Entities
{
    internal class BusinessAccount : Account
    {
        public double LoanLimit { get; private set; }
        public BusinessAccount(string holder, int number, double loanLimit) : base(holder, number)
        {
            LoanLimit = loanLimit;
        }
        public sealed override void Deposit(double amount)
        {
            base.Deposit(amount);
        }
        public sealed override void Withdraw(double amount)
        {
            base.Withdraw(amount);
        }

    }
}
