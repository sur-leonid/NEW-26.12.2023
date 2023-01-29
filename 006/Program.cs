//  Задача 5.Написать программу вычисления значения функции y = sin(a). (Класс Math). 
string? s;
double a;

System.Console.Write("Введите число:");
s=Console.ReadLine();
a=Convert.ToDouble(s);

Console.Write("результат расчета функциии Math.Sin к числу ");
Console.Write(a);
Console.Write(" = ");

Console.WriteLine(Math.Sin(a)); // к введенной "а"  применена  функция Math.Sin
