using System;

public class Methods
{
    public void GreetUser(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }

    public int AddNumbers(int a, int b)
    {
        return a + b;
    }

    public void DisplayMessage(string message="Default message")
    {
        Console.WriteLine(message);
    }

    public void Swap(ref int x, ref int y)
    {
        int temp=x;
        x=y;
        y=temp;
    }

    // Mthod inside a method
    public void OuterMethod()
    {
        Console.WriteLine("This is the outer method.");
        void InnerMethod()
        {
            Console.WriteLine("This is the inner method.");
        }
        InnerMethod();
    }

// Method overloading
    public double Add(double a, double b)
    {
        return a + b;
    }

// out keyword- Used to return multiple values from a method
    public void GetValues(out int a, out int b)
    {
        a=10;
        b=20;
    }

// | `ref`                                               | `out`                                                        |
// | --------------------------------------------------- | ------------------------------------------------------------ |
// | Variable must be initialized before passing.        | Variable does **not** need to be initialized before passing. |
// | Method may or may not modify it.                    | Method **must** assign a value before returning.             |
// | Used when passing an existing value to be modified. | Used when the method's purpose is to produce output values.  |

}