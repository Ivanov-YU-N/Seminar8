// Задача 54: Задайте двумерный массив.
//  Напишите программу, которая упорядочит
//  по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
            Console.Write($"{array[i, j]}  ");
        Console.WriteLine();
    }
}

void FillNewArray(int[,] array)
{
    int temp = 0;
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int k = j + 1; k < column; k++)
            {
                if (array[i, j] < array[i, k])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

int row = GetNumber("Введите количество строк массива ");
int column = GetNumber("Введите количество столбцов массива ");
int[,] array = new int[row, column];
FillArray(array);
PrintArray(array);
Console.WriteLine();
FillNewArray(array);
PrintArray(array);
