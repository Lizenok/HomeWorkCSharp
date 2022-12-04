/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int[,,] array3D = generate3DArray(3, 3, 3);
print3DArray(array3D);


int[,,] generate3DArray(int length, int width, int hight)
{
    int[,,] array = new int[length, width, hight];
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < width; j++)
        {
            for (int k = 0; k < hight; k++)
            {
                int rnd;
                do
                {
                    rnd = new Random().Next(10, 100);
                }
                while (ArrayContainsElement(array, rnd));
                array[i,j,k] = rnd;
            }
        }
    }
    return array;
}

bool ArrayContainsElement(int[,,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i,j,k] == number)
                {
                    return true;
                }
            }
        }
    }
    return false;
}

void print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
              Console.Write($"{array[i, j, k]}({i}, {j}, {k}) {"\t"}");  
            }
        }
        Console.WriteLine();
    }
}

