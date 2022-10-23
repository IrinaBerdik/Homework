/*Напишите программу, которая задаёт массив
 из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/


void FillArray(int[] numbers)
{
    int length = numbers.Length;
    int index=0;
    while (index<length)
    {
        numbers[index]=new Random().Next(1,100);
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
int[] array=new int[8];
FillArray(array);
PrintArray(array);

