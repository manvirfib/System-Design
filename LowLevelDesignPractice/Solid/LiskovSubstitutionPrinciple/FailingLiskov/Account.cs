namespace LiskovFails
{
    abstract class Account
    {
        public abstract void Deposit(int amount);
        public abstract void Withdraw(int amount);

    }
    class SavingsAccount : Account
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
    class CurrentAccount : Account
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
    // Breaking Liskov, as it is narrowing the parent functionality. The FD does not require withdrawal, but still the class inherits the parent Account which is wrong. Because whoever is going to use Account class, they will assume, everything is going to work, but it fails.
    class FixedDepositAccount : Account
    {
        public override void Deposit(int amount)
        {
            Console.WriteLine("Amount deposited");
        }

        public override void Withdraw(int amount)
        {
            throw new NotImplementedException();
        }
    }
}
// The parent class should be easily replaced by the derived classes.