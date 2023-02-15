// Задача 60. Показать двумерный массив размером m×n заполненный целыми случайными числами

int[,] Random2DArray(int M, int N,int min, int max)                      
{
    int[,] a=new int[M,N];
    Random random=new Random();
    for(int i=0;i<a.GetLength(0);i++)
        for(int j=0;j<a.GetLength(1);j++)
            a[i,j]=random.Next(min,max+1);
    return a;
} 

void Print2DArray(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
    for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j],6}");
    System.Console.WriteLine();
    }
}

    int[,] a=Random2DArray(5,5,0,10);
Print2DArray(a);