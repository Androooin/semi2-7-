/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

*/

double[,] Create2dArray()
{
    Console.WriteLine("Write count of rows");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Write count of colums");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

   double[,] cr2dArray = new double[rows, colums];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            cr2dArray[i, j] = new Random().Next(-99, 99)/ 10.0;
        }
    }
    return cr2dArray;
}

void Print2dArray(double [,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array2d.GetLength(1)-1; j++)
        {
            Console.Write(array2d [i,j] + ", ");
        }
        Console.WriteLine($"{array2d [i,array2d.GetLength(1)-1]}]");
       
    }
    Console.WriteLine();
}

void Lutsenko()
{
    Console.WriteLine("The author of the work - Lutsenko A.S.");
}



double [,] new2dArray = Create2dArray();
Print2dArray(new2dArray);
Lutsenko();
