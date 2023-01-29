// Задача1. С клавиатуры вводится целое число. Вывести квадрат числа (блок-схема)
string? s;
int a;
s=Console.ReadLine();
a=Convert.ToInt32(s);
Console.Write("квадрат числа ");
Console.Write(a);
Console.Write(" = ");
Console.WriteLine(a*a);
Console.WriteLine(Math.Pow(a,2)); // a  в квадрате c функцией
