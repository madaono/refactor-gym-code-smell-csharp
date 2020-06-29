namespace code_smell_recognise._03
{
    public class Movie
    {
        public const int Regular = 0;
        public const int NewRelease = 1;
        public const int Children = 2;

        public Movie(int priceCode, string title)
        {
            PriceCode = priceCode;
            Title = title;
        }
        public int PriceCode { get; }
        public string Title { get; }
    }
}