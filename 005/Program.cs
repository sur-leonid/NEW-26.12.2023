// Задача 5. С клавиатуры вводятся три числа. Найти максимальное из трех чисел
int a = 1;
int b = 2;
int с = 2;
int max = a;

System.Console.Write("Введите a:");
a=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите b:");
b=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите с:");
с=Convert.ToInt32(Console.ReadLine());
if (a > max ) max = a;
if (b > max ) max = b;
if (с > max ) max = с;

Console.Write ( "max из введенных чисел = " );
Console.WriteLine( max );