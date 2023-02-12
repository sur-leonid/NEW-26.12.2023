//Задача 56. Написать программу копирования массива

int[] a= {1, 2, 3, 4, 5};
//int[] b=new int[a.Length];
//string s;
//Array.Copy(a,b,a.Length);

PrintArray(a);
CopyArray(a);
System.Console.WriteLine();
PrintArray(a);

void PrintArray(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i]} ");
}
void Swap(ref int a, ref int b)
{
    int t=a;
    a=b;
    b=t;
}

void CopyArray(int[] a)
{
    for(int i=0;i<a.Length;i++)
    {
        Swap(ref a[i],ref a[i]);
    }

}