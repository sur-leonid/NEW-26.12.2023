// Задача 22. По двум заданным числам проверять является ли одно квадратом другого.
int a = 0;
int b = 0;
System.Console.Write("Введите a:");
a=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите b:");
b=Convert.ToInt32(Console.ReadLine());

if 
    (a * a == b)
   { 
    System.Console.WriteLine("b является квадратом а");
    }
        else
        { 
        System.Console.WriteLine("b НЕ является квадратом а");
        }
if (b * b == a)
    {
     System.Console.WriteLine("a является квадратом b");
    }
       else
       {
       System.Console.WriteLine("a НЕ  является квадратом  b");   
       }
