int GetRandomNumberInRange(int start, int end)
{
    int result = 0;
    result = new Random().Next(start, end + 1);
    return result;
}
int GetToDigitNumber (int number)
{
    int second = (number % 100) / 10;
    return (second);
}
int randomNumber = GetRandomNumberInRange(100, 999);
int result = GetToDigitNumber (randomNumber);
Console.WriteLine($"У числа {randomNumber} вторая цифра {result}");