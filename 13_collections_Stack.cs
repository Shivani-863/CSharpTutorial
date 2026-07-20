using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;

public class StackExample
{
    public void Exercise()
    {
        Stack<string> pages=new Stack<string>();
        pages.Push("Google");
        pages.Push("Youtube");
        pages.Push("Github");
        pages.Push("Stack Overflow");
        Console.WriteLine(pages.Peek());
        Console.WriteLine(pages.Pop());
        Console.WriteLine(pages.Pop());
        Console.WriteLine(pages.Peek());
        foreach( string page in pages)
        {
            Console.WriteLine(page);
        }
        Console.WriteLine(pages.Count);
    }
}