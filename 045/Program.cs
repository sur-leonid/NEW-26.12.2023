//45 Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

//42. Задать массив из 3 элементов, заполненных числами из [-9, 9].
// Найти сумму положительных/отрицательных элементов массива

int[] a=new int[3];
Random random=new Random();
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(100,999);

for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i]} ");
System.Console.WriteLine();
int nechet=0;
for(int i=0;i<a.Length;i++)
    if (a[i]%2!=0)
        nechet++;

int chet=0;
for(int i=0;i<a.Length;i++)
    if (a[i]%2==0)
        chet++;
System.Console.WriteLine($"количество НЕчетных чисел:{nechet}");        
System.Console.WriteLine($"количество четных чисел:{chet}");  

