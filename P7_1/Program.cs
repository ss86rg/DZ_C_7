// Задача 1. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.

//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

int ReadInt(string massage)
{
    System.Console.WriteLine(massage);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray2d(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write($"{numbers[i, j]}\t");
        }
        Console.WriteLine();

    }
}

int[,] GenerateArray2d(int rows, int columns, int min, int max)
{
    int[,] numbers = new int[rows, columns];
    Random rnd = new Random();
    double min = 0;
    double max = 0;
    for (double i = 0; i < numbers.GetLength(0); i++)
    {
        for (double j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = rnd.Next(min, max + 1);
        }
    }
    return numbers;
}




int rows = ReadInt("Введите количество строк >");
int columns = ReadInt("Введите количество столбцов >");
double[,] array = GenerateArray2d(rows, columns, -0,9, 0,8);
PrintArray2d(array);