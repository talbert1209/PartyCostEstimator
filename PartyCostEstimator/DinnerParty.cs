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

        public void CalculateCostOfDecorations(bool fancy)
        {
            if (fancy)
            {
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50.00M;
            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30.00M;
            }
        }

        public decimal CalculateCost()
        {
            var totalCost = (CostOfFoodPerPerson * NumberOfPeople) + (CostOfBeveragesPerPerson * NumberOfPeople) + CostOfDecorations;

            if (CostOfBeveragesPerPerson == 5.00M)
            {
                var discount = .05M * totalCost;
                return totalCost - discount;
            }

            return totalCost;
        }

    }
}