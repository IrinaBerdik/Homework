/* Задача 41: Пользователь вводит с клавиатуры
 M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */
Console.WriteLine("Введите число M");
int m = int.Parse(Console.ReadLine());

void Count (int m)
{
    Console.WriteLine("Введите М чисел");
    int [] array = new int[m]; 
    int count=0;
    for (int i =0; i<m; i++)
        {
            array[i]= int.Parse(Console.ReadLine());
            if (array[i]>0) count++;
        }
    Console.WriteLine("Количество положительных чисел=" + count);
}
Count(m);