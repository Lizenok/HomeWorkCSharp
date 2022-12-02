/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

Console.WriteLine("Введите количество строк массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = generate2DArray(m, n, 10);
print2dArray(matrix);
Console.WriteLine();
int[] arrayOfSums = findRowSums(matrix);
PrintArray(arrayOfSums);
int numberOfString = findMax(arrayOfSums) + 1;
Console.WriteLine($"Строка с наименьшей суммой:{numberOfString}");


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

int[] findRowSums(int[,] array)
{
    int[] result = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumOfElementsInLine = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumOfElementsInLine = sumOfElementsInLine + array[i, j];
        }
        result[i] = sumOfElementsInLine;
    }
    return result;
}

int findMax(int[] array)
{
    int minValue = array[0];
    int minIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minValue)
        {
            minValue = array[i];
            minIndex = i;
        }
    }
    return minIndex;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine();
}