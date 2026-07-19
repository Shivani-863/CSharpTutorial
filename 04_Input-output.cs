using System;

public class InputOutput
{
    public void ReadAndWrite()
    {
        Console.WriteLine("Enter your name:");
        string name=Console.ReadLine(); // Reads a line of text from the console
        Console.WriteLine($"Hello, {name}! Welcome to C# programming.");
        Console.WriteLine("Enter your age:");
        int age=int.Parse(Console.ReadLine()); // Converts the input string to an integer
        Console.WriteLine($"You are {age} years old.");
        Console.WriteLine("Enter your city:");
        string city=Console.ReadLine();
        Console.WriteLine($"You live in {city}.");
        Console.WriteLine("Enter your height in meters (e.g., 1.75):");
        bool isValidHeight=double.TryParse(Console.ReadLine(), out double height); // Tries to convert the input string to a double
        if (isValidHeight)
        {
            Console.WriteLine($"Your height is {height} meters.");
        }
        else
        {
            Console.WriteLine("Invalid height input.");
        }
        Console.WriteLine("Do you love Om? (yes/no):");
        bool isGoodStudent=Console.ReadLine().ToLower()=="yes"; // Reads a line and checks if it equals "yes"
        Console.WriteLine($"Are you a good student? {isGoodStudent}");  
        // int number=Console.ReadLine(); // Compilation error
    }
}
