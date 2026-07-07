using System;
public class TypeCasting
{
    // Implicit Casting (Widening Conversion) -> Conversion from a smaller data type to a larger data type (e.g., int to double)
    public void ImplicitCasting()
    {
        int num=100;
        double doubleNum=num; // Implicit casting from int to double
        Console.WriteLine($"Implicit Casting: int {num} to double {doubleNum}");
        Console.WriteLine(doubleNum.GetType()); // Output: System.Double
    }
    // Explicit Casting (Narrowing Conversion) -> Conversion from a larger data type to a smaller data type (e.g., double to int)
    public void ExplicitCasting()
    {
        double doubleNum=9.78;
        int num=(int)doubleNum; // Explicit casting from double to int
        Console.WriteLine($"Explicit Casting: double {doubleNum} to int {num}");
        Console.WriteLine(num.GetType()); // Output: System.Int32
    }

    // Using Convert Class
    public void UsingConvertClass()
    {
        // string strNum="123gf";  // This will throw a FormatException
        string strNum="123";  // This is a valid integer string
        int num=Convert.ToInt32(strNum); // Convert string to int
        Console.WriteLine($"Using Convert Class: string \"{strNum}\" to int {num}");
        Console.WriteLine(num.GetType()); // Output: System.Int32
    }
 // Using Parse Method
    public void UsingParseMethod()
    {
        string strNum="456"; // This is a valid integer string
        int num=int.Parse(strNum); // Parse string to int
        Console.WriteLine($"Using Parse Method: string \"{strNum}\" to int {num}");
        Console.WriteLine(num.GetType()); // Output: System.Int32
    }

    // Using TryParse Method
    public void UsingTryParseMethod()
    {
        string strNum="789fgh"; // This is a valid integer string
        bool isParsed=int.TryParse(strNum, out int num); // Try to parse string to int
        if (isParsed)
        {
            Console.WriteLine($"Using TryParse Method: string \"{strNum}\" to int {num}");
            Console.WriteLine(num.GetType()); // Output: System.Int32
        }
        else
        {
            Console.WriteLine($"Failed to parse \"{strNum}\" to int.");
        }
    }

    public void Exercise()
    {
        int number=100;
        double doubleNumber=number;
        Console.WriteLine($"Implicit Casting: int {number} to double {doubleNumber}");
        double pi=3.14159;
        int intPie=(int)pi;
        Console.WriteLine($"Explicit Casting: double {pi} to int {intPie}");
        Console.WriteLine("Enter a decimal number:");
        string input=Console.ReadLine();
        bool isDecimal=double.TryParse(input, out double decimalNumber);
        if (isDecimal)
        {
            Console.WriteLine($"You entered a valid decimal number: {decimalNumber}");
            int intDecimal=(int)decimalNumber;
            Console.WriteLine($"Explicit Casting: double {decimalNumber} to int {intDecimal}");
        }
        else
        {
            Console.WriteLine("Invalid decimal number input.");
        }
    }

}