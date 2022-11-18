/* Задача 50. Напишите программу, которая
на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание,
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */
Console.WriteLine("enter m, n for array"); ;
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
Console.WriteLine("enter k, l for element");
int k = int.Parse(Console.ReadLine());
int l = int.Parse(Console.ReadLine());
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

void FindElement (int [,] array, int k,int l)
{
    if (k<=array.GetLength(0) && l<=array.GetLength(1))
    {
        Console.Write(array [k-1,l-1]);
     }
    else Console.WriteLine("числа c такой позицией в массиве нет ");
}

FindElement(GetArray(m,n), k,l);
