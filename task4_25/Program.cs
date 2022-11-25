/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int getNumberFromUser(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int RiseIntoPower(int num, int power)
{
    int proizvod = 1;
    for (int i = 1; i <= power; i++)
    {
        proizvod *= num;
    }
    return proizvod;
}

int userNumberA = getNumberFromUser("Введите число А");
int userNumberB = getNumberFromUser("Введите число В");
int proizvod = RiseIntoPower(userNumberA, userNumberB);
Console.WriteLine($"Число {userNumberA} в степени {userNumberB} = {proizvod}");