/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

int StartIndex = getUserInt("Введите максимальный элемент ряда");
printRange(StartIndex);


int getUserInt(string message)
{
    Console.WriteLine(message);
    int userInt = Convert.ToInt32(Console.ReadLine());
    return userInt;
}

void printRange(int index)
{
    if (index != 0)
    {
        Console.Write(index);
        if (index > 1)
        {
            Console.Write(", ");
        }
        printRange(index - 1);
    }
} 
