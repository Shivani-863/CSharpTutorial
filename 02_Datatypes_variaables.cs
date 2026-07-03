using System;

// In enterprise applications:

// string is commonly used for names, emails, addresses, and IDs that aren't used for arithmetic.
// bool often represents status flags like isActive, isDeleted, or isEmailVerified.
// Choose the smallest appropriate type without sacrificing clarity. 
// For example, financial calculations often use decimal 
// instead of double to avoid floating-point precision issues. We'll cover decimal later.
public class Person
{
    public void DisplayDataTypes()
    {
        string name="Shivani";
        int age=23;
        // float height=5.0; // Gives an error:
        // Literal of type double cannot be implicitly converted to type 'float';
        //  use an 'F' suffix to create a literal of this type
        float height=5.0F;
        double weight=50;
        bool isStudent=true;
        char initial='O';
        Console.WriteLine($"Name:{name}, Age:{age}, Height:{height}, Weight:{weight}, IsStudent:{isStudent}, Initial:{initial}");
        //  camelCase is used for variable names, where the first letter of the first word
        //  is lowercase and the first letter of subsequent words is uppercase.
    }
}