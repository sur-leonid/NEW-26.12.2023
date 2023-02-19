// задача 78. С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1. Использовать рекурсию.


int Fib(int N)
{
    if (N==0) return 0;
        else
            if (N==1) return 1;
                else
                    return Fib(N-1)+Fib(N-2);
}

    System.Console.WriteLine(Fib(0));
    System.Console.WriteLine(Fib(1));
    System.Console.WriteLine($"{Fib(2)} сумма двухпредыдущих чисел ");
    System.Console.WriteLine($"{Fib(3)} сумма двухпредыдущих чисел ");
    System.Console.WriteLine($"{Fib(4)} сумма двухпредыдущих чисел ");
    System.Console.WriteLine($"{Fib(5)} сумма двухпредыдущих чисел ");
    System.Console.WriteLine($"{Fib(6)} сумма двухпредыдущих чисел ");
    System.Console.WriteLine($"{Fib(7)} сумма двухпредыдущих чисел ");