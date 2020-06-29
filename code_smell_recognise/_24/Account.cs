namespace code_smell_recognise._24
{
    public class Account
    {
        public int AccountNumber { get; }
        public double Balance { get; private set; } = 0;

        public Account(int accountNumber)
        {
            AccountNumber = accountNumber;
        }

        public void Credit(double amount) {
            Balance += amount;
        }

        public void Debit(double amount) {
            Balance -= amount;
        }

        public string ToXml() {
            return "<account><id>" + AccountNumber
                                   + "</id><balance>" + Balance
                                   + "</balance></account>";
        }

        public string ToText() {
            return "Account: " + AccountNumber + "\nBalance: " + Balance;
        }
    }
}