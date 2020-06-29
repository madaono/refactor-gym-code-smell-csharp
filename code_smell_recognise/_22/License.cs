
namespace code_smell_recognise._22
{
    public class License
    {
        private Motorist motorist;

        public Motorist Motorist
        {
            set => motorist = value;
        }

        public int Points { get; private set; } = 0;

        public void AddPoints (int points) {
            Points += points;
        }

        public string GetSummary() {
            return motorist.Title + " " + motorist.FirstName
                   + " " + motorist.Surname + ", " + Points;
        }
    }
}