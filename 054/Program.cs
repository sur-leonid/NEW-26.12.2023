// 54 заждача. С клавиатуры вводится число N. 
//Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1

Double  Fibonacci(int n) // подпрограмма   фибоначи //здесь можно  чтобы возращался  формат или  "- int "  или побольше   "- Double"
{
 if(n == 0 || n == 1) return 1;
 else return Fibonacci(n-1) + Fibonacci(n-2);
}

int N=0;
System.Console.WriteLine("Введите число :");
N=Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < N; i++)   // задаем  поиск на перве  40 чисел в ряде фибоначи
{
 //Console.WriteLine(Fibonacci(i));
  Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}