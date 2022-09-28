/* 
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 
*/
int i = ReadInt("Введите колличество строк: ");
int j = ReadInt("Введите колличество столбцов: ");

int[,] firstArray = new int[i,j];
int[,] secondArray = new int[j,j];
int[,] resultArray = new int[i,j];

FillArray(firstArray)
FillArray(secondArray)
PrintArray(firstArray)
PrintArray(secondArray)
PrintArray(resultArray)


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] =new Random().Next (1,10);
        }
    }
}

void PrintArray( int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] =new Random().Next (1,10);
        }
    }
System.Console.WriteLine();
}

