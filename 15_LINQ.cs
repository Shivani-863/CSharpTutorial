using System;
using System.Collections.Generic;

// LINQ -> Language Integrated Query

// Where Can LINQ Be Used?
// Arrays                   // Lists
// Dictionaries             // HashSets
// XML                      // Entity Framework
// SQL                      // APIs
// JSON collections

// If it's a collection, chances are LINQ can work with it.

// LINQ is mostly a collection of extension methods.
// An extension method allows you to "add" methods to an existing class without modifying the class.

// What Does IEnumerable Mean? - IEnumerable is an interface - IEnumerable<T>
// It means
// "This collection can be enumerated."
// In simpler words,
// You can iterate over it.

// # Deferred Execution in LINQ

// ## What is Deferred Execution?

// * LINQ queries are **not executed immediately**.
// * They execute **only when the results are enumerated** (e.g., `foreach`, `ToList()`, `Count()`, `First()`, etc.).

// Example:

// ```csharp
// var result = numbers.Where(n => n > 20);
// ```

// At this point, **no filtering has happened**.

// ---

// ## When does the query execute?

// The query executes when it is enumerated:

// ```csharp
// foreach (var item in result)
// {
//     Console.WriteLine(item);
// }
// ```

// ---

// ## Multiple Enumerations

// If you iterate over the same query multiple times:

// ```csharp
// foreach (var item in result) { }

// foreach (var item in result) { }
// ```

// * The `Where()` condition (lambda expression) is executed **again** for every element.
// * Each enumeration re-runs the query.

// ---

// ## Materializing the Query with `ToList()`

// ```csharp
// var result = numbers
//     .Where(n => n > 20)
//     .ToList();
// ```

// * `ToList()` forces **immediate execution**.
// * The filtering happens **only once**.
// * Subsequent loops iterate over the already-created `List<T>`.

// ---

// ## Why is `ToList()` Important?

// Use `ToList()` when:

// * You need to iterate over the results multiple times.
// * The query is expensive to execute.
// * You want a snapshot of the current data.

// ---

// ## Entity Framework Core

// ```csharp
// var users = context.Users.Where(u => u.IsActive);
// ```

// * No SQL query is executed yet.

// If you enumerate `users` multiple times:

// ```csharp
// foreach (var user in users) { }
// foreach (var user in users) { }
// ```

// * The database query is executed **each time** (unless the results have been materialized).

// Using:

// ```csharp
// var users = context.Users
//     .Where(u => u.IsActive)
//     .ToList();
// ```

// * Executes **one SQL query**.
// * All future operations use the in-memory list.

// ---

// ## Rule of Thumb

// * **Deferred Execution** → Executes every time the query is enumerated.
// * **`ToList()`** → Executes once and stores the results in memory.
// * If the query will be used multiple times, prefer `ToList()` to avoid repeated execution and improve performance.


 public class LINQExample
{
    public void TrialLinQ()
    {
        List<int>numbers=[1,2,3,4,5,6,7,8,9,10];
        List<int>Even=numbers.Where(n=> n%2==0).ToList();
        // n => n%2 == 0 is a lambda expression

        // var result =
        // names.Where(name => name.Length > 4);
        foreach(int num in Even)
        {
            Console.WriteLine(num);
        }
    }
}