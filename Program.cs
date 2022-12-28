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

void minRows(int[,] array)
{
    int minSum = 0, index = 0;
    for(int j = 0; j < array.GetLength(1); j++)
    {
        minSum+=array[0,j];
    }
    for(int i = 1; i < array.GetLength(0); i++)
    {
        int sumRow = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sumRow+=array[i,j];
        }
        if (sumRow < minSum)
        {
        minSum = sumRow;
        index = i;
        }
    }
    Console.Write($"Min sum - {minSum} in row - {index+1} ");
}

int[,] myArray = CreateArray();
Show2dArray(myArray);
minRows(myArray);
*/

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

/*
int [,] CreateArray(int rows, int columns)
{   
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(1,11);
    return array;
}

void ShowMatrix(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j]+"  ");
        Console.WriteLine(" ");
    }
    Console.WriteLine();
}

int [,] multiMatrix (int[,] array, int[,] array2)
{
    int [,] arrayC = new int[array.GetLength(0), array2.GetLength(1)];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array2.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(1); k++)
            {
                {
                    arrayC[i,j] += array [i,k] * array2 [k,j];
                }
            }
        }
    }
    return arrayC;
}

Console.Write("Input a number of rows matrix №1: ");
int rowsMatrix1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number of columns matrix №1: ");
int columnsMatrix1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number of rows matrix №2: ");
int rowsMatrix2= Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number of columns matrix №2: ");
int columnsMatrix2 = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateArray(rowsMatrix1,columnsMatrix1);
ShowMatrix(myArray);
int[,] myArray2 = CreateArray(rowsMatrix2,columnsMatrix2);
ShowMatrix(myArray2);

if (columnsMatrix1 != rowsMatrix2)
Console.Write("Error! Columns matrix №1 ≠ rows matrix №2");
else 
{
    Console.WriteLine("Final matrix:");
    int[,] myArray3 = multiMatrix(myArray,myArray2);
    ShowMatrix(myArray3);
}
*/

//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

/*
void show3DArray(int[,,] array)
{
    Console.WriteLine();
    for(int k = 0; k < array.GetLength(2); k++)
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
            Console.WriteLine(" ");
        }
    }
    Console.WriteLine();
}

int[] Array1D()
{
    int[]array = new int[100];
    for (int i = 10; i < array.Length; i++)
        {
        array[i] = i;
        }
    return array;
}  

void ShowArray(int[] array) // Для проверки одномерного массива.
{
    for (int i = 10;i < array.Length;i++ )
    {
        Console.Write(array[i]+" ");
    }
}

int [,,] Array3D(int[] arrayOne, int rows, int columns, int z)
{  
    int[,,] array = new int[rows, columns,z];
    for(int i = 0,n=10; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            for(int k = 0; k < z; k++)
            array[i,j,k] = arrayOne[n++];
        }
    }
    return array;
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number of z: ");
int z = Convert.ToInt32(Console.ReadLine());

int[] myArray = Array1D();
int[,,] myArray3D = Array3D(myArray, rows, columns, z);
show3DArray(myArray3D);
*/

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
//любой массив.