/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

Console.WriteLine("Введите количество строк массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arrayOfElements = generate2DArray(m, n, 10);
print2dArray(arrayOfElements);
Console.WriteLine("Отсортированный массив");
arrayOrdering(arrayOfElements);
print2dArray(arrayOfElements);

int[,] generate2DArray(int countRow, int countCol, int deviation)
{
    int[,] array = new int[countRow, countCol];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countCol; j++)
        {
            array[i, j] = new Random().Next(-deviation, deviation + 1);
        }
    }
    return array;
}

void print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


void arrayOrdering(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int c = 0; c < array.GetLength(1) - 1; c++)
            {
                if (array[i, c] < array[i, c + 1])
                {
                    int buf = array[i, c + 1];
                    array[i, c + 1] = array[i, c];
                    array[i, c] = buf;
                }
            }
        }
    }
}

