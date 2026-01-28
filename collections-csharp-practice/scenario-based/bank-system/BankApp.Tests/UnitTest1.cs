using NUnit.Framework;
using System;
[TestFixture]
public class UnitTest
{
    private Program _account;
    [SetUp]
    public void Setup()
    {
        _account = new Program(1000m);
    }
    [Test]
    public void Test_Deposit_ValidAmount()
    {
        _account.Deposit(500m);
        Assert.That(_account.Balance, Is.EqualTo(1500m));
    }
    [Test]
    public void Test_Deposit_NegativeAmount()
    {
        var ex = Assert.Throws<Exception>(() => _account.Deposit(-100m));
        Assert.That(ex.Message, Is.EqualTo("Deposit amount cannot be negative"));
    }
    [Test]
    public void Test_Withdraw_ValidAmount()
    {
        _account.Withdraw(400m);
        Assert.That(_account.Balance, Is.EqualTo(600m));
    }
    [Test]
    public void Test_Withdraw_InsufficientFunds()
    {
        var ex = Assert.Throws<Exception>(() => _account.Withdraw(1500m));
        Assert.That(ex.Message, Is.EqualTo("Insufficient funds."));
    }
}
