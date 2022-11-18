/* Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа.
456 -> 5    782 -> 8    918 -> 1 */

Console.WriteLine("Введите трехзначное число");
int a = int.Parse(Console.ReadLine());
if (a > 99 && a < 1000)
{
    int second = a%100/10;
    System.Console.WriteLine(second);
}
else System.Console.WriteLine("введено не трехзначное число");
