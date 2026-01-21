using System.Collections.Generic;
using System.Linq;
public class ShoppingCart
{
    private Dictionary&lt;string, double&gt; _items = new Dictionary&lt;string, double&gt;();
    private List&lt;string&gt; _insertionOrder = new List&lt;string&gt;();
    public void AddItem(string product, double price)
    {
        _items[product] = price;
        _insertionOrder.Add(product);
    }
    public List&lt;KeyValuePair&lt;string, double&gt;&gt; GetItemsSortedByPrice()
    {
        return _items.OrderBy(x =&gt; x.Value).ToList();
    }
    public static void Main(string[] args)
    {
        ShoppingCart cart = new ShoppingCart();
        cart.AddItem("Apple", 1.50);
        cart.AddItem("Banana", 0.75);
        cart.AddItem("Orange", 2.00);
        cart.AddItem("Grapes", 3.25);
        Console.WriteLine("Items sorted by price:");
        var sorted = cart.GetItemsSortedByPrice();
        foreach (var item in sorted)
        {
            Console.WriteLine($"{item.Key}: ${item.Value}");
        }
    }
}