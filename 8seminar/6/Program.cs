/*Задача 60. ...Сформируйте трёхмерный массив
 из неповторяющихся двузначных чисел. 
 Напишите программу, которая будет построчно 
 выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

Console.WriteLine("enter l, m, n");
int l = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

int[,,] GetArray(int l, int m, int n)
{
    int[,,] array = new int[l, m, n];
    Random rnd = new Random();
    for (int k=0; k<array.GetLength(0);k++)    
    {    
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(2); j++)
            {
                array[k,i,j] = rnd.Next(10,100);
                int e=array[k,i,j];
                for (int b =0; b<=k; b++)    
                {    
                    for (int c = 0; c <= i; c++)
                    {
                         for (int d = 0; d <j ; d++)
                        {                
                            if (array [b,c,d]== array[k,i,j]) 
                            array[k,i,j] = rnd.Next(10,100);
                            else array [k,i,j]=e;
                         }
                    }
                }
            }   
        }
    }
 return array;
}
    
    /*for (k=0; k<array.GetLength(0);k++)    
    {    
        for (i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(2); j++)
            {                
                if (a == array[i,j,k]) 
                a = rnd.Next(0,100);
                i=i-1; k=k-1; j=j-1;
            }
        }
    }*/
              
    
    



void PrintArray(int[,,] array)
{  
    for (int k=0; k<array.GetLength(2);k++)    
    {    
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console .Write (array [i,j,k]+" (" + i + j +k+ " )");
                
            }
            Console.WriteLine();
        }
    } 
}

PrintArray(GetArray(l,m,n));
