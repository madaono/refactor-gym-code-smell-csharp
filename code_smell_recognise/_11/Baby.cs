using System.Collections.Generic;

namespace code_smell_recognise._11
{
    public class Baby: HumanAble
    {
        private readonly Dictionary<string, long> records = new Dictionary<string, long>();
        
        public void Crawl()
        {
            Increase("CRAWL");
        }

        public void Eat()
        {
            Increase("EAT");
        }

        public void Drink()
        {
            Increase("DRINK");
        }

        public void Cry()
        {
            Increase("CRY");
        }

        public void Snore()
        {
            Increase("SNORE");
        }
        
        public long GetTimes(string behavior) {
            return records[behavior];
        }

        private void Increase(string behavior) {
            if (records.TryGetValue(behavior, out var crawlTimes)) {
                records.Add(behavior, crawlTimes + 1);
                return;
            }
            records.Add(behavior, 1L);
        }
    }
}