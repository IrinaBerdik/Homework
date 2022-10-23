/* Напишите программу, которая принимает на вход пятизначное
 число и проверяет, является ли оно палиндромом*/
Console.WriteLine("Введите пятизначное число");
string num = Console.ReadLine();
int number = int.Parse(num);
if (number>1000 && number <100000)  
    if (num [4] == num [0] && num [3] == num [1])   
        {
         Console.WriteLine("Pallindrom");
     
        }
    else Console.WriteLine("no Pallindrom");
else Console.WriteLine("число не является пятизначным");


