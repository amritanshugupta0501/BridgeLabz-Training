using System;

class AccessModifiers
{
	public int num1 = 5;								// Public Access Modifier

	private int num2 = 10;								// Private Access Modifier

	protected int num3 = 20;								// Protected Access Modifier

	internal int num4 = 100;								// Internal Access Modifier

	protected internal int num5 = 123;						// Protected Internal Access Modifier

	// private protected int num6 = 456;

	static void Main()
	{
		PublicModifier obj1 = new PublicModifier();
		obj1.Hello();
		
		AccessModifiers obj2 = new AccessModifiers();
		obj2.showPrivate();

		DerivedAccessModifiers obj3 = new DerivedAccessModifiers();
		obj3.deriveAccess();

	}

	public void showPrivate()
	{
		Console.WriteLine("Private Value is: " + num2);
	}
	
	

}

class PublicModifier
{
	public void Hello()
	{
		AccessModifiers obj2 = new AccessModifiers();
		Console.WriteLine("Public value is: "+obj2.num1);
		Console.WriteLine("Internal value is: "+obj2.num4);
		
	}
}

class DerivedAccessModifiers : AccessModifiers
{
	public void deriveAccess()
	{
		
		Console.WriteLine("Public Value In Derived Class" + num1);
		Console.WriteLine("Internal Value In Derived Class" + num4);
		Console.WriteLine("ProtectedValue In Derived Class" + num3);
		Console.WriteLine("protected internal Value In Derived Class" + num5);
	}
}