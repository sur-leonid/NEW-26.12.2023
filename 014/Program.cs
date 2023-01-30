// Задача 14. С клавиатуры вводятся два числа a и b.
// Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.
double a, b;
string s;
System.Console.WriteLine("Введите число a:");
s = Console.ReadLine();
a = Convert.ToDouble(s);
System.Console.WriteLine("Введите число b :");
s = Console.ReadLine();
b = Convert.ToDouble(s);
double NUM = a % b;
if (a % b == 0)
    System.Console.WriteLine("a кратно b");
if (a % b != 0)
    System.Console.WriteLine($"остаток от деления  = {NUM}");