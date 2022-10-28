/* Задача 62. Напишите программу, которая заполнит
 спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
Console.WriteLine("enter m");
int m = int.Parse(Console.ReadLine());


int[,] GetArray(int m)
{
    int[,] array = new int[m, m];
   int c=10;
   int j;

    
        int i=0; 
        for ( j = 0; j < m; j++)
        {
            array[ i, j] = c+1;
            c++;
        }
        j=m-1;
        for ( i = 1; i < m; i++)
        {
             array[ i, j] = c+1;
            c++;
        }
        i=m-1;
        for ( j = m-2; j >=0 ; j--)
        {
             array[ i, j] = c+1;
            c++;
        }
        j=0;    
        for (i = m-2; i > 0; i--)
        {
             array[ i, j] = c+1;
            c++;
        }

        i=1;
        for (j = 1; j < m-1; j++)
        {
             array[ i, j] = c+1;
            c++;
        }
        
         j=2;    
        for (i =2 ; i < m-1; i++)
        {
             array[ i, j] = c+1;
            c++;
        }
        i=2;
        for (j = 1; j > m-4; j--)
        {
             array[ i, j] = c+1;
            c++;
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

PrintArray(GetArray(m));
