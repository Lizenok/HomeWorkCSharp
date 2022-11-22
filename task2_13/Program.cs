/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 645 -> 5 78 -> третьей цифры нет 32679 -> 6*/
Random randomGenerator = new Random();
int initialNumber = randomGenerator.Next();
if(initialNumber < 100)
{
    Console.WriteLine($"У числа {initialNumber} нет третьей цифры");
}
else
{
    int number = initialNumber;
    while (number >= 1000)
    {
        number = number / 10;
    }
    int result = number % 10;
    Console.WriteLine($"У числа {initialNumber} третья цифра {result}");
}
