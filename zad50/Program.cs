/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
*/

int[,] Create2dArray()
{
    Console.WriteLine("Write count of rows");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Write count of columns");
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

void FoundDigit(int[,] array2d)
{
    Console.WriteLine("What rows digit are we founding");
    int rDigit = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("What colums digit are we founding");
    int cDigit = Convert.ToInt32(Console.ReadLine());
    if (rDigit > array2d.GetLength(0))
    {
        Console.WriteLine($"{rDigit} -> not exist");
    }
    else if (cDigit > array2d.GetLength(1))
    {
        Console.WriteLine($"{cDigit} -> not exist");
    }
    else
    {
        Console.WriteLine($"Your digit is {array2d[rDigit, cDigit]}");
    }
}


void Lutsenko()
{
    Console.WriteLine("The author of the work - Lutsenko A.S.");
}



int[,] new2dArray = Create2dArray();
Print2dArray(new2dArray);
FoundDigit(new2dArray);
Lutsenko();
