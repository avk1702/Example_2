using System;

public class MyProgram
{
    private static Random random = new Random();
    
    public static void Main(string[] args)
    {
        int size;
        
        size = 10;
        int[] col = new int[size];
        int index;
        
        index = 0;
        while (index < size)
        {
            col[index] = random.Next(10);
            Console.Write(col[index].ToString() + " ");
            index = index + 1;
        }
        int i;
        int j;
        
        i = 0;
        while (i < size)
        {
            j = 0;
            while (j < size - 1)
            {
                if (col[j] > col[j + 1])
                {
                    int temp;
                    
                    temp = col[j];
                    col[j] = col[j + 1];
                    col[j + 1] = temp;
                }
                j = j + 1;
            }
            i = i + 1;
        }
        index = 0;
        Console.WriteLine("");
        while (index < size)
        {
            Console.Write(col[index].ToString() + " ");
            index = index + 1;
        }
    }
}