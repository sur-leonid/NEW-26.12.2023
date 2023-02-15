// Задача 62. В двумерном массиве n×k заменить четные элементы на противоположные по значению
// (a[i,j]=-a[i,j]). Написать отдельную подпрограмму на вход которой подается массив, а на выходе измененный массив.

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
    for(int i=0;i<a.GetLength(0);i++)
    {
    for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j],6}");
    System.Console.WriteLine();
    }
}


void ChangeArray(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
    for(int j=0;j<a.GetLength(1);j++)
       {
       a[i,j]=-a[i,j];
       }
    }
}

int[,] a=Random2DArray(3,3,0,9);
Print2DArray(a);

ChangeArray(a);
System.Console.WriteLine();
Print2DArray(a);