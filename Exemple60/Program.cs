// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//  Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
int GetNumber(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int number = Convert.ToInt32(value);
    return number;
}

void FillArray(int[,,] array)
{
    int r = array.GetLength(0);
    int c = array.GetLength(1);
    int p = array.GetLength(2);
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            for (int k = 0; k < p; k++)
                array[i, j, k] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,,] array)
{
    int r = array.GetLength(0);
    int c = array.GetLength(1);
    int p = array.GetLength(2);
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            for (int k = 0; k < p; k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k})");
            }
            Console.WriteLine();
        }
    }
}

int r = GetNumber("Введите r массива ");
int c = GetNumber("Введите c массива ");
int p = GetNumber("Введите p массива ");
int[,,] array = new int[r, c, p];
FillArray(array);
PrintArray(array);
Console.WriteLine();
