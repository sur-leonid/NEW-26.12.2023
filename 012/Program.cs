﻿//Задача 12. С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа
int n=0;
System.Console.WriteLine("Введите число от 10 до 99:");
n=Convert.ToInt32(Console.ReadLine());

int d0,d1;
d0=n%10;  // находим значение самой последней (тут вторуой) цифры в числе  (остаток деления на 10)
d1=(n-n%10)/10;// можно  d1=n/10%10; находим 

int max = 0;
if (d0 > max ) max = d0;
if (d1 > max ) max = d1;
//Console.Write ( "наибольшая цифра введенного чисела = " );
//Console.WriteLine( max );
System.Console.WriteLine($"наибольшая цифра введенного числа = {max}");
