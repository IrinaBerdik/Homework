/* Напишите программу, которая выводит третью цифру
 заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
if (a <100)
   Console.WriteLine("третьей цифры нет"); 
else
{
    int del = 10;
    if (a>999)
    {
        int c=a;
        for (c=a;c>999;) 
        {
           c =c/del;
           
        }
        Console.WriteLine(c%del);
      }
    else Console.WriteLine(a%10);
}
