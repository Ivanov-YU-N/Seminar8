// Задача 56: Задайте прямоугольный двумерный массив.
//  Напишите программу, которая будет находить строку
//  с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт
// номер строки с наименьшей суммой элементов:
//  0 строка
int GetNumber(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int number = Convert.ToInt32(value);
    return number;
}

void FillArray(int[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($"{array[i, j]}");
        Console.WriteLine();
    }
}

void FillNewArray(int[,] array)
{
    int temp = 100000;
    int count = 0;
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        int sum = 0;
        for (int j = 0; j < column; j++)
        {
            sum += array[i, j];
        }
        Console.WriteLine($"{i}  {sum}");
        if (temp > sum)
        {
            temp = sum;
            count = i;
        }
    }
    Console.WriteLine();
    Console.Write($"Наименьшая сумма строки массива  {temp}  в строке №{count} ");
    Console.WriteLine();
}

int row = GetNumber("Введите количество строк массива ");
int column = GetNumber("Введите количество столбцов массива ");
int[,] array = new int[row, column];
FillArray(array);
PrintArray(array);
Console.WriteLine();
FillNewArray(array);
