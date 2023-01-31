// Задача 20. Дано число. Проверить кратно ли оно 7 и 23
double a; 
double b=7;
string s;
System.Console.WriteLine("Введите число a:");
s = Console.ReadLine();
a = Convert.ToDouble(s);

if (a % b == 0)
    System.Console.WriteLine($"{a} кратно {b}");
if (a % b != 0)
    System.Console.WriteLine($"{a} НЕ кратно {b}");

double c=23;
 if (a % c == 0)
     System.Console.WriteLine($"{a} кратно {c}");
 if (a % c != 0)
     System.Console.WriteLine($"{a} НЕ кратно {c}");
     
if (a % b == 0 && a % c == 0) //  допустим 161  или  322 будет кратно  обоим числам ОДНОВРЕМЕННО
System.Console.WriteLine($"{a} одновременно кратно {b} и {c}");
 if (a % b != 0 || a % c != 0) //  допустим 161  или  322 будет кратно  обоим числам ОДНОВРЕМЕННО
System.Console.WriteLine($"{a} одновременно НЕ кратно числам {b} и {c}");
