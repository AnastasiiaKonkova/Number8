//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

/* 
int [,] CreateArray()
{   
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows ; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(1,11);
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j]+"  ");
        Console.WriteLine(" ");
    }
    Console.WriteLine();
}

void maxRows(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 1; j < array.GetLength(1); j++)
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

int[,] myArray = CreateArray();
Show2dArray(myArray);
maxRows(myArray);
Show2dArray(myArray);
*/

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
//любой массив.