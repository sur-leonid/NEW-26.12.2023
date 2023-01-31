//задача 24. Определить номер четверти плоскости, 
//в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

// диапазоны четвертей для возможных координат
//1.четверть (x>0 and y>0)
//2.четверть (x<0 and y>0)
//3.четверть(x<0 and y<0)
//4.четверть (x>0 and y<0)
int x = 0;
int y = 0;

System.Console.Write("Введите x:");
x=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите y:");
y=Convert.ToInt32(Console.ReadLine());
 
 if(x==0 | y==0)  // если х или у  = 0   то условие не выполняется
   {    System.Console.WriteLine("заданные координаты не сооттветствуют условию "); 
    System.Console.WriteLine(" X - не равно 0 и Y- не равно 0 ");
    }

  else
      {
      if (x>0 & y>0) System.Console.WriteLine("по заданым координатам точка находится в 1 четверти");
      if (x<0 & y>0) System.Console.WriteLine("по заданым координатам точка находится во 2 четверти");
      if (x<0 & y<0) System.Console.WriteLine("по заданым координатам точка находится в 3 четверти");  
      if (x>0 & y<0) System.Console.WriteLine("по заданым координатам точка находится в 4 четверти"); 
      }

 