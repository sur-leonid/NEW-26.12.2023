//15 С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет (Вывести: NO).
int n=0;
System.Console.WriteLine("Введите число :");
n=Convert.ToInt32(Console.ReadLine());
int counterDigit=0;
int N1=n;
if (N1<99)System.Console.WriteLine("NO");

else
{
while(n!=0)
{
    counterDigit++;
    n=n/10;
}
int d=N1/(int)Math.Pow(10,counterDigit-3)%10;
System.Console.WriteLine($"третья цифра в числе = {d}");
}
