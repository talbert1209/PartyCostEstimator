namespace PartyCostEstimator
{
    public class DinnerParty
    {
        public int NumberOfPeople;
        public decimal CostOfBeveragesPerPerson;
        public decimal CostOfDecorations;
        public const decimal CostOfFoodPerPerson = 25.00M;

        public void SetHealthyOption(bool healthyOption)
        {
            if (healthyOption)
            {
                CostOfBeveragesPerPerson = 5.00M;
            }
            else
            {
                CostOfBeveragesPerPerson = 20.00M;
            }
        }

        public void CalculateCostOfDecorations()
        {

        }

        public decimal CalculateCost()
        {

            if (SetHealthyOption())
            {
                
            }
        }

    }
}