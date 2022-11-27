/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int [] GetRange(int length, int randomFrom, int randomTo)
{
    int [] array = new int [length];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(randomFrom, randomTo);
    }
    return array;
}

void PrintArray(int [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

Console.WriteLine("Введите начало диапазона случайных чисел");
int randomFrom = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конец диапазона случайных чисел");
int randomTo = Convert.ToInt32(Console.ReadLine());

int [] array = GetRange(8, randomFrom, randomTo);
PrintArray(array);