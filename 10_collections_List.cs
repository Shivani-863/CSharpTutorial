//      Arrays	                         Collections
// Fixed size	                 Dynamic size
// Faster for fixed data	     More flexible
// Simple	                     Rich functionality
// Manual resizing	             Automatic resizing
// Limited methods	             Many built-in methods

// | Feature      | Array    | List<T>    |
// | ------------ | -------- | ---------- |
// | Size         | Fixed    | Dynamic    |
// | Property     | `Length` | `Count`    |
// | Resize       | Manual   | Automatic  |
// | Add new item | No       | `Add()`    |
// | Remove item  | No       | `Remove()` |


using System;
using System.Collections;
public class CollectionsList
{
    // Non-generic approach

    ArrayList arrayList=new ArrayList();
    // No type safety.
    // Casting is required.
    // More runtime errors.
    // Slower due to boxing/unboxing.

    // Generic approach
        //    Why Generics?
        // Type safety.
        // Better performance.
        // Better IntelliSense.
        // Cleaner code.

    // One way to create a generic collection is to use the List<T> class and initialize it 
    List<int>numbers=new List<int>
    {
        1,2,3,4,5
    };
    // Another way is to use the List<T> constructor and add elements using the Add method.
    // List<int>numbers=new List<int>();
    public void ListExample()
    {
    arrayList.Add(1);
    arrayList.Add("Hello");
    for (int i = 0; i < arrayList.Count; i++)
    {
        Console.WriteLine(arrayList[i]);
    }
    numbers.Add(1);
    numbers.Add(2);
    numbers.Add(3);
    numbers.AddRange(new int[] { 4, 5, 6 });
    numbers.AddRange(new List<int>{7,8,9});
    numbers.Insert(0, 0); // Insert 0 at index 0
    numbers.InsertRange(1, new int[] { 10, 11, 12 }); // Insert 10, 11, 12 starting at index 1
    Console.WriteLine("List elements:");
    foreach(int number in numbers)
        {
            Console.Write(number + " ");
        }
    numbers.Remove(5); // Will remove the first occurrence of 5

    numbers.RemoveAt(2); // Will remove the element at index 2
    
    numbers.RemoveAll(n => n == 3); // Will remove all occurrences of 3 from the list
    numbers.RemoveRange(3, 2); // Will remove 2 elements starting from index 3
    
    numbers.Contains(3); // Returns true if 3 is in the list 
    Console.WriteLine($"Does the list contain 3? {numbers.Contains(3)}");
    
    numbers.IndexOf(4); // Returns the index of the first occurrence of 4. If 4 is not found, it returns -1.
    Console.WriteLine($"Index of 4 is :{numbers.IndexOf(4)}");
    
    Console.WriteLine("List elements:");
    foreach(int number in numbers)
        {
            Console.Write(number + " ");
        }
    Console.WriteLine($"Size of the list is :{numbers.Count}");
    
    numbers.Clear(); // Will remove all elements from the list
    Console.WriteLine($"Size of the list after clearing is :{numbers.Count}");
    
    }
    

    public void Exercise()
    {
        List <string> students=new List<string>();
        students.Add("Alice");
        students.Add("Bob");
        students.Add("Charlie");
        students.Add("David");
        students.Add("Eve");
        Console.WriteLine("List of students:");
        foreach(string student in students)
        {
            Console.WriteLine(student);
        }
        students.Insert(2, "Frank"); // Insert "Frank" at index 2
        students.Remove("Charlie"); // Remove "Charlie" from the list
        students.RemoveAt(0); // Remove the student at index 0
        students.Contains("Eve"); // Returns true if "Eve" is in the list
        Console.WriteLine($"Does the list contain Eve? {students.Contains("Eve")}");
        Console.WriteLine($"Number of students in the list: {students.Count}");
        Console.WriteLine("List of students after inserting Frank at index 2:");    
       foreach(string student in students)
          {
            Console.WriteLine(student);
          }
    }
}