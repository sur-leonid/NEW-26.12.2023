// Задача 64.В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты по значению.
int[,] Random2DArray(int n, int k,int min, int max)                      
{
    int[,] a=new int[n,k];
    Random random=new Random();
    for(int i=0;i<a.GetLength(0);i++)
        for(int j=0;j<a.GetLength(1);j++)
            a[i,j]=random.Next(min,max+1);
    return a;
} 
void Print2DArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
            System.Console.Write($"{a[i, j],6}");
        System.Console.WriteLine();
    }
}

int ChangeGradeArray(int[,] a)
{
    int Degree2 = 0;
    {
        for (int i = 0; i < a.GetLength(0); i++)
        if (i%2 == 0 && i>0) 
           { for (int j = 0; j < a.GetLength(1); j++)
                if (j%2 == 0 && j>0) 
                {
                  a[i, j] = a[i, j] * a[i, j];
                }
           }
    }
    return Degree2;
}

int[,] a = Random2DArray(5, 5, 0, 9);
Print2DArray(a);

ChangeGradeArray(a);
System.Console.WriteLine();
Print2DArray(a);