//46. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]



int[] a=new int[123];
Random random=new Random();
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(0,9);

System.Console.Write($" массив {a.Length} чисел  : ");
for(int i=0;i<a.Length;i++)
 
    System.Console.Write($" {a[i]} ");
System.Console.WriteLine();

System.Console.Write("массив  чисел  с 10 по 99 : ");
for(int i=10;i<99;i++)
    System.Console.Write($"{a[i]} ");
System.Console.WriteLine();



int num = 0;
for(int i=10;i<99;i++)
if (i>=10 && i<=99)
num++;
  
System.Console.Write($" количество  чисел  с 10 по 99  = {num} :");
