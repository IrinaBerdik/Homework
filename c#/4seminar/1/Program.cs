/*  Напишите цикл, который принимает на вход
 два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
Console.WriteLine("Введите два числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
/*if (n>0) Console.Write(Math.Pow(a,n));
else Console.Write(Math.Pow(a,-n));*/
void AvStepeniB (int a, int b)
{   int stepen = 1;
    int c;
    if (b<0) c=-b;
    else c = b;
        for (int n=1; n <= c; n++)
        {
        stepen = stepen * a;
        }
Console.Write("А в натуральной степени Б="+stepen);
}
AvStepeniB (a, b);

