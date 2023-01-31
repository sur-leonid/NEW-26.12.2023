// задача 26. Программа проверяет пятизначное число на палиндромом. Например:12321
//15 С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет (Вывести: NO).
int n=0;
System.Console.WriteLine("Введите пятизначное число, попробуем проверить его на ПОЛИНДРОМНОСТЬ :");
n=Convert.ToInt32(Console.ReadLine());
int counterDigit=0;
int N1=n;

if (N1>99999 || N1<10000)
System.Console.WriteLine("Так! Соберись! Начни сначала и введи пять цифр! Не больше, но и не меньше!");

else
{
while(n!=0)
{
    counterDigit++;
    n=n/10;
}
int d1=N1/(int)Math.Pow(10,counterDigit-1)%10; //System.Console.WriteLine($"первая цифра в числе = {d1}");
int d2=N1/(int)Math.Pow(10,counterDigit-2)%10; //System.Console.WriteLine($"первая цифра в числе = {d2}");
int d3=N1/(int)Math.Pow(10,counterDigit-3)%10; //System.Console.WriteLine($"третья цифра в числе = {d3}");
int d4=N1/(int)Math.Pow(10,counterDigit-4)%10; //System.Console.WriteLine($"третья цифра в числе = {d4}");
int d5=N1/(int)Math.Pow(10,counterDigit-5)%10; //System.Console.WriteLine($"третья цифра в числе = {d5}");

if(d1==d5 && d2==d4)  // если число 1 равно числу 5     и 2число равно числу 4
   { 
     System.Console.WriteLine("Данное пятизначное число является полиндромом! Поздравляю! "); 
   }

  else
      {
       System.Console.WriteLine("Ну нет это точно НЕ полиндром!!!");
      }
}
