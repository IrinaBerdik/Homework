/* Задайте одномерный массив, заполненный
 случайными числами. Найдите сумму элементов,
  стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/


void FillArray(int[] numbers)
{
    int length = numbers.Length;
    int index=0;
    while (index<length)
    {
        numbers[index]=new Random().Next(0,10);
        index++;
    }
}
void PrintArray(int[] numbers)
{
    int count=numbers.Length;
    int position =0;
    while (position<count)
    {
        Console.Write(numbers[position] + " ");
        position++;
    }
}

int SumOddPosition (int[] numbers)
{
    int sum=0;
    for (int i=0; i < numbers.Length; i++)
    {
      if (i%2 == 1)
      sum=sum+numbers[i];
    }
 return sum;
}

int[] array=new int[5];
FillArray(array);
PrintArray(array);
Console.WriteLine(" ");
Console.WriteLine(SumOddPosition (array));
