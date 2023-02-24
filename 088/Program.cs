// задача 88. Заменить все вхождения подстроки w в строке st на строку v. Вывести на экран первоначальную строку и конечную строку
string s="wwoooww";
System.Console.WriteLine(s);
System.Console.WriteLine();
string s1="w";
string s2="v";

s=s.Replace(s1,s2);
System.Console.WriteLine(s);