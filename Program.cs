using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] arr = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
        int m = arr.GetLength(0);
        int n = arr.GetLength(1);


        Console.WriteLine("Массив:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Введите искомый элемент:");
        int x = int.Parse(Console.ReadLine());

        bool found = false;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (arr[i, j] == x)
                {
                    Console.WriteLine("Элемент {0} находится в ячейке [{1}, {2}]", x, i, j);
                    found = true;
                }
            }
        }

        if (!found)
        {
            Console.WriteLine("Такого элемента нет в массиве");
        }
    }
}
