using System;

class DataTypes
{
	static void Main()
	{
		// Primitive Data Types :
		// byte, int, short, long, float, double, char, bool

		// Type conversion from byte  to other data types
		byte num1=89;
		short byte_to_short = num1;      	// implicit type conversion
	        int byte_to_int = num1;           	// implicit type conversion
        	long byte_to_long = num1;         	// implicit type conversion
        	float byte_to_float = num1;       	// implicit type conversion
        	double byte_to_double = num1;     	// implicit type conversion
		byte int_to_byte = (byte)num1;  	// explicit type conversion
        	char byte_to_char = (char)num1;  	// explicit type conversion
		Console.WriteLine("num1 (byte) = " + num1);
        	Console.WriteLine("byte_to_short = " + byte_to_short);
        	Console.WriteLine("byte_to_int = " + byte_to_int);
        	Console.WriteLine("byte_to_long = " + byte_to_long);
        	Console.WriteLine("byte_to_float = " + byte_to_float);
        	Console.WriteLine("byte_to_double = " + byte_to_double);
        	Console.WriteLine("int_to_byte = " + int_to_byte);
        	Console.WriteLine("byte_to_char = " + byte_to_char);

		// Type conversion from short to other data types
		short num2=768;
		int short_to_int = num2;          		// implicit type conversion
        	long short_to_long = num2;        		// implicit type conversion
        	float short_to_float = num2;      		// implicit type conversion
        	double short_to_double = num2;    		// implicit type conversion
        	short int_to_short = (short)num2;       	// explicit type conversion
		Console.WriteLine("num2 (short) = " + num2);
        	Console.WriteLine("short_to_int = " + short_to_int);
        	Console.WriteLine("short_to_long = " + short_to_long);
        	Console.WriteLine("short_to_float = " + short_to_float);
        	Console.WriteLine("short_to_double = " + short_to_double);
        	Console.WriteLine("int_to_short = " + int_to_short);
		
		// Type conversion from int to other data types
		int num3=10000;
		long int_to_long = num3;          		// implicit type conversion
 	        float int_to_float = num3;        		// implicit type conversion
        	double int_to_double = num3;      		// implicit type conversion
        	byte int_to_byte2 = (byte)num3;   		// explicit type conversion
	        short int_to_short2 = (short)num3;		// explicit type conversion
        	char int_to_char = (char)num3;    		// explicit type conversion
		Console.WriteLine("num3 (int) = " + num3);
        	Console.WriteLine("int_to_long = " + int_to_long);
        	Console.WriteLine("int_to_float = " + int_to_float);
        	Console.WriteLine("int_to_double = " + int_to_double);
        	Console.WriteLine("int_to_byte2 = " + int_to_byte2);
        	Console.WriteLine("int_to_short2 = " + int_to_short2);
        	Console.WriteLine("int_to_char = " + int_to_char);

		// Type conversion from long to other data types
		long num4=1023932;
		float long_to_float = num4;       	// implicit type conversion
        	double long_to_double = num4;     	// implicit type conversion
        	int long_to_int = (int)num4;     	// explicit type conversion
        	short long_to_short = (short)num4; 	// explicit type conversion
        	byte long_to_byte = (byte)num4;    	// explicit type conversion
		Console.WriteLine("num4 (long) = " + num4);
        	Console.WriteLine("long_to_float = " + long_to_float);
        	Console.WriteLine("long_to_double = " + long_to_double);
        	Console.WriteLine("long_to_int = " + long_to_int);
        	Console.WriteLine("long_to_short = " + long_to_short);
        	Console.WriteLine("long_to_byte = " + long_to_byte);

		// Type conversion from float to other data types
		float num5=679.88f;
		double float_to_double = num5;    	// implicit type conversion
        	int float_to_int = (int)num5;     	// explicit type conversion
        	long float_to_long = (long)num5;  	// explicit type conversion
        	byte float_to_byte = (byte)num5;  	// explicit type conversion
		Console.WriteLine("num5 (float) = " + num5);
        	Console.WriteLine("float_to_double = " + float_to_double);
        	Console.WriteLine("float_to_int = " + float_to_int);
        	Console.WriteLine("float_to_long = " + float_to_long);
        	Console.WriteLine("float_to_byte = " + float_to_byte);

		// Type conversion from double to other data types
		double num6=60.75;
        	int double_to_int = (int)num6;    		// explicit type conversion
        	float double_to_float = (float)num6; 	// explicit type conversion
        	long double_to_long = (long)num6; 		// explicit type conversion
		Console.WriteLine("num6 (double) = " + num6);
        	Console.WriteLine("double_to_int = " + double_to_int);
        	Console.WriteLine("double_to_float = " + double_to_float);
        	Console.WriteLine("double_to_long = " + double_to_long);

		// Type conversion from character to other data types
		char ch='A';
        	int char_to_int = ch;             // implicit type conversion
        	long char_to_long = ch;           // implicit type conversion
        	double char_to_double = ch;       // implicit type conversion
	        char int_to_char2 = (char)66;     // explicit type conversion
		Console.WriteLine("ch (char) = " + ch);
        	Console.WriteLine("char_to_int = " + char_to_int);
        	Console.WriteLine("char_to_long = " + char_to_long);
        	Console.WriteLine("char_to_double = " + char_to_double);
        	Console.WriteLine("int_to_char2 = " + int_to_char2);
	}
}
		