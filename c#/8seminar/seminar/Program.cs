

/* Console.WriteLine("enter m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("enter n: ");
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

void ChangeArray (int[,] array)
{    
        for (int j = 0; j < array.GetLength(1); j++)
        {
           int i =0;
           int m = array.GetLength(0)-1;
           int n = array.GetLength(1)-1;
           int d = array[i,j];
           array[i,j]=array[m,j];
           array[m,j]=d;
           Console.Write($"{array[i,j]} ");
        }
       Console.WriteLine();
   
}


ChangeArray(GetArray(m,n));
PrintArray(arr) */

/*
int[,] UpdateArray(int[,] array)
{
	int[,] newArray = new int[array.GetLength(1), array.GetLength(0)];

	if (array.GetLength(1) != array.GetLength(0))
	{
		throw new ArgumentException("Thiw array can't be reversed");
	}

	for (int i = 0; i < array.GetLength(1); i++)
	{
		int[] column = CopyColumn(array, i);

		AddRowToArray(array, newArray, column, i);
	}



	return newArray;
}

int[] CopyColumn(int[,] array, int columnNumber)
{
	int[] coulumn = new int[array.GetLength(0)];

	for (int i = 0; i < coulumn.Length; i++)
	{
		coulumn[i] = array[columnNumber, i];
	}

	return coulumn;
}

void AddRowToArray(int[,] originArray, int[,] copiedArray, int[] row, int rowNumber)
{
	for (int i = 0; i < originArray.GetLength(0); i++)
	{
		copiedArray[i, rowNumber] = row[i];
	}
}

int[,] CreateArray(int m, int n)
{
	int[,] array = new int[m, n];

	Random random = new Random();

	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			array[i, j] = random.Next(1, 20);
		}
	}

	retur
    */
/*/*Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 4 2
2 2 6
3 4 7*/

// исключить столбец строку
int[,] RemoveMinColumnsAndRowsFromArray(int[,] array)
{
	int min = 0;
	int min_x = 0;
	int min_y = 0;

	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			if (array[i, j] < min)
			{
				min = array[i, j];
				min_x = i;
				min_y = j;
			}
		}
	}

	int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

	for (int i = 0; i < result.GetLength(0); i++)
	{
		for (int j = 0; j < result.GetLength(1); j++)
		{
			if (i != min_x || j != min_y)
			{
				result[i, j] = array[i, j];
			}
		}
	}

	return result;
}





