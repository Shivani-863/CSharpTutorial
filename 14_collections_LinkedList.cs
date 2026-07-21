using System;
using System.Collections.Generic;

public class LinkedListExample
{
    public void Exercise()
    {
        LinkedList<string> names = new LinkedList<string>();
        names.AddFirst("Bob");
        names.AddLast("Chalie");
        names.AddLast("David");
        names.AddFirst("Alice");
        Console.WriteLine(names.Find("Charlie"));
        LinkedListNode<string> charlie = names.Find("Charlie");
        names.AddAfter(charlie,"Eve");
        names.AddBefore(charlie,"John");
        names.Remove("Bob");

        foreach( string name in names)
        {
            Console.Write($"{name} -> ");
        }
        Console.WriteLine(names.First.Value);
        Console.WriteLine(names.Last.Value);


    }
}