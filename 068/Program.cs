// Задача 68.Написать программу, которая обменивает элементы первой строки и последней строки
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

void Swap(ref int a, ref int b)
{
    int t=a;
    a=b;
    b=t;
}    
// void ChangeArrayRow(int[,] a,int i)
// {
//     //for(int i=0;i<a.GetLength(0);i++)
     
//         for(int j=0;j<a.GetLength(1)/2;j++)
//        {
//        Swap(ref a[i,j], ref a[i,a.GetLength(1)-j-1] );
//        }
    
// }


void ChangeArrayRow2(int[,] a,int row1, int row2)
{
    //for(int i=0;i<a.GetLength(0);i++)
     
        for(int j=0;j<a.GetLength(1);j++)
       {
       Swap(ref a[row1,j], ref a[row2,j] );
       }
    
}

int[,] a=Random2DArray(3,3,0,9);
Print2DArray(a);

// ChangeArrayRow(a,a.GetLength(1)-1);
// System.Console.WriteLine();
// Print2DArray(a);

ChangeArrayRow2(a,0,a.GetLength(1)-1);
System.Console.WriteLine();
Print2DArray(a);