using System.Collections.Generic;
using System.Text;

namespace code_smell_recognise._03
{
    public class Customer
    {
        private string name;
        private readonly List<Rental> rentals = new List<Rental>();

        public string Statement()
        {
            var totalAmount = 0d;
            var frequentRenterPoints = 0;
            using var rentals = this.rentals.GetEnumerator();
            var result = new StringBuilder("Rental Record for " + name + "\n");
            while (rentals.MoveNext())
            {
                var each = rentals.Current;
                //show figures for this rental
                //determine amounts for each line
                var thisAmount = 0d;
                switch (each.Movie.PriceCode)
                {
                    case Movie.Regular:
                        thisAmount += 2;
                        if (each.DaysRented > 2)
                            thisAmount += (each.DaysRented - 2) * 1.5;
                        break;
                    case Movie.NewRelease:
                        thisAmount += each.DaysRented * 3;
                        break;
                    case Movie.Children:
                        thisAmount += 1.5;
                        if (each.DaysRented > 3)
                            thisAmount += (each.DaysRented - 3) * 1.5;
                        break;
                }

                //add frequent renter points
                frequentRenterPoints++;
                if ((each.Movie.PriceCode == Movie.NewRelease) && each.DaysRented > 1)
                    frequentRenterPoints++;

                //show figures for this rental
                result.Append("\t")
                    .Append(each.Movie.Title)
                    .Append("\t")
                    .Append(thisAmount).Append("\n");
                totalAmount += thisAmount;
            }

            //add footer lines
            result.Append(GenerateFooterLines(totalAmount, frequentRenterPoints));
            return result.ToString();
        }

        // generate footer lines
        private string GenerateFooterLines(double totalAmount, int frequentRenterPoints)
        {
            var result = new StringBuilder();
            result.Append("Amount owed is ").Append(totalAmount).Append("\n");
            result.Append("You earned ").Append(frequentRenterPoints).Append(" frequent renter points");
            return result.ToString();
        }
    }
}