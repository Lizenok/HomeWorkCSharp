/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int NumberM = getUserInt("Введите значение М");
int NumberN = getUserInt("Введите значение N");

if (NumberM > NumberN) 
{ 
    int sumOfNumbers = getSumOfNumbers(NumberN, NumberM);
    Console.WriteLine($"Сумма чисел от {NumberM} до {NumberN} = {sumOfNumbers}");
} 
else 
{ 
    int sumOfNumbers = getSumOfNumbers(NumberM, NumberN); 
    Console.WriteLine($"Сумма чисел от {NumberM} до {NumberN} = {sumOfNumbers}");
}


int getUserInt(string message)
{
    Console.WriteLine(message);
    int userInt = Convert.ToInt32(Console.ReadLine());
    return userInt;
}

int getSumOfNumbers(int M, int N)
{
    if(M > N)
    {
        return 0;
    }
    return M + getSumOfNumbers(M + 1, N);
}
