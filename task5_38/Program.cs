/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

double[] GenerateRandomArray(int length)
{
    double[] resultArray = new double[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().NextDouble();
    }
    return resultArray;
}

void printArray(double[] array)
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

double findDifferenceMinMax(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        }
        if(array[i] > max)
        {
            max = array[i];
        }
    }
    return max - min;
}


double[] array = GenerateRandomArray(5);
printArray(array);
double difference = findDifferenceMinMax(array);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {difference}");