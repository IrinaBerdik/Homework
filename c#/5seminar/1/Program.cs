/*Задайте массив заполненный случайными положительными
 трёхзначными числами. Напишите программу, которая покажет
  количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

void FillArray(int[] numbers)
{
    int length = numbers.Length;
    int index=0;
    while (index<length)
    {
        numbers[index]=new Random().Next(100,1000);
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

int CountEven (int[] numbers)
{
    int count=0;
    for (int i=0; i < numbers.Length; i++)
    {
      if (numbers[i]%2 == 0)
      count=count+1;
    }
 return count;
}

int[] array=new int[8];
FillArray(array);
PrintArray(array);
Console.Write(CountEven (array));

