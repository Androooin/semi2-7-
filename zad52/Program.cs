/*
Задача 52. Задайте двумерный массив из целых чисел.
 Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3
*/

int[,] Create2dArray()
{
    Console.WriteLine("Write count of rows");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Write count of colums");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int[,] cr2dArray = new int[rows, colums];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            cr2dArray[i, j] = new Random().Next(1, 10);
        }
    }
    return cr2dArray;
}

void Print2dArray(int[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array2d.GetLength(1) - 1; j++)
        {
            Console.Write(array2d[i, j] + ", ");
        }
        Console.WriteLine($"{array2d[i, array2d.GetLength(1) - 1]}]");

    }
    Console.WriteLine();
}

void ArithmeticmeanRows(int[,] array2d)
{
    double result = 0.0;
    for (int j = 0; j < array2d.GetLength(1); j++)
    {
        for (int i = 0; i < array2d.GetLength(0); i++)
        {
            result = result + array2d[i, j];
        }
        Console.Write($"{result / array2d.GetLength(0)}   ");
        result = 0;
    }
Console.WriteLine();
}

void Lutsenko()
{
    Console.WriteLine("The author of the work - Lutsenko A.S.");
}



int[,] new2dArray = Create2dArray();
Print2dArray(new2dArray);
ArithmeticmeanRows(new2dArray);
Lutsenko();