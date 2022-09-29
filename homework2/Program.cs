/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка */




int [ , ] matrix =new int [3,4];
FillArray(matrix);
System.Console.WriteLine();
PrintArray(matrix);



void PrintArray( int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        System.Console.Write($"{matr[i,j]} ");
    }
System.Console.WriteLine();
}
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] =new Random().Next (1,10);
        }
    }
}

int sumStr = 0;
int minSumStr = 0;
int numStr = 0;
for (int i = 0; i < matrix.GetLength(1); i++)
{
    minSumStr += matrix [0,i];    
}



for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++) sumStr += matrix[i, j];
    if (sumStr < minSumStr)
    {
        minSumStr = sumStr;
        numStr = i;
    }
}
Console.Write($"{numStr + 1} строка");

