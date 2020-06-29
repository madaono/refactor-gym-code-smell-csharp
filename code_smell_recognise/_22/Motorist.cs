namespace code_smell_recognise._22
{
    public class Motorist
    {
        public string Surname { get; set; }
        public string FirstName { get; set; }

        public string Title { get; set; }

        public License License { get; set; }

        public RiskFactor GetRiskFactor() {
            if(License.Points > 3) {
                return RiskFactor.HighRisk;
            }

            if(License.Points > 0) {
                return RiskFactor.ModerateRisk;
            }

            return RiskFactor.LowRisk;
        }
    }
}