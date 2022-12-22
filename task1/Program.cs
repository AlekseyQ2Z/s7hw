// Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами. Тип данных для элементов выбрать double, 
// наличие ненулевой дробной части обязательно.
// m = 3, n = 4.
// 0.5 7.96 -2.78 -0.2
// 1.7 -3.3 8.574 -9.9
// 8.5 7.87 -7.1 9.15

void FillArrayDecimalNumbers(double[,] arr)
{
    int temp = 0;
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Convert.ToDouble(random.Next(-9999, 9999));
            temp = random.Next(1, 11);
            if (temp > 6)
            {
                arr[i, j] = arr[i, j] / 100;
            }
            else if (temp < 4)
            {
                arr[i, j] = arr[i, j] / 1000;
            }
            else
            {
                arr[i, j] = arr[i, j] / 10;
            }
        }
    }
}

void PrintArray(double[,] arr)
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

int m = 3;
int n = 4;
double[,] array = new double[m, n];

FillArrayDecimalNumbers(array);
PrintArray(array);