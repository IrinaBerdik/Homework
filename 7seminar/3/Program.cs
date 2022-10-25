/* Задача 52. Задайте двумерный массив из целых чисел.
 Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

Console.WriteLine("enter m, n for array");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    } 
    return array;
}

void ArMeanColumn (int [,]array)
{   
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        double ArMean =1;
        for (int i = 0; i < array.GetLength(0); i++)
        {   
            sum = sum + array [i,j];
        }
        ArMean = sum/array.GetLength(0);
        Console.WriteLine($"ArMean "+ (j+1) + " column=" + ArMean);
    }
}

ArMeanColumn(GetArray(m,n));
