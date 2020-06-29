using System;

namespace code_smell_recognise._04
{
    public class MsgSender
    {
        public void SendChangeNotification(Account account)
        {
            Console.WriteLine("To account: " + account.AccountNumber + "Your account balance changed. Visit your account to check.");
        }
    }
}