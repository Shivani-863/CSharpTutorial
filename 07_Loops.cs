using System;
 public class Loopings
{
    public void ForLoopExample()
    {
        for (int i=0;i<5;i++)
        {
            Console.WriteLine($"Iteration {i+1}");
        }
    }

    public void WhileLoopExample()
    {
        int count=0;
        while (count<5)
        {
            Console.WriteLine($"Count: {count}");
            count++;
        }
    }

    public void DoWhileLoopExample()
    {
        int count=0;
        do
        {
            Console.WriteLine($"Count: {count}");
            count++;
        } while (count<5);
    }

    public void forEachLoopExample()
    {
        string[] fruits={"Apple","Banana","Cherry"};
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }

public void LoopingExercises()
{
// Numbers from 1 to 10.
for(int i=1;i<=10;i++)
{
    Console.WriteLine(i);
}
// Numbers from 10 to 1.
for(int i=10;i>=1;i--)
{
    Console.WriteLine(i);
}
// Even numbers from 2 to 20.
for(int i=2;i<=20;i+=2)
{
    Console.WriteLine(i);
}
// The multiplication table of 5:
for(int i=1;i<=10;i++)
{
    Console.WriteLine($"5 x {i} = {5*i}");
}
}
}