using NLog;

namespace code_smell_recognise._11
{
    public class BabyClient
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public static void Main(string[] args)
        {
            HumanAble baby = new Baby();
            baby.Cry();
            baby.Drink();
            baby.Cry();
            baby.Eat();
            baby.Snore();
            baby.Cry();
            baby.Drink();
            baby.Drink();
            baby.Eat();
            baby.Crawl();

            var cryTimes = ((Baby) baby).GetTimes("CRY");
            var eatTimes = ((Baby) baby).GetTimes("EAT");
            var drinkTimes = ((Baby) baby).GetTimes("DRINK");
            var snoreTimes = ((Baby) baby).GetTimes("SNORE");
            var crawlTimes = ((Baby) baby).GetTimes("CRAWL");

            Logger.Info("Cry " + cryTimes + " times");
            Logger.Info("Eat " + eatTimes + " times");
            Logger.Info("Drink " + drinkTimes + " times");
            Logger.Info("Snore " + snoreTimes + " times");
            Logger.Info("Crawl " + crawlTimes + " times");
        }
    }
}