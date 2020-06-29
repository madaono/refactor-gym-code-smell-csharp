namespace code_smell_recognise._04
{
    public class Account
    {
        public Account(int balance, string accountNumber)
        {
            Balance = balance;
            AccountNumber = accountNumber;
        }

        public int Balance { get; private set; }
        public string AccountNumber { get; }

        public void Credit(double amount)
        {
            Balance += (int)amount;
        }

        public void Debit(double amount)
        {
            Balance += (int)amount;
        }
    }
}