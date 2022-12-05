/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int NumberM = getUserInt("Введите значение М");
int NumberN = getUserInt("Введите значение N");
int resultOfAckermannFunction = functionAckerman(NumberM, NumberN);
Console.WriteLine($"Функция Аккермана ({NumberM}, {NumberN}) = {resultOfAckermannFunction}");

int getUserInt(string message)
{
    Console.WriteLine(message);
    int userInt = Convert.ToInt32(Console.ReadLine());
    return userInt;
}

int functionAckerman(int m, int n)
{
    if(m == 0)
    {
        return n + 1;
    }
    else if(m > 0 && n == 0)
    {
        return functionAckerman(m - 1, 1);
    }
    else
    {
        return functionAckerman(m - 1, functionAckerman(m, n - 1));
    }
}