// Задача 82. C клавиатуры вводится строка разделенная точкой. Подсчитать количество символов до точки

string s="1232123.1232";

 int i=0;
 while (i<s.Length && s[i]!='.') i++;
    if (i==s.Length) 
     System.Console.WriteLine(-1);
    else
     System.Console.WriteLine(i);


System.Console.WriteLine(s.Split('.')[0].Length);

//System.Console.WriteLine(s.IndexOf('.'));  // ЭТО СПОСОБ короче гораааздо 