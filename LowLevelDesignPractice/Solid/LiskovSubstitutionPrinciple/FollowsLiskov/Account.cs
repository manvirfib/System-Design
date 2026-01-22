namespace Liskov
{
    abstract class AccountNonWithdrawable
    {
        public abstract void Deposit(int amount);
    }
    abstract class AccountWithdrawable
    {
        public abstract void Deposit(int amount);
        public abstract void Withdraw(int amount);

    }
    class SavingsAccount : AccountWithdrawable
    {
        public override void Deposit(int amount)
        {
            Console.WriteLine("Amount deposited");
        }

        public override void Withdraw(int amount)
        {
            Console.WriteLine("Amount withdrawed");
        }
    }
    class CurrentAccount : AccountWithdrawable
    {
        public override void Deposit(int amount)
        {
            Console.WriteLine("Amount deposited");
        }

        public override void Withdraw(int amount)
        {
            Console.WriteLine("Amount withdrawed");
        }
    }
    class FixedDepositAccount : AccountNonWithdrawable
    {
        public override void Deposit(int amount)
        {
            Console.WriteLine("Amount deposited");
        }
    }
}