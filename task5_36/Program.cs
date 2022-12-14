/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] GenerateRandomArray(int length,int startPoint, int endPoint)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startPoint, endPoint + 1);
    }
    return resultArray;
}

void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}

int sumOfOddElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

int[] array1 = GenerateRandomArray(9,1,10);
printArray(array1);
int sumOfElements1 = sumOfOddElements(array1);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {sumOfElements1}");

int[] array2 = GenerateRandomArray(9,-10,10);
printArray(array2);
int sumOfElements2 = sumOfOddElements(array2);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {sumOfElements2}");