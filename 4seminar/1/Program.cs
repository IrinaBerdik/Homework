/*  Напишите цикл, который принимает на вход
 два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
Console.WriteLine("Введите два числа");
int a = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
if (n>0) Console.Write(Math.Pow(a,n));
else Console.Write(Math.Pow(a,-n));
