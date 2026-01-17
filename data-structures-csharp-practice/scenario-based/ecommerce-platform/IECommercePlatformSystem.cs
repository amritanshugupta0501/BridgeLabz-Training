namespace Scenario_Based.ecommerceplatform
{
    internal interface IECommercePlatformSystem
    {
        void AddProductInThePantry();
        int CountProducts();
        void DisplayTheHighestDiscountedProducts();
        int GenerateDiscountForAProduct();
        int PartitionInProducts(ProductNode[] products, int low, int high);
        ProductNode[] SortedProductsList(ProductNode[] products, int low, int high);
    }
}