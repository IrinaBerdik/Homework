/* Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию
элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
Console.WriteLine("enter m, n");
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
int [,] SortArray (int [,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1)-1; j++)
        {
            int maxPosition = j;
            for (int m=j+1; m<array.GetLength(1); m++)
            {
                if (array[i,m]>array[i,maxPosition]) maxPosition=m;
            }
            int temp = array[i,j];
            array[i,j]=array[i,maxPosition];
            array[i,maxPosition]=temp;
        }
    } 
return array;   
}

int [,] numbers = GetArray(m,n);
PrintArray(numbers);
Console.WriteLine();
PrintArray(SortArray(numbers));
