// Задача 61. Показать двумерный массив размером m×n заполненный вещественными случайными числами

double[,] Random2DArrayDouble(int M, int N,int min, int max)                      
{
    double[,] a=new double [M,N];
    Random random=new Random();
    for(int i=0;i<a.GetLength(0);i++)
        for(int j=0;j<a.GetLength(1);j++)
            a[i,j]=random.Next(min,max+1);
    return a;
} 

void Print2DArray(double[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
    for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j],9 :F3}");
    System.Console.WriteLine();
    }
}

    double[,] a=Random2DArrayDouble(5,5,0,10);
Print2DArray(a);