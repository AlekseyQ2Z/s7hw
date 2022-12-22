// Напишите программу, которая на вход принимает позиции (два индекса) 
// элемента в двумерном массиве, и возвращает значение этого элемента или 
// же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет

void FillArray(int[,] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = random.Next(1, 10);
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void SearchingByIndex(int[,] arr)
{
    int maxRowIndex = arr.GetLength(0) - 1;
    int maxColumnIndex = arr.GetLength(1) - 1;
    Console.WriteLine("Введите индекс строки массива от 0 до " + maxRowIndex + ": ");
    int rowIndex = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите индекс столбца массива от 0 до " + maxColumnIndex + ": ");
    int columnIndex = Convert.ToInt32(Console.ReadLine());
    if (rowIndex < 0 || columnIndex < 0)
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
    else if (rowIndex <= maxRowIndex && columnIndex <= maxColumnIndex)
    {
        Console.WriteLine("Число с индексом [" + rowIndex + ", " + columnIndex + "] - > "
        + arr[rowIndex, columnIndex]);
    }
    else
    {
        Console.WriteLine("Такого числа в массиве нет");
    }

}

int rowCount = 3;
int columnCount = 4;
int[,] array = new int[rowCount, columnCount];

FillArray(array);

PrintArray(array);

SearchingByIndex(array);