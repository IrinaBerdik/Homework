/* Задачи с семинара */
Console.WriteLine("enter m: ");
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
PrintArray(GetArray(m,n));
/*int[,] array = new int[4, 5];



string ArrayToString(int[,] array)
{
	string result = string.Empty;

	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			result += $"{array[i, j]} ";
		}

		result += Environment.NewLine;
	}

*/
/*
int[,] array = new int[4, 5];



string ArrayToString(int[,] array)
{
	string result = string.Empty;

	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			result += $"{array[i, j]} ";
		}

		result += Environment.NewLine;
	}

	return result;
}
*/
/*
int[,] array = new int[5, 5];

int[,] UpdateArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		if ((i + 1) % 2 == 0)
		{
			for (int j = 0; j < array.GetLength(1); j++)
			{
				if ((j + 1) % 2 == 0)
				{
					array[i, j] = (int)Math.Pow(array[i, j], 2);
				}
			}
		}
	}

	return array;
}
*/
/*
int GetDiaganolSumm(int[,] array)
{
	int sum = 0;

	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			if (i == j)
				sum += array[i, j];
		}
	}

	return sum;
}
*/

