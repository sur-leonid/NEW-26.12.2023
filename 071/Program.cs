//Задача 71.Показать натуральные числа от N до 1, N задано


void Loop(int i, int N)  //рекурсивный метод
{
    System.Console.Write($"{N,3}");
    if (i < N && i >=1) Loop(i, N-1);//рекурсия
}


Loop(1, 30);

