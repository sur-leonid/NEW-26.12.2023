// Задача 36. Написать программу вычисления произведения чисел от 1 до N

System.Console.Write("Введите число:   ");
string writeN = Console.ReadLine();
int N = Convert.ToInt32(writeN);

int NumProizved(int N)
{
    int Proizved = 1;
    for (int i = 1; i <= N; i++)
    {
        Proizved = Proizved * i;
    }
    return Proizved;
}

System.Console.WriteLine($"Произведение чисел от 1 до {N} равно {NumProizved(N)}");
System.Console.WriteLine();