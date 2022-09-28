/* 
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 
*/
Console.WriteLine("Введите колличество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] firstArray = new int[rows,column];
int[,] secondArray = new int[rows,column];
int[,] resultArray = new int[rows,column];

FillArray(firstArray);
FillArray(secondArray);
PrintArray(firstArray);
PrintArray(secondArray);
PrintArray(resultArray);


for (int i = 0; i < firstArray.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < firstArray.GetLength(1); k++)
        {
            resultArray[i, j] += firstArray[i, k] * secondArray[k, j];
        }
    }
}

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





