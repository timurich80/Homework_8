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
PrintArray(matrix);
FillArray(matrix);
System.Console.WriteLine();
PrintArray(matrix);
System.Console.WriteLine();
OrderArrayLines(matrix);
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

void OrderArrayLines(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(1) - 1; k++)
        {
            if (array[i, k] < array[i, k + 1])
            {
                int temp = array[i, k + 1];
                array[i, k + 1] = array[i, k];
                array[i, k] = temp;
            }
        }
    }
    
    

}
}
int sumStr = 0;
int maxSumStr = 0;
int numStr = 0;


// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//   for (int j = 0; j < matrix.GetLength(1); j++)
//   {
//     sumStr = sumStr +  matrix [i,j];
//   }
//   if(maxSumStr < sumStr)
//   maxSumStr = sumStr;
//   numStr = i;
// }
int [] row = new int[matrix.GetLength(1)];
int result = 0;
for (int i = 0; i < matrix.GetLength(1); i++)
{
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        row[j] = sumStr +  matrix [i,j];
        System.Console.WriteLine(row[j]);
    }
    // row[j] = sumStr +  matrix [i,j];
    

System.Console.WriteLine(numStr);
}

/* PrintArray(matrix);
FillArray(matrix);
System.Console.WriteLine();
PrintArray(matrix);
System.Console.WriteLine();
OrderArrayLines(matrix);
PrintArray(matrix); */

