// Задача 33.Возведите число А в натуральную степень B используя цикл
int number = 2;
int degree = 2;
int times = 1;
int result = number;

while (times < degree)
{
    result = result * number;
    times++;
}

System.Console.WriteLine($"{number} ^ {degree} = {result}");
System.Console.WriteLine();
