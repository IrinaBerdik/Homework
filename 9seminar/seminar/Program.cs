/*using System.Text;

StringBuilder GetNumbers(int i, StringBuilder sb = null)
{
	if (sb is null)
	{
		sb = new StringBuilder();
	}

	if (i == 1)
	{
		sb.Append(i.ToString() + " ");
		return sb;
	}

	GetNumbers(i - 1, sb);
	sb.Append(i.ToString() + " ");

	return sb;
}

Console.WriteLine(GetNumbers(5).ToString());

*/
/*
Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8

*/

System.Console.Write("Введите N ");
int N = int.Parse(Console.ReadLine());
int sum = 0;
int getNumbers(int N)
{
    if (N < 10)
    {
       
        return N;
    }
    else
    {
        return getNumbers(N/ 10)+N%10;
    }
  
}

Console.WriteLine(getNumbers(N));


//doubles[i] = Math.Round(random.Next(-10, 11) + random.NextDouble(), 2);
/* /*Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8*/
*/System.Console.Write("Введите N ");
int N = int.Parse(Console.ReadLine());

int getFactorial(int N)
{
    if (N == 1) 
    {
       
        return 1;
    }
    else 
    {
    return getFactorial(N-1)*N;
       
    }
} 
System.Console.WriteLine(getFactorial(N));
/*
System.Console.Write("Введите A ");
int A = int.Parse(Console.ReadLine());
System.Console.Write("Введите B ");
int B = int.Parse(Console.ReadLine());

int getPowAB(int A, int B)
{
        if (B == 1) 
        {
            
            return A;
        }
        else 
        {
        
        return getPowAB(A,B-1)*A;    
        }
   
} 
System.Console.WriteLine(getPowAB(A,B));*/

/* Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9

Console.WriteLine("enter m: ");
int m = int.Parse(Console.ReadLine());

int digitsSum(int N)
{
    if (N / 10 == 0) return N;
    return N % 10 + digitsSum(N / 10);
}

System.Console.WriteLine(digitsSum(m));

Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8

Console.WriteLine("enter A: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("enter B: ");
int B = int.Parse(Console.ReadLine());

int degreeNatural (int a, int b)
{
    if (b == 0) return a;
    return degreeNatural (a, b-1) * a;
}

System.Console.WriteLine(degreeNatural(A, B));*/


