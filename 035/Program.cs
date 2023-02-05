//Задача 35. Подсчитать сумму цифр в числе. Сделать подпрограмму.
int a = 0;
System.Console.Write("Введите число :");
a=Convert.ToInt32(Console.ReadLine());

int SummDigit = 0;
System.Console.Write($"Сумма цифр числа {a} равна ");

while (a > 0)
{
    int digit = a % 10;
    SummDigit = SummDigit + digit;
    a = a / 10;
}

System.Console.WriteLine(SummDigit);
System.Console.WriteLine();

