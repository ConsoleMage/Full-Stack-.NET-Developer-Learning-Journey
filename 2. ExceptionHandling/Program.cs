namespace FullStackJourney.ExceptionHandling
{
    public static class Bank
    {
        static void Main(string[] args)
        {
            try
            {
                Account account = new Account();
                account.Deposit(200);
                account.Withdraw(300);
                System.Console.WriteLine(account.ToString());
            }
            catch (InSufficientBalanceException ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
    }
    public class Account()
    {
        // keep fields private
        private double _balance;

        // wrap field with property below
        public double Balance
        {
            get { return _balance; }
        }

        public bool Deposit(double depositAmt)
        {
            if (depositAmt > 0)
            {
                _balance += depositAmt;
                return true;
            }
            return false;
        }

        public bool Withdraw(double withdrawAmt)
        {
            if (withdrawAmt > 0 && withdrawAmt <= _balance)
            {
                _balance -= withdrawAmt;
                return true;
            }
            else if (withdrawAmt > _balance)
            {
                throw new InSufficientBalanceException("InSufficient Balance...");
            }
            return false;
        }

        public override string ToString()
        {
            return ("Account Balance is :" + _balance);
        }
    }

    public class InSufficientBalanceException : Exception
    {
        public InSufficientBalanceException(string message) : base(message)
        {
        }
    }
}