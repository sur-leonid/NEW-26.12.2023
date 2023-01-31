// Задача 13. Удалить вторую цифру целого числа введенного с клавиатуры.
int N=0;
System.Console.WriteLine("Введите число :");
N=Convert.ToInt32(Console.ReadLine());
int counterDigit=0;
int N1=N;
while(N!=0)
{
    counterDigit++;
    N/=10;
}
int d=N1/(int)Math.Pow(10,counterDigit-2)%10;
int d1=N1/(int)Math.Pow(10,counterDigit-1)%10;
int n2=N1%(int)Math.Pow(10,counterDigit-2);
System.Console.WriteLine(d1*Math.Pow(10,counterDigit-2)+n2);