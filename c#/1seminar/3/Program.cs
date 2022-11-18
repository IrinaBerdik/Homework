/* Напишите программу, которая на вход принимает число (N),
 а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());
for (int a=2; a<=N; a+=2)
   {
     Console.Write(a);
     Console.Write(" ");
    }
