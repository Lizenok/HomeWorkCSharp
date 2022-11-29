/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.WriteLine("Введите число равное колличеству вводимых чисел");
int M = Convert.ToInt32(Console.ReadLine());
int[] arrayOfUserNumbers = fillingArray(M);
printArray(arrayOfUserNumbers);
int countOfPozitivNumbers = countingPozitivNumbers(arrayOfUserNumbers);
Console.WriteLine($"Количество положительных чисел пользователя = {countOfPozitivNumbers}");


int[] fillingArray(int arrayLength)
{
  int[] array = new int[arrayLength];
  for (int i = 0; i < arrayLength; i++)
  {
    Console.WriteLine("Введите число");
    array[i] = Convert.ToInt32(Console.ReadLine());
  }
  return array;
}

int countingPozitivNumbers(int[] countOfNumbers)
{
    int count = 0;
    for (int i = 0; i < countOfNumbers.Length; i++)
    {
        if(countOfNumbers[i] > 0)
        count ++;
    }
    return count;
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine();
}