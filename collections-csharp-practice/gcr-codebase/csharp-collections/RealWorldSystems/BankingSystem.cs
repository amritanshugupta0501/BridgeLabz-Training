using System.Collections.Generic;
using System.Linq;
public class BankingSystem
{
    private Dictionary&lt;int, double&gt; _accounts = new Dictionary&lt;int, double&gt;();
    private Queue&lt;int&gt; _withdrawalRequests = new Queue&lt;int&gt;();
    public void CreateAccount(int accountId, double initialDeposit)
    {
        _accounts[accountId] = initialDeposit;
    }
    public void RequestWithdrawal(int accountId)
    {
        _withdrawalRequests.Enqueue(accountId);
    }
    public void ProcessNextWithdrawal()
    {
        if (_withdrawalRequests.Count &gt; 0)
        {
            int accountId = _withdrawalRequests.Dequeue();
            // Process logic here
        }
    }
    public List&lt;KeyValuePair&lt;int, double&gt;&gt; GetCustomersByBalance()
    {
        return _accounts.OrderBy(x =&gt; x.Value).ToList();
    }
    public static void Main(string[] args)
    {
        BankingSystem bank = new BankingSystem();
        bank.CreateAccount(1, 1000.0);
        bank.CreateAccount(2, 500.0);
        bank.CreateAccount(3, 1500.0);
        bank.RequestWithdrawal(1);
        bank.RequestWithdrawal(2);
        Console.WriteLine("Processing withdrawals...");
        bank.ProcessNextWithdrawal();
        bank.ProcessNextWithdrawal();
        Console.WriteLine("Customers sorted by balance:");
        var sorted = bank.GetCustomersByBalance();
        foreach (var acc in sorted)
        {
            Console.WriteLine($"Account {acc.Key}: ${acc.Value}");
        }
    }
}