// 41. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int[] a;
a=new int[8];
Random random=new Random();//Описание и создание объект
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(0,2); // второй парпметр задается с поправкой на+1

for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i]} ");
System.Console.WriteLine(); 