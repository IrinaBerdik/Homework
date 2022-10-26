/*Задача 58: Задайте две матрицы. 
Напишите программу, которая будет 
находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18   */
Console.WriteLine("enter m1, n1");
int m1 = int.Parse(Console.ReadLine());
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("enter m2, n2");
int m2 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());

int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write($"{array[i,j]} ");
        }
       Console.WriteLine();
    } 
    
}

int [,] ProdArray (int[,] array1, int[,] array2)
{
    if (array1.GetLength(1)==array2.GetLength(0))
    {
        int [,] newArray = new int [array1.GetLength(1),array2.GetLength(0)];

        newArray[0,0]=(array1[0,0]*array2[0,0]+array1[0,1]*array1[1,0]+....



    }
    else Console.WriteLine("Не возможно перемножить матрицы");
}