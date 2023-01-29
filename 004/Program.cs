//  Задача 4.По заданному с клавиатуры номеру дня недели вывести его название
double a;
string s;
System.Console.Write("Введите номер дня недели:");
s = Console.ReadLine();
a = Convert.ToDouble(s);

if (a == 1)
System.Console.WriteLine("понедельник");
if (a == 2)
System.Console.WriteLine("вторник");
if (a == 3)
System.Console.WriteLine("среда");
if (a == 4)
System.Console.WriteLine("четверг");
if (a == 5)
System.Console.WriteLine("пятница");
if (a == 6)
System.Console.WriteLine("суббота");
if (a == 7)
System.Console.WriteLine("Ура! Воскресенье!");