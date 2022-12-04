/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

int countRowsOfMatrixA = getUserMatrix("Введите количество строк матрицы А");
int countColmsOfMatrixA = getUserMatrix("Введите количество столбцов матрицы А");
int countRowsOfMatrixB = getUserMatrix("Введите количество строк матрицы В");
int countColmsOfMatrixB = getUserMatrix("Введите количество столбцов матрицы В");

if (countColmsOfMatrixA != countRowsOfMatrixB)
{
    Console.WriteLine("Матрицы А и В не могут быть перемножены, т.к. не совместимы");
    return;
}
int[,] usersMatrixA = generateNumbsInMatrix(countRowsOfMatrixA, countColmsOfMatrixA, 10);
int[,] usersMatrixB = generateNumbsInMatrix(countRowsOfMatrixB, countColmsOfMatrixB, 10);
Console.WriteLine("Матрица А");
printMatrix(usersMatrixA);
Console.WriteLine("Матрица В");
printMatrix(usersMatrixB);
Console.WriteLine("Матрица С - результат умножения матриц А и В");
int[,] newMatrixC = matrixMultiplication(usersMatrixA, usersMatrixB);
printMatrix(newMatrixC);


int getUserMatrix(string message)
{
    Console.WriteLine(message);
    int userInt = Convert.ToInt32(Console.ReadLine());
    return userInt;
}

int[,] generateNumbsInMatrix(int countRow, int countCol, int deviation)
{
    int[,] array = new int[countRow, countCol];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countCol; j++)
        {
            array[i, j] = new Random().Next(1, deviation + 1);
        }
    }
    return array;
}

void printMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] matrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixC.GetLength(0); i++)
    {
        for (int j = 0; j < matrixC.GetLength(1); j++)
        {
           int sumOfMult = 0;
           for (int k = 0; k < matrixA.GetLength(1); k++)
           {
            sumOfMult = sumOfMult + matrixA[i, k] * matrixB[k, j];
           } 
            matrixC[i, j] = sumOfMult;
        }
    }
    return matrixC;
}

