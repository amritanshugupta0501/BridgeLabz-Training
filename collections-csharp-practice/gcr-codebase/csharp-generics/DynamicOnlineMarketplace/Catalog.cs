using System.Collections.Generic;

public class Catalog<T> where T : Product
{
    private List<T> products = new List<T>();

    public void AddProduct(T product)
    {
        products.Add(product);
    }
}