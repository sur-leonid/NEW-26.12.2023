// Задача 3. С клавиатуры вводятся два числа a и b. Найти максимальное из них
int a = 1;
int b = 2;

int max = a;

System.Console.Write("Введите a:");
a=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите b:");
b=Convert.ToInt32(Console.ReadLine());

if (a > max ) max = a;
if (b > max ) max = b;


Console.Write ( "max из введенных чисел = " );
Console.WriteLine( max );