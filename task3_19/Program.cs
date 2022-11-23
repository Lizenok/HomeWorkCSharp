/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.14212 -> нет 12821 -> да 23432 -> да*/
int GetRandomNumberInRange(int start, int end)
{
    return new Random().Next(start, end);
}

void IsPalindrom (int initialNumber)
{ 
    int number5 = initialNumber % 10; 
    int number4 = (initialNumber / 10) % 10;
    int number2 = (initialNumber / 1000) % 10;
    int number1 = initialNumber / 10000;

    if (number1==number5 && number2==number4)
    {
        Console.WriteLine($"Число {initialNumber} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {initialNumber} не является палиндромом");
    }
}
IsPalindrom(GetRandomNumberInRange(10_000, 100_000));
IsPalindrom(57575);