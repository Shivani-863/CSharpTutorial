// Sample Employee class for sorting examples

// OrderBy()               -> Sorts in Ascending Order
// OrderByDescending()     -> Sorts in Descending Order
// ThenBy()                -> Secondary Ascending Sort
// ThenByDescending()      -> Secondary Descending Sort

// OrderBy() returns a NEW sorted sequence.
// It DOES NOT modify the original collection.

// Sorting is Deferred Execution.
// The query executes only when enumerated
// (foreach, ToList(), First(), Count(), etc.).

// Time Complexity:
// OrderBy() / OrderByDescending() -> O(n log n)

// IMPORTANT:
// ✔ Use ThenBy() after OrderBy() for secondary sorting.
// ❌ Do NOT call OrderBy() twice.
// The second OrderBy() starts a completely new sort and ignores the previous ordering.
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Salary { get; set; }
    public string Department { get; set; } = string.Empty;

    // OrderBy() -> Sorts data in Ascending Order
public void TrialOrderBy()
{
    List<Employee> employees = new()
    {
        new Employee { Id = 1, Name = "Alice", Salary = 60000, Department = "HR" },
        new Employee { Id = 2, Name = "Bob", Salary = 45000, Department = "IT" },
        new Employee { Id = 3, Name = "Charlie", Salary = 70000, Department = "Finance" },
        new Employee { Id = 4, Name = "David", Salary = 50000, Department = "HR" }
    };

    var sortedEmployees = employees.OrderBy(e => e.Salary);

    Console.WriteLine("Employees Sorted by Salary (Ascending):");

    foreach (var employee in sortedEmployees)
    {
        Console.WriteLine($"{employee.Name} - {employee.Salary}");
    }
}

// OrderByDescending() -> Sorts data in Descending Order
public void TrialOrderByDescending()
{
    List<Employee> employees = new()
    {
        new Employee { Id = 1, Name = "Alice", Salary = 60000, Department = "HR" },
        new Employee { Id = 2, Name = "Bob", Salary = 45000, Department = "IT" },
        new Employee { Id = 3, Name = "Charlie", Salary = 70000, Department = "Finance" },
        new Employee { Id = 4, Name = "David", Salary = 50000, Department = "HR" }
    };

    var sortedEmployees = employees.OrderByDescending(e => e.Salary);

    Console.WriteLine("Employees Sorted by Salary (Descending):");

    foreach (var employee in sortedEmployees)
    {
        Console.WriteLine($"{employee.Name} - {employee.Salary}");
    }
}

// ThenBy() -> Secondary Ascending Sort
public void TrialThenBy()
{
    List<Employee> employees = new()
    {
        new Employee { Id = 1, Name = "Charlie", Salary = 50000, Department = "HR" },
        new Employee { Id = 2, Name = "Alice", Salary = 50000, Department = "HR" },
        new Employee { Id = 3, Name = "David", Salary = 60000, Department = "IT" },
        new Employee { Id = 4, Name = "Bob", Salary = 60000, Department = "IT" }
    };

    var sortedEmployees = employees
        .OrderBy(e => e.Department)
        .ThenBy(e => e.Name);

    Console.WriteLine("Sorted by Department, then Name:");

    foreach (var employee in sortedEmployees)
    {
        Console.WriteLine($"{employee.Department} - {employee.Name}");
    }
}

// ThenByDescending() -> Secondary Descending Sort
public void TrialThenByDescending()
{
    List<Employee> employees = new()
    {
        new Employee { Id = 1, Name = "Charlie", Salary = 50000, Department = "HR" },
        new Employee { Id = 2, Name = "Alice", Salary = 50000, Department = "HR" },
        new Employee { Id = 3, Name = "David", Salary = 60000, Department = "IT" },
        new Employee { Id = 4, Name = "Bob", Salary = 60000, Department = "IT" }
    };

    var sortedEmployees = employees
        .OrderBy(e => e.Department)
        .ThenByDescending(e => e.Name);

    Console.WriteLine("Sorted by Department, then Name (Descending):");

    foreach (var employee in sortedEmployees)
    {
        Console.WriteLine($"{employee.Department} - {employee.Name}");
    }
}
}
