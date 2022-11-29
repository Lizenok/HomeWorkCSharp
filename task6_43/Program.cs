/*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

Console.WriteLine("Введите b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2");
double k2 = Convert.ToDouble(Console.ReadLine());
double[] intersectionPoint = findingTheIntersectionOfLines(k1, b1, k2, b2);
printArray(intersectionPoint);

double[] findingTheIntersectionOfLines (double k1, double b1, double k2, double b2)
{
    double[] A = new double[2];
    double x = (b1 - b2) / (k2 - k1);
    double y = (((b1 - b2) / (k2 - k1)) * k1) + b1;
    A[0] = x;
    A[1] = y;
    return A;
}

void printArray(double[] array)
{
    Console.Write("(");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(";");
        }
    }
    Console.WriteLine(")");
}