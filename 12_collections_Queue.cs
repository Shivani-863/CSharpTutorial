using System;
using System.Collections.Generic;

public class QueueExample
{
    public void Exercise()
    {
        Queue <string> Customers=new Queue<string>();
        Customers.Enqueue("John");
        Customers.Enqueue("Jessica");
        Customers.Enqueue("Bob");
        Customers.Enqueue("Alice");
        Customers.Enqueue("Jose");

        Console.WriteLine(Customers.Peek());
        Console.WriteLine(Customers.Dequeue());
        Console.WriteLine(Customers.Dequeue());
        foreach( string customer in Customers)
        {
            Console.WriteLine(customer);
        }
        Console.WriteLine(Customers.Count);
    }
}