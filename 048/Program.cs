//Задан массив a из N элементов. Заполнить массив случайными числами от 1 до 10.
// Создайте массив, который является произведением пар чисел в одномерном массиве 
//a. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int N = 0;
System.Console.Write("Введите Длинну массива:");
N = Convert.ToInt32(Console.ReadLine());
int[] a=new int[N];
Random random=new Random();
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(0,11);  // задали  масссив N   из чисел  от 0 до 10  (11-1)  

for(int i=0;i<a.Length;i++)
     System.Console.Write($" {a[i]} ");
System.Console.WriteLine();   //просто наглядно показали- вывели массив на экран


 int sum = 0;                                    //***СУММА  ПРОИЗВЕДЕНИЙ  ПАР КРАЙНИХ ЗНАЧЕНИЙ***
    for (int i = 0; i <a.Length / 2; i++) // тут условие( делим на2) т.е. Начальный элемент движется от начала до середины, а в это же время  Карйний с конца элемент    
     {                                     //  движется от КОнца до середины, т.е  они встретятся и дальше середины нет смысла идти, поэтому и Массив  / 2  
       sum =sum + a[i] * a[a.Length - 1 - i];         //  сумма =  сумма + (начальный i * на последний i)    и перескакиваем по счетчику  пока i не дойдет до середины 
     }
 
    
 for (int i = 0; i <a.Length / 2; i++)   
 Console.WriteLine($"элемент {i} * элемент {a.Length - i - 1},  {a[i]}*{a[a.Length - i - 1]} = {a[i] * a[a.Length - i - 1]}");  
  //                 элемент {0} * элемент {1}               ,  {2}   *  {3}                 =   {4}       

 Console.WriteLine($"сумма произведений пар массива =  {sum}");