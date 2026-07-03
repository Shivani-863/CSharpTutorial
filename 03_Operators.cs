using System;
using System.Runtime.CompilerServices;

class Calculator
{
    public void PerformCalculations()
    {
        int num1=40;
        int num2=5;
        // Addition
        int sum=num1+num2;
        // Subtraction
        int difference=num1-num2;  
        // Multiplication
        int product=num1*num2;
        // Division
        int quotient=num1/num2;   // Int / Int = Int  Double/Int = Double

        // Modulo
        int remainder=num1%num2;

        Console.WriteLine($"Sum: {sum})");
        Console.WriteLine($"Difference: {difference}");
        Console.WriteLine($"Product: {product}");
        Console.WriteLine($"Quotient: {quotient}");
        Console.WriteLine($"Remainder: {remainder}");
    }

    // Comparison Operators
    public void CompareNumbers()
    {
        int a=10;
        int b=20;

        Console.WriteLine($"Is a equal to b? {a==b}");
        Console.WriteLine($"Is a not equal to b? {a!=b}");
        Console.WriteLine($"Is a greater than b? {a>b}");
        Console.WriteLine($"Is a less than b? {a<b}");
        Console.WriteLine($"Is a greater than or equal to b? {a>=b}");
        Console.WriteLine($"Is a less than or equal to b? {a<=b}");
    }

    // Logical Operators
    public void LogicalOperations()
    {
        bool isSunny=true;
        bool isWeekend=false;

        Console.WriteLine($"Is it sunny and weekend? {isSunny && isWeekend}");
        Console.WriteLine($"Is it sunny or weekend? {isSunny || isWeekend}");
        Console.WriteLine($"Is it not sunny? {!isSunny}");
    }

    // Assignment Operators
    public void AssignmentOperations()
    {
        int x=10;
        Console.WriteLine($"Initial value of x: {x}");

        x+=5; // x = x + 5
        Console.WriteLine($"After += 5, x: {x}");

        x-=3; // x = x - 3
        Console.WriteLine($"After -= 3, x: {x}");

        x*=2; // x = x * 2
        Console.WriteLine($"After *= 2, x: {x}");

        x/=4; // x = x / 4
        Console.WriteLine($"After /= 4, x: {x}");

        x%=3; // x = x % 3
        Console.WriteLine($"After %= 3, x: {x}");
    }

    // Increment and Decrement Operators
    public void IncrementDecrementOperations()
    {
        int y=5;
        Console.WriteLine($"Initial value of y: {y}");

        y++; // Increment by 1
        Console.WriteLine($"After increment, y: {y}");

        y--; // Decrement by 1
        Console.WriteLine($"After decrement, y: {y}");
    }
}