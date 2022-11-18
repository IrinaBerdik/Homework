/*Задайте массив вещественных чисел. 
Найдите разницу между максимальным и 
минимальным элементов массива.
[3 7 22 2 78] -> 76*/


void FillArray(double[] numbers)
{
    int length = numbers.Length;
    int index=0;
    while (index<length)
    {
        numbers[index]=new Random().Next(-100,101);
        index++;
    }
}
void PrintArray(double [] numbers)
{
    int count=numbers.Length;
    int position =0;
    while (position<count)
    {
        Console.Write(numbers[position] + " ");
        position++;
    }
}


void MinMaxElement (double[] numbers)
{
    double Min = numbers[0];
    double Max =numbers[0];
    for (int i=1; i < numbers.Length; i++)
    {
      if (numbers[i] > Max) Max=numbers[i];
      else
            if (numbers[i] < Min) Min=numbers[i];
    }
    Console.WriteLine($"Max-Min="+(Max-Min));
}

double[] array=new double [10];
FillArray(array);
PrintArray(array);
MinMaxElement (array);

