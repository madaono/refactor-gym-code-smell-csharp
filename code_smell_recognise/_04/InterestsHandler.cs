namespace code_smell_recognise._04
{
    public class InterestsHandler
    {
        public void CalculateInterests(Account account) {
            var interests = account.Balance * 0.003;
            account.Credit(interests);
            if (interests > 300) {
                new MsgSender().SendChangeNotification(account);
            }
        }
    }
}