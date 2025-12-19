using System;

class Operators
{
	static void Main()
	{
		int num1=10;
		int num2=23;
		int num3;
		bool val1=true;
		bool val2=false;
		// Arithmetic Operators(+,-,*,/,%)
		Console.WriteLine(num1+" + "+num2+" = "+(num1+num2));	//Addition
		Console.WriteLine(num1+" - "+num2+" = "+(num1-num2));	//Subtraction
		Console.WriteLine(num1+" * "+num2+" = "+(num1*num2));	//Multiplication
		Console.WriteLine(num1+" / "+num2+" = "+(num1/num2));	//Division
		Console.WriteLine(num1+" % "+num2+" = "+(num1%num2));	//Modulus

		// Relational Operators(==,!=,>,<,>=,<=)
		Console.WriteLine(num1+" == "+num2+" : "+(num1==num2));	//Equal to
		Console.WriteLine(num1+" != "+num2+" : "+(num1!=num2));	//Not Equal to
		Console.WriteLine(num1+" > "+num2+" : "+(num1>num2));	//Greater than
		Console.WriteLine(num1+" < "+num2+" : "+(num1<num2));	//Less than
		Console.WriteLine(num1+" >= "+num2+" : "+(num1>=num2));	//Greater than equal to
		Console.WriteLine(num1+" <= "+num2+" : "+(num1<=num2));	//Less than equal to

		// Logical Operators(&&,||,!)
		Console.WriteLine(val1+" && "+val2+" : "+(val1&&val2));	//Logical AND Operator
		Console.WriteLine(val1+" || "+val2+" : "+(val1||val2));	//Logical OR Operator
		Console.WriteLine("! "+val2+" : "+(!val2));		//Logical NOT Operator

		// Assignment Operators(=,+=,-=,*=,/=,%=)
		Console.WriteLine("num3 = "+(num3=num1));		//Assignment Operator
		Console.WriteLine("num3 += "+num1+" : "+(num3+=num1));	//Additional Assignment Operator
		Console.WriteLine("num3 -= "+num1+" : "+(num3-=num1));	//Subtraction Assignment Operator
		Console.WriteLine("num3 *= "+num1+" : "+(num3*=num1));	//Multiplication Assignment Operator
		Console.WriteLine("num3 /= "+num1+" : "+(num3/=num1));	//Division Assignment Operator
		Console.WriteLine("num3 %= "+num1+" : "+(num3%=num1));	//Modulus Assignment Operator

		// Unary Operators(+,-,++,--,!)
		Console.WriteLine("num3 = "+num3);			//Unary plus
		Console.WriteLine("num3 = "+ -num3);			//Unary minus
		Console.WriteLine("num3 = "+ ++num3);			//Pre-Increment Operator
		Console.WriteLine("num3 = "+ num3++);			//Post-Increment Operator
		Console.WriteLine("num3 = "+ --num3);			//Pre-Decrement Operator
		Console.WriteLine("num3 = "+ num3--);			//Post-Decrement Operator
		Console.WriteLine("Boolean Value 2 = "+ !val2);		//Logical Complement

		// Ternary Operator
		int maximum = (num1>num2)? num1:num2;  			//Ternary Operator
		Console.WriteLine("Maximum of the two numbers : "+maximum);

		// is Operator
		Console.WriteLine("num3 is int : "+(num3 is int));	//Checks if 'num3' is compatible with int	
		Console.WriteLine("num3 is double : "+(num3 is double));//Checks if 'num3' is compatible with double
	}
}