// Задача 7. Выяснить является ли число чётным.

int a=0;
System.Console.Write("Введите число:");
a = Convert.ToInt32(Console.ReadLine());
bool CHETN= a%2==0;

if (CHETN) /// означает что переменая CHETN  - истина   ( просто слово истина опущена в синтексисе)
{
    System.Console.WriteLine($"Число {a} четное");
}
else
{
     Console.Write(a);
     Console.Write(" число НЕ четное");
     
}