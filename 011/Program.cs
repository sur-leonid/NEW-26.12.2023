//Задача 11. Дано число больше 9. Вывести на экран  вторую цифру числа с конца

int n=123;
int d0,d1,d2;
d0=n%10;
d1=n/10%10;
d2=n/100;
System.Console.WriteLine($"{d2} {d1} {d0}");
System.Console.WriteLine($"{d1}");