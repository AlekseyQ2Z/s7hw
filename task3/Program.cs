// Задайте двумерный массив из трехзначных целых чисел (не менее 100 элементов). 
// В каждом столбце найдите среднее арифметическое среди тех элементов, которые 
// являются палиндромами (если палиндромов нет, то среднее арифметическое считать 
// равным 0). Полученные средние арифметические занести в одномерный массив.
// Например, задан массив:
// 100 404 504 225
// 550 478 800 363
// 505 101 410 479
// => [505, 252.5, 0, 363 ]

void FillArray(int[,] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(100, 1000);
        }
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

void GetArraySpecificAverageAndPrint(int[,] arr)
{
    double[] array = new double[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        int countPalindrom = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            if (arr[j, i] / 100 == arr[j, i] % 10)
            {
                array[i] += arr[j, i];
                countPalindrom++;
            }
        }
        if (countPalindrom == 0)
        {
            array[i] = 0;
        }
        else
        {
            array[i] = Math.Round(array[i] / countPalindrom, 2);
        }
    }

    Console.WriteLine("Cреднее арифметическое среди палиндромов");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(array[i] + " ");
    }
}

int rowCount = 10;
int columnCount = 10;
int[,] array = new int[rowCount, columnCount];

FillArray(array);
PrintArray(array);
GetArraySpecificAverageAndPrint(array);