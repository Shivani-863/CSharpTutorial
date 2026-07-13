using System;
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
}