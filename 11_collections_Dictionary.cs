using System;
using System.Collections.Generic;

public class Dictionaries
{
    // Dictionary<TKey, TValue>
    // Key -> Unique
    // Value -> Can be duplicated
    
    //A Dictionary<TKey, TValue> stores data as Key-Value pairs.
    //The key is unique, while the value can be duplicated.
    //The Dictionary<TKey, TValue> class is part of the System.Collections.Generic namespace.

//     | Operation   | Average Complexity |
// | ----------- | -----------------: |
// | Add         |               O(1) |
// | Find by Key |               O(1) |
// | Remove      |               O(1) |
// | ContainsKey |               O(1) |

    public void StudentMarks()
    {
        // Dictionary Initialization
        Dictionary<string, int> marks = new Dictionary<string, int>
        {
            { "Bob", 90 },
            { "Charlie", 78 },
            { "Smith", 99 }
        };

        Console.WriteLine("===== Initial Dictionary =====");

        foreach (KeyValuePair<string, int> student in marks)
        {
            Console.WriteLine($"{student.Key} : {student.Value}");
        }

        Console.WriteLine();

        // Accessing value using key
        Console.WriteLine($"Bob's Marks: {marks["Bob"]}");

        Console.WriteLine();

        // Adding a new key-value pair
        marks.Add("Alice", 95);

        Console.WriteLine("After Adding Alice:");

        foreach (KeyValuePair<string, int> student in marks)
        {
            Console.WriteLine($"{student.Key} : {student.Value}");
        }

        Console.WriteLine();

        // Updating an existing value
        marks["Charlie"] = 85;

        Console.WriteLine("After Updating Charlie's Marks:");

        foreach (KeyValuePair<string, int> student in marks)
        {
            Console.WriteLine($"{student.Key} : {student.Value}");
        }

        Console.WriteLine();

        // ContainsKey
        Console.WriteLine($"Contains Key 'Smith' : {marks.ContainsKey("Smith")}");

        // ContainsValue
        Console.WriteLine($"Contains Value 99 : {marks.ContainsValue(99)}");

        Console.WriteLine();

        // TryGetValue (Existing Key)
        if (marks.TryGetValue("Alice", out int aliceMarks))
        {
            Console.WriteLine($"Alice's Marks: {aliceMarks}");
        }
        else
        {
            Console.WriteLine("Alice not found.");
        }

        Console.WriteLine();

        // TryGetValue (Non-existing Key)
        if (marks.TryGetValue("Rahul", out int rahulMarks))
        {
            Console.WriteLine($"Rahul's Marks: {rahulMarks}");
        }
        else
        {
            Console.WriteLine("Rahul not found.");
        }

        Console.WriteLine();

        // Removing an element
        marks.Remove("Bob");

        Console.WriteLine("After Removing Bob:");

        foreach (KeyValuePair<string, int> student in marks)
        {
            Console.WriteLine($"{student.Key} : {student.Value}");
        }

        Console.WriteLine();

        // Count
        Console.WriteLine($"Total Students: {marks.Count}");

        Console.WriteLine();

        // Display only keys
        Console.WriteLine("Student Names:");

        foreach (string key in marks.Keys)
        {
            Console.WriteLine(key);
        }

        Console.WriteLine();

        // Display only values
        Console.WriteLine("Student Marks:");

        foreach (int value in marks.Values)
        {
            Console.WriteLine(value);
        }

        Console.WriteLine();

        // Safe update using ContainsKey
        if (marks.ContainsKey("Smith"))
        {
            marks["Smith"] = 100;
        }

        Console.WriteLine("After Updating Smith:");

        foreach (KeyValuePair<string, int> student in marks)
        {
            Console.WriteLine($"{student.Key} : {student.Value}");
        }

        Console.WriteLine();

        // Clear the Dictionary
        Dictionary<string, int> tempDictionary = new Dictionary<string, int>(marks);

        Console.WriteLine($"Temporary Dictionary Count Before Clear: {tempDictionary.Count}");

        tempDictionary.Clear();

        Console.WriteLine($"Temporary Dictionary Count After Clear: {tempDictionary.Count}");
    }
}