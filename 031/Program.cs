31. Вывести на экран кубы чисел от 1 до N
System.Console.Write("Введите число:   ");
string numN = Console.ReadLine();
int N = Convert.ToInt32(numN);

int[] Cube(int N)
{
    int[] cubs = new int[N];
    int a = 1;
    for (int i = 0; i < N; i++)
    {
        cubs[i] = a * a * a;
        a++;
    }
    return cubs;
}

void PrintCubs(int[] array)
{
    int number = 1;
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{number} ^ 3 = ");
        System.Console.WriteLine(array[i]);
        number++;
    }
}

 int[] CubeTable = Cube(N);
 PrintCubs(CubeTable);

