/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int getNumberFromUser(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int getNumberOfDigits(int number)
{
    int numberOfDigit = 0;
    while(number > 0)
    {
        number /= 10;
        numberOfDigit++;
    }
    return numberOfDigit;
}

int sumOfNumbers(int initialNumber)
{
    int numberOfDigit = getNumberOfDigits(initialNumber);
    int sum = 0;
    for (int pow = 0; pow < numberOfDigit; pow++)
    {
        int numbI = (initialNumber / Convert.ToInt32(Math.Pow(10, pow))) % 10;
        sum += numbI; 
    }
    return sum;
}

int userNumber = getNumberFromUser("Введите число");
int sum = sumOfNumbers(userNumber);
Console.WriteLine($"В числе {userNumber} сумма цифр = {sum}");





