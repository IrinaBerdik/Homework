/* Напишите программу, которая найдёт точку
 пересечения двух прямых, заданных уравнениями
  y = k1 * x + b1, y = k2 * x + b2; 
  значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
Console.WriteLine("Введите b1, k1, b2 и k2");
int b1=int.Parse(Console.ReadLine());
int k1=int.Parse(Console.ReadLine());
int b2=int.Parse(Console.ReadLine());
int k2=int.Parse(Console.ReadLine());
void Tochka (int b1, int k1, int b2, int k2)
{
    if ((k1-k2)!=0)
        {
            int x=(b2-b1)/(k1-k2);
            int y=(k1*x+b1);
            Console.WriteLine(x,y);
        }
    else Console.WriteLine("Линии параллельны");
}
Tochka(b1, k1, b2, k2);
