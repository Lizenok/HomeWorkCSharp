/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

int xa = GetNumberFromUser("Введите Xa:");
int ya = GetNumberFromUser("Введите Ya:");
int za = GetNumberFromUser("Введите Za:");
int xb = GetNumberFromUser("Введите Xb:");
int yb = GetNumberFromUser("Введите Yb:");
int zb = GetNumberFromUser("Введите Zb:");

CountDistance(xa, ya, za, xb, yb, zb);

int GetNumberFromUser(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void CountDistance(int xa, int ya, int za, int xb, int yb, int zb)
{
    double distance = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
    Console.WriteLine($"Расстояние между двумя точками в пространстве равно {distance}");
}
