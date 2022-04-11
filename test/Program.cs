using System;

class MainClass
{
	public static void Main(string[] args)
	{
        Random r = new Random();

		int[,] array = new int[2, 3];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j] = r.Next(-5,5);

            }
        }

        foreach (int row in array)
        {
            foreach (int column in array)
            {
                Console.Write(column+" ");
            }
            Console.WriteLine(row);
        }

    }
}