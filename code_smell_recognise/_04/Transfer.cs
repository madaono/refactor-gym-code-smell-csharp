namespace code_smell_recognise._04
{
    public class Transfer
    {
        public void Move(Account from, Account to, float amount) {
            from.Debit(amount);
            to.Credit(amount);
            if (amount > 300) {
                SendNotification(from, to);
            }
        }

        private void SendNotification(Account from, Account to) {
            var msgSender = new MsgSender();
            msgSender.SendChangeNotification(from);
            msgSender.SendChangeNotification(to);
        }
    }
}