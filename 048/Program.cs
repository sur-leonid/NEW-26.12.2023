//Задан массив a из N элементов. Заполнить массив случайными числами от 1 до 10.
// Создайте массив, который является произведением пар чисел в одномерном массиве 
//a. Парой считаем первый и последний элемент, второй и предпоследний и т.д.


int N=0;
System.Console.Write("Введите Длинну массива:");
N=Convert.ToInt32(Console.ReadLine());
int[] a=new int[N];
Random random=new Random();
if (N%2!=0)
  System.Console.WriteLine($" {((N-1)/2)} индекс (считаем с 0- нулевого) в данном массиве не имеет пары:");      



for(int i=0;i<a.Length;i++)
    a[i]=random.Next(1,11);

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
