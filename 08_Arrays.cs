using System;

// Arrays have a fixed size.
// Arrays are zero-indexed.
// Use .Length to get the number of elements.
// The last valid index is Length - 1.
// Accessing an invalid index throws an IndexOutOfRangeException.
// Arrays are reference types, so assigning one array variable to another copies the reference, not the data.
// Use Array.Sort, Array.Reverse, Array.Copy, and Array.IndexOf when appropriate.

public class Arrays
{
    public void ArrayExample()
    {
        int[] numbers={1,2,3,4,5};
        Console.WriteLine("Array elements:");
        foreach(int number in numbers)
        {
            Console.WriteLine(number);
        }
    }

    public void MultiDimensionalArrayExample()
    {
        int[,] matrix={{1,2,3},{4,5,6},{7,8,9}};
        Console.WriteLine("Multi-dimensional array elements:");
        for(int i=0;i<3;i++)
        {
            for(int j=0;j<3;j++)
            {
                Console.Write(matrix[i,j]+" ");
            }
            Console.WriteLine();
        }
    }

    public void JaggedArrayExample()
    {
        int[][] jaggedArray=new int[3][];
        jaggedArray[0]=new int[]{1,2};
        jaggedArray[1]=new int[]{3,4,5};
        jaggedArray[2]=new int[]{6};

        Console.WriteLine("Jagged array elements:");
        for(int i=0;i<jaggedArray.Length;i++)
        {
            for(int j=0;j<jaggedArray[i].Length;j++)
            {
                Console.Write(jaggedArray[i][j]+" ");
            }
            Console.WriteLine();
        }
    }

    public void ArrayMethods()
    {
        int[] numbers={5,3,8,1,2};
        Console.WriteLine("Original array:");
        foreach(int number in numbers)
        {
            Console.Write(number+" ");
        }
        Console.WriteLine();

        Array.Sort(numbers);
        Console.WriteLine("Sorted array:");
        foreach(int number in numbers)
        {
            Console.Write(number+" ");
        }
        Console.WriteLine();

        Array.Reverse(numbers);
        Console.WriteLine("Reversed array:");
        foreach(int number in numbers)
        {
            Console.Write(number+" ");
        }
        Console.WriteLine();

        int index=Array.IndexOf(numbers,3);
        Console.WriteLine($"Index of 3: {index}");

        int[] copy=new int[5];
        Array.Copy(numbers,copy,numbers.Length);
        Console.WriteLine("Copied array:");
        foreach(int number in copy)
        {
            Console.Write(number+" ");
        }
        Console.WriteLine();
        Array.Clear(copy,0,copy.Length);
        Console.WriteLine("Cleared array:");   
        foreach(int number in copy)
            {
                Console.Write(number+" ");
            }
        Console.WriteLine();
        Array.Resize(ref copy,10);
        // ref keyword is used to pass the array by reference, allowing the method to modify the original array.
        // If ref was not used, the method would only modify a copy of the array, and the original array would remain unchanged.
        Console.WriteLine("Resized array:");
        foreach(int number in copy)
        {
            Console.Write(number+" ");
        }
        Console.WriteLine();
    }
}