namespace Scenario_Based.SupermarketBillingSystem
{
    internal interface ICustomerCartManager
    {
        void AddAProductToTheCart(CustomerDetails customerDetails, string choice);
        void CalculateTotalBill(CustomerDetails customerDetails);
        void DisplayAllProducts(CustomerDetails customerDetails);
    }
}